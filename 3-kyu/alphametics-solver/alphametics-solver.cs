using System;
using System.Collections.Generic;
using System.Linq;
​
public class Cryptarithm
{
    public static string Alphametics(string equation)
    {
        // Parse LHS words and RHS word
        var sides      = equation.Split('=');
        var leftWords  = sides[0].Split('+').Select(p => p.Trim()).ToArray();
        var rightWord  = sides[1].Trim();
​
        var solver = new Solver(leftWords, rightWord);
        if (!solver.Solve())
            throw new InvalidOperationException("No solution (should never happen)");
        return solver.GetSolution();
    }
​
    // Encapsulates all state & optimized search
    private class Solver
    {
        private readonly string[] leftWords;
        private readonly string   rightWord;
        private readonly char[]   letters;         // letters in descending weight order
        private readonly long[]   weights;         // corresponding place‐value weight (LHS +, RHS –)
        private readonly bool[]   cannotBeZero;    // same order as letters
​
        private readonly int[]    map    = new int[256];
        private readonly bool[]   used   = new bool[10];
​
        public Solver(string[] leftWords, string rightWord)
        {
            this.leftWords = leftWords;
            this.rightWord = rightWord;
​
            // 1) Compute raw weights per letter
            var rawWeight = new Dictionary<char, long>();
            Action<string, int> addWord = (w, sign) =>
            {
                for (int pos = 0; pos < w.Length; pos++)
                {
                    // pos=0 is leftmost; weight = 10^(length-1-pos)
                    long place = (long)Math.Pow(10, w.Length - 1 - pos);
                    rawWeight[w[pos]] = rawWeight.GetValueOrDefault(w[pos]) + sign * place;
                }
            };
​
            foreach (var w in leftWords)  addWord(w, +1);
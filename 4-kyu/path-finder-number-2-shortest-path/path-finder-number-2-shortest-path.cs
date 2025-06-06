using System.Collections.Generic;
using System.Linq;
​
public class Finder
{
    public static int PathFinder(string maze)
    {
        var rows = maze.Split('\n');
        int n = rows.Length;
        char[,] grid = new char[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; ++j)
            {
                grid[i, j] = rows[i][j];
            }
        }
      
        int[] dr = { -1, 0, 1, 0 };
        int[] dc = { 0, 1, 0, -1 };
      
        bool[,] visited = new bool[n, n];
        var q = new Queue<(int r, int c, int dist)>();
        q.Enqueue((0, 0, 0));
        visited[0, 0] = true;
        while (q.Count > 0)
        {
            var (r, c, dist) = q.Dequeue();
          
            if (r == n - 1 && c == n - 1)
            {
                return dist;
            }
          
            for (int k = 0; k < 4; ++k)
            {
                int nr = r + dr[k];
                int nc = c + dc[k];
              
                if (nr >= 0 && nr < n && nc >= 0 && nc < n && !visited[nr, nc] && grid[nr, nc] == '.')
                {
                    visited[nr, nc] = true;
                    q.Enqueue((nr, nc, dist + 1));
                }
            }
        }
        return -1;
    }
}

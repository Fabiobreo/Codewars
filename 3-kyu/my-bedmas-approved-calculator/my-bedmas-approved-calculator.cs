            else if (char.IsDigit(c) || c == '.')
            {
                int start = i;
                while (i < s.Length && (char.IsDigit(s[i]) || s[i] == '.'))
                    i++;
                string token = s.Substring(start, i - start);
                if (double.TryParse(token, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double num))
                    values.Push(num);
                else
                    throw new FormatException($"Invalid number '{token}'");
            }
            // Operator
            else if ("+-*/^".IndexOf(c) >= 0)
            {
                // While top of ops has same or greater precedence:
                while (ops.Count > 0 && ops.Peek() != '(')
                {
                    char top = ops.Peek();
                    int p1 = Prec(top);
                    int p2 = Prec(c);
                    // For right-assoc ops, use strict >; for left-assoc, >=
                    if (p1 > p2 || (p1 == p2 && !IsRightAssociative(c)))
                        ApplyOp();
                    else
                        break;
                }
                ops.Push(c);
                i++;
            }
            else
            {
                throw new InvalidOperationException($"Unexpected character '{c}'");
            }
        }
​
        // Remaining operators
        while (ops.Count > 0)
            ApplyOp();
​
        // The result is the lone value on the stack
        return values.Pop();
    }
}
namespace LibrarySample
{
    public static class MathSolver
    {
        [Obsolete("Ez egy béna spagetti kód, ugyan helyesen működik, de inkább használd az Evaluate függvényt!")]
        public static decimal ShitEvaluate(string expression)
        {
            char @operator = ' ';
            string operand1 = "";
            string operand2 = "";
            foreach (char item in expression)
            {
                if (item != ' ')
                {
                    if (char.IsDigit(item))
                    {
                        if(@operator == ' ')
                        {
                            operand1 += item;
                        }
                        else
                        {
                            operand2 += item;
                        }
                    }
                    else
                    {
                        if (item == ',')
                        {
                            if (@operator == ' ')
                            {
                                operand1 += item;
                            }
                            else
                            {
                                operand2 += item;
                            }
                        }
                        else
                        {
                            @operator = item;
                        }
                    }
                }
            }
            switch (@operator)
            {
                case '+':
                    return decimal.Parse(operand1) + decimal.Parse(operand2);
                case '-':
                    return decimal.Parse(operand1) - decimal.Parse(operand2);
                case '*':
                    return decimal.Parse(operand1) * decimal.Parse(operand2);
                case '/':
                    return decimal.Parse(operand1) / decimal.Parse(operand2);
                default:
                    throw new InvalidOperationException();
            }
        }

        public static decimal Evaluate(string expression)
        {
            char[] operators = { '+', '-', '*', '/' };
            int idx = expression.IndexOfAny(operators);
            char @operator = expression[idx];
            var splits = expression.Split(@operator);
            switch (@operator)
            {
                case '+':
                    return decimal.Parse(splits[0]) + decimal.Parse(splits[1]);
                case '-':
                    return decimal.Parse(splits[0]) - decimal.Parse(splits[1]);
                case '*':
                    return decimal.Parse(splits[0]) * decimal.Parse(splits[1]);
                case '/':
                    return decimal.Parse(splits[0]) / decimal.Parse(splits[1]);
                default:
                    throw new InvalidOperationException();
            }
        }

    }
}
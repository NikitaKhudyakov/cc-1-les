namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            if (args.Length > 2)
            {
                list.Add(double.Parse(args[0]));
                for (int i = 1; i < args.Length; i++)
                {
                    switch (args[i])
                    {
                        case "*":
                            list.Remove(list.Last());
                            list.Add(double.Parse(args[i - 1]) * double.Parse(args[i + 1]));
                            break;
                        case "/":
                            if (args[i + 1] == "0")
                                Console.WriteLine("На ноль делить нельзя!");
                            else
                            {
                                list.Remove(list.Last());
                                list.Add(double.Parse(args[i - 1]) / double.Parse(args[i + 1]));
                            }
                            break;
                        case "+":
                            list.Add(double.Parse(args[i + 1]));
                            break;
                        case "-":
                            list.Add(-1 * double.Parse(args[i + 1]));
                            break;
                    }
                }
                Console.WriteLine(args.ToString() + "=" + list.Sum());
            }
            else
                Console.WriteLine("Ошибка ввода!");
        }
    }
}
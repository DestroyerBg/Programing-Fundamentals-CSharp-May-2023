namespace Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrToBeExchanged = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments= input
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string instruction= arguments[0];
                if (instruction== "exchange")
                {
                    int index = int.Parse(arguments[1]);
                   arrToBeExchanged= Exchange(arrToBeExchanged, index);
                }
                else if (instruction== "max")
                {
                    string evenOrOdd= arguments[1];
                    maxEvenOrOdd(arrToBeExchanged, evenOrOdd);
                }
                else if (instruction == "min")
                {
                    string evenOrOdd = arguments[1];
                    minEvenOrOdd(arrToBeExchanged, evenOrOdd);

                }
                else if (instruction == "first")
                {
                    int count = int.Parse(arguments[1]);
                    string evenOrOdd = arguments[2];
                    FirstEvenOrOdd(count, evenOrOdd, arrToBeExchanged);
                }
                else if (instruction == "last")
                {
                    int count = int.Parse(arguments[1]);
                    string evenOrOdd = arguments[2];
                    LastEvenOrOdd(count, evenOrOdd, arrToBeExchanged);
                }
            }
            string result = $"[" + string.Join(", ", arrToBeExchanged) + "]";
            Console.WriteLine(result);
        }

        private static void LastEvenOrOdd(int count, string evenOrOdd, int[] arrToBeExchanged)
        {
            if (count > arrToBeExchanged.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> firstOdd = new List<int>();
            if (evenOrOdd=="even")
            {
                for (int i = arrToBeExchanged.Length-1; i >= 0; i--)
                {
                    if (arrToBeExchanged[i] % 2 == 0)
                    {
                        firstOdd.Add(arrToBeExchanged[i]);
                    }

                    if (firstOdd.Count == count)
                    {
                        break;
                    }
                }
                if (firstOdd.Count == 0)
                {
                    Console.WriteLine($"[]");
                }
                else
                {
                    string result = $"[" + string.Join(", ", firstOdd) + "]";
                    Console.WriteLine(result);
                }
            }
            else if (evenOrOdd=="odd")
            {
                for (int i = arrToBeExchanged.Length-1; i >= 0; i--)
                {
                    if (arrToBeExchanged[i] % 2 == 1)
                    {
                        firstOdd.Add(arrToBeExchanged[i]);
                    }

                    if (firstOdd.Count == count)
                    {
                        break;
                    }
                }
                if (firstOdd.Count == 0)
                {
                    Console.WriteLine($"[]");
                }
                else
                {
                    string result = $"[" + string.Join(", ", firstOdd) + "]";
                    Console.WriteLine(result);
                }
            }
        }

        private static void FirstEvenOrOdd(int count, string evenOrOdd, int[] arrToBeExchanged)
        {
            if (count > arrToBeExchanged.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<int> firstOdd= new List<int>();
            if (evenOrOdd == "even")
            {
                for (int i = 0; i < arrToBeExchanged.Length; i++)
                {
                    if (arrToBeExchanged[i]%2==0)
                    {
                        firstOdd.Add(arrToBeExchanged[i]);
                    }

                    if (firstOdd.Count==count)
                    {
                        break;
                    }
                }

                if (firstOdd.Count==0)
                {
                    Console.WriteLine($"[]");
                }
                else
                {
                    string result = $"[" + string.Join(", ", firstOdd) + "]";
                    Console.WriteLine(result);
                }
            }
            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < arrToBeExchanged.Length; i++)
                {
                    if (arrToBeExchanged[i] % 2 == 1)
                    {
                        firstOdd.Add(arrToBeExchanged[i]);
                    }

                    if (firstOdd.Count == count)
                    {
                        break;
                    }
                }

                if (firstOdd.Count == 0)
                {
                    Console.WriteLine($"[]");
                }
                else
                {
                    string result = $"[" + string.Join(", ", firstOdd) + "]";
                    Console.WriteLine(result);
                }
            }
        }

        private static void minEvenOrOdd(int[] arrToBeExchanged, string evenOrOdd)
        {
            int numberIndex = -1;
            int currNum = int.MaxValue;
            if (evenOrOdd == "even")
            {
                for (int i = 0; i < arrToBeExchanged.Length; i++)
                {
                    if (arrToBeExchanged[i] % 2 == 0 && arrToBeExchanged[i] <= currNum)
                    {
                        numberIndex = i;
                        currNum = arrToBeExchanged[i];
                    }
                }
                if (numberIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(numberIndex);
                }

            }
            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < arrToBeExchanged.Length; i++)
                {
                    if (arrToBeExchanged[i] % 2 == 1 && arrToBeExchanged[i] <= currNum)
                    {
                        numberIndex = i;
                        currNum = arrToBeExchanged[i];
                    }
                }
                if (numberIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(numberIndex);
                }

            }

            
        }

        private static void maxEvenOrOdd(int[] arrToBeExchanged, string evenOrOdd)
        {
           
            int numberIndex = -1;
            int currNum = 0;
            if (evenOrOdd=="even")
            {
                for (int i = 0; i < arrToBeExchanged.Length; i++)
                {
                    if (arrToBeExchanged[i] % 2 == 0 && arrToBeExchanged[i] >= currNum)
                    {
                        numberIndex = i;
                        currNum = arrToBeExchanged[i];
                    }
                }
                if (numberIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(numberIndex);
                }

            }
            else if (evenOrOdd=="odd")
            {
                for (int i = 0; i < arrToBeExchanged.Length; i++)
                {
                    if (arrToBeExchanged[i] % 2 == 1 && arrToBeExchanged[i] >= currNum)
                    {
                        numberIndex = i;
                        currNum = arrToBeExchanged[i];
                    }
                }

                if (numberIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(numberIndex);
                }

            }

        }

        private static int[] Exchange(int[] arrToBeExchanged, int index)
        {
            if (index<0 || index>arrToBeExchanged.Length-1)
            {
                Console.WriteLine("Invalid index");
                return arrToBeExchanged;
            }

            int[] newArr= new int[arrToBeExchanged.Length];
            int newArrIndex = 0;
            for (int i = index+1; i <= arrToBeExchanged.Length-1; i++)
            {
                newArr[newArrIndex++]= arrToBeExchanged[i];
            }

            for (int i = 0; i <= index; i++)
            {
                newArr[newArrIndex++] = arrToBeExchanged[i];
            }
            return newArr;
        }
    }

    
}
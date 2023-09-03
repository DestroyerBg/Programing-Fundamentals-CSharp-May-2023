using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

int[] arrayToBeManupulated = Console
    .ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] argument = input.Split().ToArray();
    string command = argument[0];

    if (command == "exchange")
    {
        int index = int.Parse(argument[1]);
        arrayToBeManupulated = ExchangeArray(arrayToBeManupulated, index);
    }
    else if (command == "max")
    {
        string commandOne = argument[1];
        maxEvenOrOddfinder(arrayToBeManupulated, commandOne);

    }
    else if (command == "min")
    {
        string commandOne = argument[1];
        int foundNum = MinEvenOrOddFinder(arrayToBeManupulated, commandOne);

    }


    else if (command == "first")
    {
        int index = int.Parse(argument[1]);
        string commandtwo = argument[2];
        FirstOddFinder(arrayToBeManupulated, index, commandtwo);

    }
    else if (command == "last")
    {
        int index = int.Parse(argument[1]);
        string commandTwo = argument[2];
        LastTwo(arrayToBeManupulated, index, commandTwo);
    }


}


static int[] ExchangeArray(int[] arrayToBeManupulated, int index)
{
    if (CheckForOutOfRange(arrayToBeManupulated, index) == true)
    {
        Console.WriteLine("Invalid index");
        return arrayToBeManupulated;
    }
    else
    {
        int[] changedArr = new int[arrayToBeManupulated.Length];
        int changedArrIndex = 0;
        for (int i = index + 1; i <= arrayToBeManupulated.Length - 1; i++)
        {
            changedArr[changedArrIndex++] = arrayToBeManupulated[i];
        }
        for (int i = 0; i <= index; i++)
        {
            changedArr[changedArrIndex++] = arrayToBeManupulated[i];
        }
        return changedArr;

    }







}




PrintAlreadyManipulatedArray(arrayToBeManupulated);




static bool CheckForOutOfRange(int[] arrayToBeManupulated, int index)
{
    if (index < 0 || index > arrayToBeManupulated.Length - 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
static void maxEvenOrOddfinder(int[] arrayToBeManupulated, string commandOne)
{
    if (commandOne == "even")
    {
        bool isFound = false;
        int evenNumber = int.MinValue;
        int evenNumberIndex = 0;
        for (int i = 0; i < arrayToBeManupulated.Length; i++)
        {
            if (arrayToBeManupulated[i] % 2 == 0 && arrayToBeManupulated[i] > evenNumber || arrayToBeManupulated[i] == evenNumber)
            {
                evenNumber = arrayToBeManupulated[i];
                evenNumberIndex = Array.IndexOf(arrayToBeManupulated, arrayToBeManupulated[i]);
                isFound = true;
            }
        }
        if (evenNumberIndex != 0)
        {
            PrintAlreadyGotNumber(evenNumberIndex, true);

        }
        else if (isFound == true && evenNumberIndex == 0)
        {
            PrintAlreadyGotNumber(evenNumberIndex, true);
        }
        else if (isFound == false)
        {
            PrintAlreadyGotNumber(evenNumberIndex, false);
        }

    }
    else if (commandOne == "odd")
    {
        bool isFound = false;
        int oddNumber = int.MinValue;
        int oddNumberIndex = 0;
        for (int i = 0; i < arrayToBeManupulated.Length; i++)
        {
            if (arrayToBeManupulated[i] % 2 == 1 && arrayToBeManupulated[i] > oddNumber || arrayToBeManupulated[i] == oddNumber)
            {
                oddNumber = arrayToBeManupulated[i];
                oddNumberIndex = Array.IndexOf(arrayToBeManupulated, arrayToBeManupulated[i]);
                isFound = true;
            }
        }
        if (oddNumberIndex != 0)
        {
            PrintAlreadyGotNumber(oddNumberIndex, true);

        }
        else if (isFound == true && oddNumberIndex == 0)
        {
            PrintAlreadyGotNumber(oddNumberIndex, true);
        }
        else if (isFound == false)
        {
            PrintAlreadyGotNumber(oddNumberIndex, false);
        }
    }



}
static void PrintAlreadyManipulatedArray(int[] arrayToBeManupulated)
{
    Console.Write("[");
    Console.Write(string.Join(", ", arrayToBeManupulated));
    Console.WriteLine("]");
    Console.WriteLine();
}
static void PrintAlreadyGotNumber(int foundNum, bool boolean)
{
    if (foundNum == 0 && boolean == false)
    {
        Console.WriteLine("No matches");
    }
    else if (foundNum == 0 && boolean == true)
    {
        Console.WriteLine(foundNum);
    }
    else if (foundNum != 0)
    {
        Console.WriteLine(foundNum);
    }
}
static int MinEvenOrOddFinder(int[] arrayToBeManupulated, string commandOne)
{
    if (commandOne == "even")
    {
        bool isFound = false;
        int evenNumber = int.MaxValue;
        int evenNumberIndex = 0;
        for (int i = 0; i < arrayToBeManupulated.Length; i++)
        {
            if (arrayToBeManupulated[i] % 2 == 0 && arrayToBeManupulated[i] < evenNumber || arrayToBeManupulated[i] == evenNumber)
            {
                evenNumber = arrayToBeManupulated[i];
                evenNumberIndex = Array.IndexOf(arrayToBeManupulated, arrayToBeManupulated[i]);
                isFound = true;
            }
        }
        if (evenNumberIndex != 0)
        {
            PrintAlreadyGotNumber(evenNumberIndex, true);

        }
        else if (isFound == true && evenNumberIndex == 0)
        {
            PrintAlreadyGotNumber(evenNumberIndex, true);
        }
        else if (isFound == false)
        {
            PrintAlreadyGotNumber(evenNumberIndex, false);
        }
    }
    else if (commandOne == "odd")
    {
        bool isFound = false;
        int oddNumber = int.MaxValue;
        int oddNumberIndex = 0;
        for (int i = 0; i < arrayToBeManupulated.Length; i++)
        {
            if (arrayToBeManupulated[i] % 2 == 1 && arrayToBeManupulated[i] < oddNumber || arrayToBeManupulated[i] == oddNumber)
            {
                oddNumber = arrayToBeManupulated[i];
                oddNumberIndex = Array.IndexOf(arrayToBeManupulated, arrayToBeManupulated[i]);
                isFound = true;
            }
        }
        if (oddNumberIndex != 0)
        {
            PrintAlreadyGotNumber(oddNumberIndex, true);

        }
        else if (isFound == true && oddNumberIndex == 0)
        {
            PrintAlreadyGotNumber(oddNumberIndex, true);
        }
        else if (isFound == false)
        {
            PrintAlreadyGotNumber(oddNumberIndex, false);
        }
    }
    return 0;
}
static void FirstOddFinder(int[] arrayToBeManupulated, int index, string commandtwo)
{
    int[] firstCount = new int[index];
    if (index > arrayToBeManupulated.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }
    if (commandtwo == "even")
    {
        int firstElementsCount = 0;
        bool IsElementFound = false;
        int firstCountArrIndex = 0;
        for (int i = 0; i < arrayToBeManupulated.Length; i++)
        {
            if (firstElementsCount == index)
            {
                IsElementFound = true;
                break;
            }
            else
            {
                if (arrayToBeManupulated[i] % 2 == 0)
                {
                    firstCount[firstCountArrIndex] = arrayToBeManupulated[i];
                    firstElementsCount++;
                    firstCountArrIndex++;
                    IsElementFound = true;
                }
            }

        }

        if (IsElementFound == true)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", firstCount));
            Console.Write("]");
            Console.WriteLine();

        }
        else
        {
            Console.Write("[");
            Console.Write("]");
            Console.WriteLine();
        }
    }
    else if (commandtwo == "odd")
    {
        int firstElementsCount = 0;
        bool IsElementFound = false;
        int firstCountArrIndex = 0;
        for (int i = 0; i < arrayToBeManupulated.Length; i++)
        {
            if (firstElementsCount == index)
            {
                IsElementFound = true;
                break;
            }
            else
            {
                if (arrayToBeManupulated[i] % 2 == 1)
                {
                    firstCount[firstCountArrIndex] = arrayToBeManupulated[i];
                    firstElementsCount++;
                    firstCountArrIndex++;
                    IsElementFound = true;

                }
            }

        }
        if (IsElementFound == true)
        {
            DeleteZeroesFromArray(firstCount);

        }
        else
        {
            Console.Write("[");
            Console.Write("]");
            Console.WriteLine();
            return;

        }
    }

}

static void DeleteZeroesFromArray(int[] firstCount)
{
    int nonZeroCount = 0;
    for (int i = 0; i < firstCount.Length; i++)
    {
        if (firstCount[i] > 0)
        {
            nonZeroCount++;
        }
    }
    int[] nonZeroArray = new int[nonZeroCount];
    if (nonZeroArray.Length == 0)
    {
        Console.Write("[");
        Console.Write("]");
        Console.WriteLine();
        return;
    }
    else
    {
        int index = 0;
        for (int i = 0; i < firstCount.Length; i++)
        {

            if (firstCount[i] > 0)
            {
                nonZeroArray[index] = firstCount[i];
                index++;
            }
        }
        Array.Resize(ref nonZeroArray, nonZeroCount);


    }
    Console.Write("[");
    Console.Write(string.Join(", ", nonZeroArray));
    Console.Write("]");
    Console.WriteLine();

}

static void LastTwo(int[] arrayToBeManupulated, int index, string commandTwo)
{
    int[] lastCount = new int[index];
    if (index > arrayToBeManupulated.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }
    if (commandTwo == "even")
    {
        int lastCountIndex = 0;
        bool isFound = false;
        int foundNumIndex = 0;
        for (int i = 0; i < arrayToBeManupulated.Length; i++)
        {

            if (foundNumIndex == index)
            {
                isFound = true;
                if (arrayToBeManupulated[i] % 2 == 0)
                {
                    for (int k = 0; k < lastCount.Length; k++)
                    {
                        if (k + 1 > lastCount.Length)
                        {
                            break;
                        }
                        lastCount[k] = lastCount[k + 1];
                        lastCount[lastCount.Length - 1] = arrayToBeManupulated[i];
                    }
                }
            }
            if (arrayToBeManupulated[i] % 2 == 0)
            {
                lastCount[lastCountIndex] = arrayToBeManupulated[i];
                foundNumIndex++;
                lastCountIndex++;
                isFound = true;

            }








        }

        if (isFound == true)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", lastCount));
            Console.Write("]");
            Console.WriteLine();
        }
        else
        {
            Console.Write("[");
            Console.Write("]");
            Console.WriteLine();
        }

    }
    else if (commandTwo == "odd")
    {
        int lastCountIndex = 0;
        bool isFound = false;
        int foundNumIndex = 0;
        for (int i = 0; i < arrayToBeManupulated.Length; i++)
        {

            if (foundNumIndex == index)
            {
                isFound = true;
                if (arrayToBeManupulated[i] % 2 == 1)
                {
                    
                    for (int k = 0; k < lastCount.Length; k++)
                    {
                        if (k>lastCount.Length-1 || k+1>lastCount.Length-1)
                        {
                            break;
                        }
                        if (lastCount[k+1]==lastCount.Length-1)
                        {
                            continue;
                        }
                        lastCount[k] = lastCount[k + 1];
                       

                    }

                    continue;
                }
            }
            if (arrayToBeManupulated[i] % 2 == 1)
            {
                lastCount[lastCountIndex] = arrayToBeManupulated[i];
                foundNumIndex++;
                lastCountIndex++;
                isFound = true;

            }








        }
        if (isFound == true)
        {
            DeleteZeroesFromArray(lastCount);

        }
        else
        {
            Console.Write("[");
            Console.Write("]");
            Console.WriteLine();
            return;

        }

    }


}
//In fiture debugging//

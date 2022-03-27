Exercise11();
static void Exercise1()
{
    int[] setOfNumbers = new int[20];
    //element = its index * 5
    //initializing each element;
    for (int i = 0; i < setOfNumbers.Length; i++)
    {
        setOfNumbers[0] = i * 5;

    }

    Console.WriteLine();
    for (int i = 0; i < setOfNumbers.Length; i++)
    {
        Console.Write(" {0}", i);
    }
}

static void Exercise2()
{
    Console.WriteLine("Enter a Value for the length of Array A");
    int lengthOfA = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a Value for the length of Array B");
    int lengthOfB = int.Parse(Console.ReadLine());

    bool lengthsAreEqual = lengthOfA == lengthOfB;
    int[] arrayA = new int[lengthOfA];
    int[] arrayB = new int[lengthOfB];
    Console.WriteLine("Enter the elements of the first Array");
    for (int i = 0; i < lengthOfA; i++)
    {
        arrayA[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Enter the elements of the second Array");
    for (int i = 0; i < lengthOfB; i++)
    {
        arrayB[i] = int.Parse(Console.ReadLine());
    }
    if (lengthsAreEqual)
    {
        for (int i = 0; i < lengthOfA; i++)
        {
            bool elementsAreEqual = arrayA[i] == arrayB[i];
        }
        if (lengthsAreEqual)
        {
            Console.WriteLine("Array A and B are Equal");
        }
        else
        {
            Console.WriteLine("Array A and B are not Equal");
        }
    }
    else
    {
        Console.WriteLine("Array A and B are not Equal");
    }
}

static void Exercise3()
{
    char[] arrayA = { 'i', 'r', 'u', 'o', 'm', 'a' };
    char[] arrayB = { 'O', 'l', 'u', 'c', 'h', 'i' };
    //to remind us if any element in A has been found to be greater than it's corresponding B element and vice versa
    var arrayAIsGreater = 0;
    var arrayBIsGreater = 0;
    //to use the shorter character array's length in the loop
    var length = arrayA.Length <= arrayB.Length ? arrayA.Length : arrayB.Length;

    for (int i = 0; i < length; i++)
    {
        //do the comparison and break out of loop if any of the conditions hold 
        if (arrayA[i] > arrayB[i])
        {
            arrayAIsGreater += 1;
            break;
        }
        else if (arrayB[i] > arrayA[i])
        {
            arrayBIsGreater += 1;
            break;
        }

    }
    //to print out the correct message based on which condition was reached first
    if (arrayAIsGreater > arrayBIsGreater)
    {
        Console.WriteLine("Array B will come before Array A");
    }
    else if (arrayBIsGreater > arrayAIsGreater)
    {
        Console.WriteLine("Array A will come before Array B");
    }
    else//this is for a case where the loop reached the end without any of the conditions holding
    {   //the shorter array in this case is said to be smaller
        if (arrayA.Length < arrayB.Length)
        {
            Console.WriteLine("Array A will come before Array B");
        }
        else if (arrayB.Length < arrayA.Length)
        {
            Console.WriteLine("Array B will come before Array A");
        }
        else if (arrayA.Length == arrayB.Length)//for cases where both arrays are the same length.
        {
            Console.WriteLine("The two Arrays are Equal");
        }

    }
}

static void Exercise4()
{
    //maximal sequence of consecutive equal numbers in an array
    int[] setOfNumbers = { 1, 1, 2, 3, 4, 4, 4, 5, 4, 5, 7 };
    int start = 0;
    int bestStart = 0;
    int length = 1;
    int bestLength = 0;

    for (int i = 1; i < setOfNumbers.Length; i++)
    {
        if (setOfNumbers[i] == setOfNumbers[i - 1])
        {
            length += 1;
        }
        else
        {
            if (length > bestLength)
            {
                bestLength = length;
                bestStart = start;
            }
            start = i;
            length = 1;
        }
    }

    Console.WriteLine("The maximal sequence is from :");
    Console.WriteLine("Element {0} to {1}", setOfNumbers[bestStart], setOfNumbers[bestLength - 1]);

}

static void Exercise5()
{
    //maximal sequence of consecutively placed increasing numbers in an array
    int[] setOfNumbers = { 1, 1, 2, 3, 4, 4, 4, 5, 4, 5, 7 };
    int start = 0;
    int bestStart = 0;
    int length = 1;
    int bestLength = 0;

    for (int i = 1; i < setOfNumbers.Length; i++)
    {
        if (setOfNumbers[i] > setOfNumbers[i - 1])
        {
            length += 1;
        }
        else
        {
            if (length > bestLength)
            {
                bestLength = length;
                bestStart = start;
            }
            start = i;
            length = 1;
        }
    }

    Console.WriteLine("The maximal sequence is from :");
    Console.WriteLine("Element {0} to {1}", setOfNumbers[bestStart], setOfNumbers[bestLength - 1]);
}

static void Exercise6()
{
    //maximal sequence of increasing elements in an array, they must not be placed consecutively
    int[] arr = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
    int[] len = new int[arr.Length];//for the length of the longest consecutively increasing sequence
    len[0] = 1;
    int prev = 0;


    Console.WriteLine("The various increasing sequences that can be found in the array" +
        " arr = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 } includes:");
    for (int x = 0; x < arr.Length; x++)
    {
        for (int i = x + 1; i < arr.Length; i++)
        {

            if (arr[i] > arr[x])
            {
                len[i] = len[0] + 1;
                prev = arr[i];
                Console.WriteLine();
                Console.Write("{0}, {1}, ", arr[x], arr[i]);
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > prev)
                    {
                        len[i] += 1;
                        prev = arr[j];
                        Console.Write("{0}, ", prev);
                    }
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("The maximal sequence has a length of {0}", len.Max());
}

static void Exercise7()
{
    Console.WriteLine("Input an Integer number");
    int consecutiveNumbers = int.Parse(Console.ReadLine());
    Console.WriteLine("Input an Integer number for the elements of your array");
    int numberOfIntegers = int.Parse(Console.ReadLine());

    double[] array = new double[numberOfIntegers];
    double sum = 0;
    List<double> arrayOfSums = new List<double>();
    for (int i = 0; i < numberOfIntegers; i++)
    {
        Console.WriteLine("Input the element at index {0} of the array", i);
        array[i] = double.Parse(Console.ReadLine());
    }

    for (int i = 0; i < numberOfIntegers - consecutiveNumbers + 1; i++)
    {
        for (int k = i; k < consecutiveNumbers + i; k++)
        {
            sum += array[k];
            Console.Write("{0} ", array[k]);

        }
        arrayOfSums.Add(sum);
        Console.Write("with sum {0}", sum);
        Console.WriteLine();
    }
    var maximal = arrayOfSums.Max();
    Console.WriteLine($"The maximum sum is at row { arrayOfSums.IndexOf(maximal) + 1 } above");
}

static void Exercise8()
{
    int[] array = new int[5] { 23, 44, 12, 58, 34 };
    int n = 5;
    Console.WriteLine("Selection Sort Program");
    Console.Write("The Array to be sorted is : ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0} ", array[i]);
    }
    int buffer;
    int smallest;
    for (int i = 0; i < n - 1; i++)
    {
        smallest = i;
        for (int j = i + 1; j < n; j++)
        {
            if (array[j] < array[smallest])
            {
                smallest = j;
            }
        }
        buffer = array[smallest];
        array[smallest] = array[i];
        array[i] = buffer;
    }
    Console.WriteLine();
    Console.Write("The Sorted array is: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0} ", array[i]);
    }
}

static void Exercise9()
{
    //subsequence of numbers with maximal sum
    int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
    int currentSum = 0, currentMax = int.MinValue;
    int[] subSequence = new int[numbers.Length]; ;
    int counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {

        subSequence[counter] = numbers[i];
        currentSum += numbers[i];
        currentMax = currentSum > currentMax ? currentSum : currentMax;
        counter++;
        if (currentSum < 0)
        {
            counter = 0;
            currentSum = 0;
            continue;
        }

    }
    Console.WriteLine("Subsequence with Maximal sum is : ");
    foreach (var number in subSequence)
    {
        Console.Write("{0} ", number);
    }
}

static void Exercise10()
{
    //most frequently occurring element in an array
    int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
    int[] counter = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] == array[j])
            {
                counter[i]++;
            }
        }
    }
    int maxAppearance = counter.Max();
    int maxAppearanceIndex = Array.IndexOf(counter, maxAppearance);
    Console.WriteLine("{0} is the highest occuring number", array[maxAppearanceIndex]);
}

static void Exercise11()
{
    //sequence of neighbor elements that sums up to S
    int S = 11;
    int sum = 0;
    int[] array = { 4, 3, 1, 4, 2, 5, 8 };
    List<int> neighbors = new List<int>();

    for (int i = 0; i < array.Length - 1; i++)
    {
        int j = i;
        sum = 0;
        neighbors.Clear();
        while (sum < S + 1)
        {
            sum += array[j];
            neighbors.Add(array[j]);
            j++;
        }

        if (sum == S)
        {
            break;
        }
    }

    Console.WriteLine("The neighbor sequence is :");
    foreach (int i in neighbors)
    {
        Console.Write("{0} ", i);
    }
}
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assi_04_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            // first we create a stack frame it will have x y and temp
            // when passsing data by a value type you take a copy of 
            // the data not the location of the actual data only a
            // dublication of data

            // so it  won't change in the main func only in
            // the other func for example if we have a SWAP func
            // here the value stays the same in in main class but 
            // if we print the value inside the swap func it will be swapped 

            // first we create a stack frame it will have temp only
            // passing by reference create aliasing name 
            // will make a named as x and b named as y 
            // then will swap the pointer to the location in both 
            // so x and y value will change and after changing 
            // they will be delete and a b will be returned but
            // will be pointing to the swapped locations

            //int A = 9 ; int B = 10;
            //Console.WriteLine($"the value of A Before {A}," +
            //    $"the value of B Before {B}");
            //Swap(A,B);
            //Console.WriteLine($"the value of A After {A}," +
            //      $"the value of B After {B}");
            //Console.WriteLine("_____________________");
            //// it will print 9 and 10 in both cases 
            //int a = 9; int b = 10;
            //Console.WriteLine($"the value of A Before {a}," +
            //    $"the value of B Before {b}");
            //Swap(ref a, ref b);
            //Console.WriteLine($"the value of A After {a}," +
            //      $"the value of B After {b}");
            //// here it will print b after was 9 and a was 10

            #endregion

            #region Q2

            ////int[] Numbers = { 1, 2, 3 };
            ////Console.WriteLine(SumArray(Numbers));
            ////Console.WriteLine(Numbers[0]);
            //// here we are passing by value a reference type
            //// here first we create a stack frame for the called func
            //// SumArray then the Arr in the func will point towards
            //// the same location that the Numbers arry is pointing towards
            //// after that the Arr[0] value will change to 100
            //// but we know that Numbers is pointing towards same location
            //// so Numbers[0] will change aswell to be a 100
            //// so the summ will be 100 + 2 + 3 = 105


            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);

            //// here we do the same stack frame call for the func 
            //// it will be empty then as we said b4 in the passign 
            //// a vaule by ref type we create aliasing for the numbers
            //// array and we call it arr and arr will point at the same 
            //// memory location after that we change the value of arr[0]
            //// so it will be a 100 then we remove the aliasing name 
            //// it will be numbers again pointing towards the array
            //// after changing the value {100 ,2 ,3 } so it will give the 
            //// same answer as above 
            #endregion

            #region Q3

            //SumSub(6 ,3,out int sum ,out int sub);
            //Console.WriteLine($"Sum is {sum} and Subtraction is {sub}");
            #endregion

            #region Q4
            //long Number;
            //string input;
            //do
            //{
            //    Console.WriteLine("Please enter a valid long integer:");
            //    input = Console.ReadLine();
            //}
            //while (!long.TryParse(input, out Number));

            //Console.WriteLine(SumOfSting(input));







            #endregion

            #region Q5
            //Console.WriteLine(IsPrime(7));

            #endregion

            #region Q6
            //int[] answer = MinMaxArr(1,2,3,4,5,6);

            //Console.WriteLine($"Max = {answer[0]} , Min = {answer[1]}");
            #endregion

            #region Q7

            //Console.WriteLine(Fact(0));
            #endregion

            #region Q8

            //string main = "hello";
            //string modified = ChangeChar( 'a',main,1); 

            //Console.WriteLine($"Modified: {modified}");
            #endregion

            #region Q9

            //PrintMatrix(6);
            #endregion

            #region Q10

            //Console.WriteLine(SumArr(1,2,3));
            #endregion

            #region Q11
            //int[] arr01 = new int[3] { 9, 10, 3 };

            //int[] arr02 = new int[3] { 4, 5, 6 };

            //int[] arr03 = MergeArr(arr01, arr02);
            //for (int i = 0; i < arr03.Length; i++)
            //{
            //    Console.WriteLine(arr03[i]);
            //}

            #endregion

            #region Q12

            //countArrElement(4, 3, 2, 3, 4, 5, 4, 6, 5, 2, 2);
            //countArrElement("kiro","kiro","Ahmed","Ahmed");
            #endregion

            #region Q13

            //int[] arr01 = new int[7] { 1, 2, 3, 19, 74, 0, 732 };
            //MaxMin(arr01, out int max, out int min);
            //Console.WriteLine($"Max value is: {max}");
            //Console.WriteLine($"Min value is: {min}");
            #endregion

            #region Q14

            //int[] arr01 = new int[7] { 1, 2, 3, 19, 74, 0, 732 };
            //Console.WriteLine(SecMax(arr01));   

            #endregion

            #region Q15
            //// { 7, 0, 0, 0, 0, 5, 6, 7,  5 ,0, 7, 5, 3 };
            ////  {   1  2, 3, 4, 5, 6 ,7 , 8 ,9}
            //// gaps between the first 7 and the last 7 is 9 execluding both 7'th 

            //int[] arr01 = new int[13] { 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            //int max = LongestDistance(arr01);
            //Console.WriteLine(max);




            #endregion

            #region Q17

            //string input = "this is a test";
            //string[] reversedWords = Reverse(input);

            //for (int i = 0; i < reversedWords.Length; i++) {

            //    Console.Write(reversedWords[i] +" ");
            //}


            #endregion

            #region Q18

            //int rows = 2; 
            //int cols = 3;

            //CopyAndPrint(rows, cols);
            #endregion

            #region Q19

            //PrintArrayReversed(1, 2, 3, 4, 5);
            #endregion

        }
        #region Functions Q1 - Q4
        //public static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}
        //public static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}

        //public static void SumSub(int Var1, int Var2, out int Sum, out int Sub)
        //{
        //    Sum = Var1 + Var2;
        //    Sub = Var1 - Var2;
        //}

        //public static long SumOfSting(string Input)
        //{
        //    long sum = 0; 
        //    char[] chars = Input.ToCharArray();
        //    for (int i = 0;i < chars.Length; i++)
        //    {
        //        sum += long.Parse(chars[i].ToString());
        //    }
        //    return sum;

        //}

        //    public static int SumArr(params int[] Arr) {
        //        int sum = 0;
        //        for (int i = 0;Arr.Length > 0; i++)
        //        {
        //            sum += Arr[i];
        //        }
        //        return sum;
        //    }
        //}

        #endregion

        #region Functions Q5 - Q8

        //public static bool IsPrime(int n) {
        //    int counter = 0;
        //    if (n < 1) { 
        //     return false;
        //    }

        //    for (int i = 1; i <= n; i++) {
        //        if (n % i == 0) { 
        //            counter++;
        //        }
        //    }

        //    if (counter == 2) { 
        //    return true;
        //    }

        //    else
        //    {
        //        return false;
        //    }
        //}


        //static int[] MinMaxArr(params int[] arr01)
        //{
        //    int[] result = new int[2];
        //    result[0] = arr01.Max();
        //    result[1] = arr01.Min();

        //    return result;
        //}

        //public static long Fact(long x) {
        //    long FactResult = 1;
        //    for (long i = x; i > 0; i--) {
        //        FactResult *= i;
        //    }
        //    return FactResult;
        //}

        //public static string ChangeChar(char NewChar , string String,  int pos)
        //{

        //    if (pos > String.Length) {
        //        Console.WriteLine("Error");
        //    }

        //    char[] Chars = String.ToCharArray();
        //    Chars[pos] = NewChar;

        //    string ans= "";
        //    for (int i = 0; i < Chars.Length; i++) {
        //        ans += Chars[i];

        //    }   
        //    return ans;
        //}
        #endregion

        #region Functions Q9 - Q10

        //public static void PrintMatrix(int n)
        //{

        //    for (int i = 0; i < n; i++)
        //    {

        //        for (int j = 0; j < n; j++)
        //        {
        //            if (i == j)
        //            {
        //                Console.Write("1");
        //            }
        //            else
        //            {
        //                Console.Write("0");
        //            }          
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static int SumArr(params int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}



        #endregion

        #region Function Q11

        //public static int[] MergeArr(int[] arr1, int[] arr2)
        //{
        //    //there is a function called concat in arrays

        //    int[] Mainarr = arr1.Concat(arr2).ToArray();
        //    return Mainarr;
        //}

        //OR
        //public static int[] MergeArr(int[] arr1, int[] arr2) 
        //{

        //    int[] Mainarr = new int[arr1.Length + arr2.Length];
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        Mainarr[i] += arr1[i];
        //        Mainarr[i + arr1.Length] += arr2[i];
        //    }

        //    for (int i = 0;i < Mainarr.Length; i++) //bubble sort
        //    {
        //        for (int j = 0; j < Mainarr.Length; j++)
        //        {
        //            if (Mainarr[i] < Mainarr[j])
        //            {
        //                int temp = Mainarr[i];
        //                Mainarr[i] = Mainarr[j];
        //                Mainarr[j] = temp;
        //            }
        //        }
        //    }

        //    return Mainarr;
        //}
        #endregion

        #region Function Q12

        //public static void countArrElement(params int[] arr)
        //{
        //    Array.Sort(arr);

        //    string Answer = "";
        //    int counter = 1;

        //    for (int i = 0; i < arr.Length - 1; i++) 
        //    {
        //        if (arr[i] == arr[i+1])
        //        {
        //            counter ++;
        //        }

        //        else {
        //            Answer += $"element {arr[i]}, is repeated {counter} times \n";
        //            counter = 1;
        //        }

        //    }
        //    Answer += $"element {arr[arr.Length - 1]} is repeated {counter} times ";

        //    Console.WriteLine(Answer);

        //}

        //public static void countArrElement(params string[] arr)
        //{
        //    Array.Sort(arr);

        //    string Answer = "";
        //    int counter = 1;

        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        if (arr[i] == arr[i + 1])
        //        {
        //            counter++;
        //        }

        //        else
        //        {
        //            Answer += $"element {arr[i]}, is repeated {counter} times \n";
        //            counter = 1;
        //        }

        //    }
        //    Answer += $"element {arr[arr.Length - 1]} is repeated {counter} times ";

        //    Console.WriteLine(Answer);

        //}
        #endregion

        #region Function Q13

        //public static void MaxMin(int[] Arr, out int Max, out int Min)
        //{
        //    Min = Arr[0];
        //    Max = Arr[0];
        //    for (int i = 1; i < Arr.Length; i++)
        //    {
        //        if (Arr[i] > Max)
        //        {
        //            Max = Arr[i];
        //        }
        //        else if (Arr[i] < Min)
        //        {
        //            Min = Arr[i];
        //        }

        //    }
        //}
        #endregion

        #region Function Q14
        // i used the func from qustion 13 MinMax
        //public static int SecMax(int[] Arr)
        //{
        //    int maxx;
        //    MaxMin(Arr, out maxx, out _);

        //    int max = Arr[0];
        //    for (int i = 1; i < Arr.Length; i++)
        //    {
        //        if (Arr[i] > max && Arr[i] != maxx)
        //        {
        //            max = Arr[i];
        //        }
        //    }
        //    return max;
        //}
        #endregion

        #region Function Q15
        //{ 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
        // {5, 2, 9, 5, 6, 5};
        //public static int LongestDistance(int[]array)
        //{

        //    int[] answer = new int[array.Length];

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        answer[i] = -1;
        //    }

        //    for (int i = 0; i < array.Length; i++)
        //    { 
        //        for(int j = array.Length - 1; j > i ; j--)
        //        {
        //            if (array[j] == array[i])
        //            {
        //                answer[i] += j - i;
        //                break;
        //            }
        //        }
        //    }
        //    return answer.Max();
        //}
        #endregion

        #region Function Q17

        //public static string[] Reverse(string s) {

        //    string[] result = s.Split(" ");
        //    string[] reversed = new string[result.Length];

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        reversed[i] = result[result.Length - 1 - i];
        //    }

        //    return reversed;
        //}
        #endregion

        #region Function Q18

        //public static void CopyAndPrint(int rows, int cols)
        //{
        //    int[,] array1 = new int[rows, cols];
        //    int[,] array2 = new int[rows, cols];

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write($"Enter value for array1[{i},{j}]: ");
        //            array1[i, j] = int.Parse(Console.ReadLine());
        //        }
        //    }

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            array2[i, j] = array1[i, j];
        //        }
        //    }

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write(array2[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        #endregion

        #region Function Q19

        //public static void PrintArrayReversed(params int[] arr)
        //{
        //    for (int i = arr.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }

        //}
        #endregion

    }
}

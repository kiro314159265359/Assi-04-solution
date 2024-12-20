namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1D Array

            //// We get the first index or arr[0] we only have this location
            //// to get the arr[1] we do a simple equation of
            //// eq = index * bytes + address of arr[0]

            //int[] Numbers;
            //// declaration of "Array of int"
            //// 8 bytes will be allocated for numbers
            //// 0 bytes in the heap

            //Numbers = new int[5];

            //// 1. allocate the object at heap
            //// 2. initialize the default values
            //// 3. call the constructor if there was any 
            //// 4. assign the object tot the referance

            //Console.WriteLine(Numbers[0]);

            //Numbers[0] = 12;
            //Numbers[1] = 1;
            //Numbers[2] = 9;
            //Numbers[3] = 5;
            //Numbers[4] = 7;


            //int[] Numbers01 = new int[5] {1,2,3,4,5};
            //int[] Numbers02 = new int[] { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < Numbers.Length; i++) { 
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"{Numbers[i]}");
            //}

            //Console.Write(Numbers01.Rank);
            //Console.WriteLine(Numbers02.Length);

            #endregion

            #region 2D Arrays

            //// Reactangle Array Width = height
            //// Juddge array Width != height

            //int[,] Marks = new int[3,3];
            //Marks[0,1] = 9;


            ////for (int i = 0; i < Numbers.Length; i++) {
            ////    for (int j = 0; j < Numbers.Length; j++) { 
            ////        Marks[i,j] = i;
            ////    }
            ////}



            //int cols = Marks.GetLength(1);

            //for (int i = 0; i < Marks.Length; i++) {
            //    int row = i / cols;
            //    int col = i % cols;

            //    Console.Write($"{Marks[row, col]} ");

            //    if (col == cols - 1)
            //    {
            //        Console.WriteLine();
            //    }

            //}

            #endregion

            #region JudgeArray

            //int[][] Marks = new int[3][];

            //Marks[0] = new int[] {1,2,3};
            //Marks[1] = new int[] { 1, 2, 3, 4};
            //Marks[2] = new int[] { 1, 2 };

            //for (int i = 0; i < Marks.Length; i++) {
            //    for (int j = 0; j < Marks[i].Length; j++) { 
            //        Console.Write( Marks[i][j] );
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region FunctionsCalling

            // printShape();
            // printShape(10);
            // printShape();

            #endregion

            #region PassingParametars
            //int A = 1, B = 7;

            //SWAP(ref A ,ref B);

            //Console.WriteLine("-------------");
            //Console.WriteLine("Value of A is "+A + ", Value of B is " + B);

            //int[] arr = new int[3] { 1, 2, 3 };
            //Console.WriteLine(SumArr(arr));
            //Console.WriteLine(arr[0]);

            //int[] arr = new int[3] { 1, 2, 3 };
            //Console.WriteLine(SumArr(arr));
            //Console.WriteLine(arr[0]);


            //int[] arr = new int[3] { 1, 2, 3 };
            //Console.WriteLine(SumArr(ref arr));
            //Console.WriteLine(arr[0]);


            #endregion

            #region PassingByOut

            //Console.WriteLine(SumMul(2, 3)[0]+" "+ SumMul(2, 3)[1]);
            //int sum , mul;
            //SumMul(2, 3, out int sum, out int mul);

            //SumMul(2, 3, out int sum, out _);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul); 


            #endregion

            #region Params

            //params
            //Console.WriteLine(SumArr(1, 2, 3, 4));
            #endregion
        }

        #region Functions
        // 1. Class member method (Static)
        // 2. Object member method (non static)


        //static int[] SumMul(int x , int y)
        //{
        //    int[] result = {x, y};
        //    return result;
        //}

        //static void SumMul(int x, int y , out int Sum , out int Mul)
        //{
        //    Sum = x + y;
        //    Mul = y * x;
        //}



        //static void printShape(int count = 4)
        //{
        //    for (int i = 0; i < count; i++) {
        //        Console.WriteLine("\"_\"");
        //        }
        //}

        //static void SWAP(int x , int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"{x}, {y}");
        //}
        //static void SWAP(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"{x}, {y}");
        //}

        //static int SumArr(int[] arr)
        //{
        //    arr[0] = 100;
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        //static int SumArr(params int[] arr)
        //{
        //    arr = new int[3] {10,20,30};

        //    int sum = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        #endregion

    }
}

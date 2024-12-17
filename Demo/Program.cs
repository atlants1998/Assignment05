namespace Demo
{
    internal class Program
    {
        #region Swap
        // Class Member Function (Static)
        public static void Swap( int X,  int Y) {
            Console.WriteLine($" Func Start \n ***********");
            int Swap = X;
            X = Y;
            Y = Swap;
            Console.WriteLine(X);
            Console.WriteLine(Y);
            Console.WriteLine($"Func END \n ***********");
        }

        public static void SwapByRef(ref int X, ref int Y)
        {

            Console.WriteLine($" Func Start \n ***********");
            Console.WriteLine($"{X} - {X.GetHashCode()}");
            Console.WriteLine($"{Y} - {Y.GetHashCode()}");
            int Swap = X;
            X = Y;
            Y = Swap;
            Console.WriteLine($"{X} - {X.GetHashCode()}");
            Console.WriteLine($"{Y} - {Y.GetHashCode()}");
            Console.WriteLine($"Func END \n ***********");
        }

        public static void SumMul(int X , int Y , out int Sum , out int Mul) {
            Sum = X+Y;
            Mul = X*Y;
        }

        public static int SumArray(params int[] Arr)
        //params- tatata- pramms mama
        {
            int Sum = 0;
            if (Arr is not null) {
                for (int i = 0; i < Arr.Length; i++) {
                    Sum += Arr[i];// Sum = Sum + Arr[i]
                }
            }
            return Sum;

        }

        // Opject Member Function (OOP)
        #endregion


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Demo 05!");

            #region Judged Array
            //// One D Array Of Arrats With Diffrent Sizes

            //int[][] Numbers = new int[3][];
            //Numbers[0] =  new int[] { 1,2,3 };
            //Numbers[1] = new int[] { 4,5 };
            //Numbers[2] = new int[] {6};

            //for (int i = 0; i < Numbers.Length; i++) {
            //    for (int j = 0; j < Numbers[i].Length; j++) {
            //        Console.WriteLine(Numbers[i][j]);
            //    }
            //}
            #endregion



            #region Functions - By Value
            //int A = 3;
            //int B = 5;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine($" \n ***********");

            //Swap( A,  B);

            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine($" \n ***********");

            #endregion

            #region Functions - By Reference

            //int A = 3;
            //int B = 5;
            //Console.WriteLine($"{A} - {A.GetHashCode()}");
            //Console.WriteLine($"{B} - {B.GetHashCode()}");
            //Console.WriteLine($" \n ***********");

            //SwapByRef(ref A, ref B);

            //Console.WriteLine($"{A} - {A.GetHashCode()}");
            //Console.WriteLine($"{B} - {B.GetHashCode()}");
            //Console.WriteLine($" \n ***********");
            #endregion

            #region Functions - By Out

            //int A = 3;
            //int B = 5;
            //int[] Result = {0,0};
            //SumMul(A ,B, out Result[0], out Result[1]);

            //Console.WriteLine($"Sum: {Result[0]}");
            //Console.WriteLine($"Mul: {Result[1]}");

            #endregion

            #region Functions - Params
            //int[] Nums = {1,2,3};
            //int Total= SumArray(1,2,3);
            //Console.WriteLine($"Sum: {Total}");
            #endregion

            #region Boxing - UnBoxing
            //Boxing : casting from ValueType to ReferenceType
            object obj; //Declare For Reference of type "Object", Refrencing to NULL
            //this refrence [obj] can refer to an instance from type object or any other datatype
            obj= new object();
            obj = new string ("Nana") ;
            obj = "B"; // Casting from object type to [Char] value type // impliceit // Boxing
            obj = 3; // Casting from Char type to [int] value type // impliceit // Boxing

            //UnBoxing : casting from ReferenceType to ValueType //Unsafe - MayBe throw Exiption
            object O2 = 10;
            O2 = "Ahmed";
            int Y = (int)O2;
            Console.WriteLine(Y);


            #endregion
        }
    }
}

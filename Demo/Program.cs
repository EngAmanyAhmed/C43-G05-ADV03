namespace Demo
{
    // class 
    // interface 
    // enum 
    // struct 
    // delegate

    // Step 01: Create New Datatype (Delegate)
    public delegate int StringFuncDelegate(String s);
    //NEW Delegate (Class): Reference (Pointer) Can Refer To Function or More (Pointer Of Function)
    // These Function Must Be Have The Same Signature Of The Delegate: int(string) 
    // Regardless Function Name, Parameters Names Or, Access Modifiers

    internal class Program
    {
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine(); 
            foreach (T item in values) 
            { 
            Console.Write(value: $"{item} "); 
            }
                Console.WriteLine();
        }


        static void Main()
        {

            #region Delegate Overview

            // Delegate: C# Feature 

            // C# Pure OOP 

            // Functional Programming 
            // Event-Driven Programming 

            // Java: Pure OOP 
            // DP:

            #endregion

            #region Delegate Ex01

            // Step 02; Use Delegate
            //StringFuncDelegate X;
            //X = StringFunctions.GetCountOfUpperCaseChars;
            ////X.

            //StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChars) 

            StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars; // Syntax Sugar 
            
            X += StringFunctions.GetCountOfLowerCaseChars;
            
            //int Count X. Invoke("Hello World"); 
            int Count = X(s: "Hello World"); // Syntax Sugar 
            Console.WriteLine(Count);

            #endregion

            #region Delegate Ex02 Without Generic

            //int[] Numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4 };

            //PrintArray(Numbers);

            ////SortingAlgorithms.BubbleSortAscending (Numbers); // Sorting Ascending 
            //////SortingAlgorithms.Bubble SortDescending (Numbers); // Sorting Descending 

            ////SortingFuncDelegate X = SortingConditions.CompareLess;

            ////SortingAlgorithms.BubbleSort(Numbers, X); // Sorting Ascending 

            //SortingAlgorithms.BubbleSort(Numbers, SortingConditions.CompareGtr); // Sorting Descending 

            //PrintArray(Numbers);


            #endregion

            #region Delegate Ex02 With Generic

            //string[] Names = { "Ahmed", "Ali", "Maraim", "Mahmoud", "Amr", "Mona", "Khaled" };

            //PrintArray (Names);

            //SortingAlgorithms.BubbleSort(Names, SortingConditions.CompareGtr);

            //PrintArray(Names);



            #endregion

            #region Delegate Ex03




            #endregion

            #region Delegate Ex03 With Generics




            #endregion

            #region Built-in Delegate




            #endregion

            #region  Anonymous Method & Lambda Expression




            #endregion

            #region  Var




            #endregion

            #region Function Returns Function - FP Feature




            #endregion

        }
    }
}

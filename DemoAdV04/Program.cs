
using DemoAdV04.Books;

namespace DemoAdV04
{
    //step 
    //1.0 Declare Delegate
    public delegate int StringsFuncDelegate(string str);
    //New Delegate(class),References from Delegate refer to Function or  more [ pointer to Function]
    //these Must be has the same Signture of Delegate :int (string)
    //Regardless Function Naming [ Function Names or Parameters Name ], Access Modifier
    //public delegate bool ConditionsFuncDelegate(int A);
    //public delegate bool ConditionsFuncDelegateV02(string A);
    public delegate bool ConditionsFuncDelegate<T>(T A);
    public delegate bool ConditionsFuncDelegateV02<T>(T A);

    internal class Program
    {
        static Action Func01()
        {
            //Action action = delegate () { Console.WriteLine("Hello world !"); };
            //Action action =  ()=> { Console.WriteLine("Hello world !"); };
            //Action action = () => Console.WriteLine("Hello world !");


            //return action;
            return () => Console.WriteLine("Hello world !");
        }
        
        //static List<int> FindNumbers(List<int> list,ConditionsFuncDelegate refernce)
        //{
        //    List<int> result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (refernce.Invoke( list[i]))
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }



        //    return result;
        //}

        //static List<int>FindOddNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] %2!= 0)
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }



        //    return result;
        //}
        //static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 == 0)
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }



        //    return result;
        //}
        //static List<int> FindDivisionfourNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 4 == 0)
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }



        //    return result;
        //}
        //static List<string> FindElement(List<string> list,ConditionsFuncDelegateV02 reference)
        //{
        //    List<string> result = new List<string>();

        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke( list[i]))
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }



        //    return result;
        //}
        static List<T> FindElement<T>(List<T> list, ConditionsFuncDelegateV02<T> reference)
        {
            List<T> result = new List<T>();

            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                    {
                        result.Add(list[i]);
                    }

                }
            }



            return result;
        }




        static void Main(string[] args)
        {
            #region Ex01
            //StringsFuncDelegate refernce = new StringsFuncDelegate(StringsFunction.GetCountofourcasechar);
            //StringsFuncDelegate refernces = StringsFunction.GetCountofourcasechar;//syntax sugar
            ////StringsFuncDelegate X = StringsFunction.GetCountofourcasechar;
            ////int Result = X.Invoke("Hello Wordld !");
            //refernces += StringsFunction.GetCountofourcasecharLowerCase;
            //int Result = refernces.Invoke("HellO");

            //Console.WriteLine(Result);
            #endregion
            #region Ex02
            //int[] Numbers = { 9, 8, 2, 3, 6, 7, 5, 4, 12, 13, 15, 20, 17 };
            ////BubbleSort
            //SortingAlgorithm.BubbleSortAssending(Numbers);
            //foreach (int num in Numbers)
            //    Console.WriteLine($" {num} ");
            //Console.WriteLine("*********");
            //SortingAlgorithm.BubbleSortAssendingDecending(Numbers);
            //foreach (int item in Numbers)
            //Console.WriteLine(item);



            #endregion
            #region Ex03
            //string[] Names = { "Mohamed", "Ahmed", "Ali", "Omar" ,"Aya"};
            //SortingAlgorithm.BubbleSortAssending(Names, StringsFunction.SortAscending);
            //foreach (string item in Names)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Ex04
            // List<int> list = Enumerable.Range(1,100).ToList();
            //List<int> OddNum =  FindOddNumbers(list);
            // List<int>EvenNum = FindEvenNumbers(list);
            // List<int> Divisible = FindDivisionfourNumbers(list);
            // foreach (int i in OddNum)
            //     Console.Write(i +" ");
            // foreach (int item in EvenNum)
            // {
            //     Console.Write(item + " ");
            // }
            // foreach (int call in Divisible)
            //     Console.WriteLine(call);
            //List<int> list = Enumerable.Range(1, 100).ToList();
            //List<int> OddNum = FindNumbers(list,ConditionalFunction.CheckOdd);
            //List<int> EvenNum = FindNumbers(list,ConditionalFunction.CheckEven);
            //List<int> Divisible = FindNumbers(list, ConditionalFunction.CheckDivisibleBy04);
            //foreach (int i in OddNum)
            //    Console.Write(i + " ");
            //foreach (int item in EvenNum)
            //{
            //    Console.Write(item + " ");
            //}
            //foreach (int call in Divisible)
            //    Console.WriteLine(call);

            //List<string> Names = new List<string>() { "Mohamed", "Ahmed", "Ali", "omar", "Aya" };
            //List<string> Result = FindElement(Names, ConditionalFunction.CheckLength);
            //foreach (string item in Result)
            //    Console.WriteLine(item);
            //Console.WriteLine("===================");
            //List<string> Items = FindElement(Names, ConditionalFunction.CheckLengthLess);

            //foreach (string Call in Items)
            //    Console.WriteLine(Call);

            #endregion

            #region Builtin Delegate
            //Predicate - Func - Action 
            //Predicate<int> predicate = ConditionalFunction.CheckEven;
            //Func<int, bool> func = ConditionalFunction.CheckOdd;
            //Func<string, string, bool> func1 = StringsFunction.SortAscending;

            //Action
            //Action action = ConditionalFunction.Welcome;
            //action.Invoke();

            //Action<string> action = ConditionalFunction.Error;
            //action.Invoke("Hello");

            #endregion
            #region Lamba Expression
            //C# 2.0 2005 

            //Predicate<int> predicate = delegate (int X) { return X % 2 != 0; }; // Anonymous Method
            //predicate(55);

            //C#3.0
            //Lamba Expression
            //FatArrow => read as (goes to)

            //Predicate<int> predicate =  (int X)=> { return X % 2 != 0; }; // Lamba Expression 
            //Predicate<int> predicate =  (X)=> { return X % 2 != 0; }; // Lamba Expression 
            //Predicate<int> predicate = X =>   X % 2 != 0; ; // Lamba Expression 
            //FindElement(, X => X % 2 != 0); 
            #endregion

            #region MyRegion
            //C# 3.0 -- var implicitlty  type local varible

            //Predicate<int> predicate = ConditionalFunction.CheckEven;
            //var predicate = ConditionalFunction.CheckEven;

            //var x = Func01();
            //Action X = Func01();
            //X.Invoke();

            //Func01()(); // rerurn func back from call func01()

            #endregion

            #region Assignment
            //Book book = new Book("100", "Alex", new string[] { "Mly", "Ayoy" }, new DateTime(2024, 7, 9), 500);
            //Console.WriteLine(book);
            //Predicate<Book> predicate = X => X.IsBn ==X.IsBn ; ;
            //Predicate<Book> predicate = C => C.PublicationDate == DateTime.Now;


            #endregion


            //DateTime dateTime = new DateTime(1999,2,8);
            //Console.WriteLine(dateTime);







        }
    }
    class StringsFunction
    {
        // class member method =>
        public static int GetCountofourcasechar(string word) 
        {
            int Count = 0;
            if (word is not null && word.Length>0) 
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                        Count++;
                }
            }
            return Count;
        }
        public static int GetCountofourcasecharLowerCase(string word)
        {
            int Count = 0;
            if (word is not null && word.Length > 0)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                        Count++;
                }
            }
            return Count;
        }
        public static void Print(string s)
        {
            Console.WriteLine(s);
        }
        public static bool SortAscending(string L , string R) { return L.Length> R.Length; }
        public static bool SortDecending(string L , string R) { return L.Length< R.Length; }
        public static bool SortAscending(int L , int R) { return L>  R; }
        public static bool SortDecending(int L , int R) { return L>  R; }

    }
    class ConditionalFunction
    {
        public static bool CheckOdd(int X) { return X % 2 != 0; }
        public static bool CheckEven(int X) { return X % 2 == 0; }
        public static bool CheckDivisibleBy04(int X) { return X % 4 == 0; }
        public static bool IsPrime(int X) { return X % 7 == 0; }
        public static bool CheckLength(string S) { return S.Length > 3; }
        public static bool CheckLengthLess(string S) { return S.Length < 4; }
        public static void Welcome() { Console.WriteLine("Hello World!"); }
        public static void Error(string s) { Console.WriteLine(s); }

    }
}

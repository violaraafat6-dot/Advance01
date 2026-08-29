using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advance01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1

            //            Q1
            //A generic class is a class that works with different data types using a type parameter such as T
            //Generics are used to:
            // -Reuse the same class with different data types
            //-Provide type safety
            // - Avoid boxing/unboxing for value type
            //-Reduce code duplication



            #endregion

            #region question4

            //            A generic method is a method that has its own type parameter and can work with different data types

            //static void Swap<T>(ref T first, ref T second)
            //            {
            //                T temp = first;
            //                first = second;
            //                second = temp;
            //            }


            #endregion

            #region question5

            //static T FindMax<T>(T first, T second) where T : IComparable<T>
            //{
            //    if (first.CompareTo(second) > 0)
            //        return first;

            //    return second;
            //}
            #endregion
        }
    }
}

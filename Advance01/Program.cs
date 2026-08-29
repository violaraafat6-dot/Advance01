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

            #region question9

            //سوري كل ده بجاوب ف interface ورفعتهم وانا مش واخده بالي ملحقتش امسحهم

            //    The new () constraint means that the type must have a public parameterless constructor

            //class Factory<T> where T : new()
            //    {
            //        public T Create()
            //        {
            //            return new T();
            //        }
            //}
            //ex
            //Factory<MyClass> factory = new Factory<MyClass>();

            //        MyClass obj = factory.Create();


            #endregion

            #region question11

//            A base class constraint means that the generic type must inherit from a specific base class

//class Animal
//        {
//            public void Eat()
//            {
//                Console.WriteLine("Eating");
//            }
//        }

//        class AnimalContainer<T> where T : Animal
//        {
//            public void MakeAnimalEat(T animal)
//            {
//                animal.Eat();
//            }
//        }
            #endregion
    }
    }
}

using System.Buffers;
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

            #region question12

            //            Multiple constraints can be applied to the same generic type using where

            //class Example<T> where T : class, IPrintable, new()
            //        {
            //            public T Create()
            //            {
            //                return new T();
            //            }
            //        }

            //        Here T must:
            //-Be a reference type
            //-Implement IPrintable
            // -Have a public parameterless constructor
            #endregion

            #region question13

            //            The default keyword returns the default value of the generic type

            //            ex
            //T value = default(T);
            //            //
            //            The default value depends on the type:

            //            For int, the default value is 0
            //For bool, the default value is false
            //For reference types such as string, the default value is null
            #endregion

            #region question14

            //    class SafeList<T>
            //{
            //    private List<T> items = new List<T>();

            //    public void Add(T item)
            //    {
            //        items.Add(item);
            //    }

            //    public T Get(int index)
            //    {
            //        if (index >= 0 && index < items.Count)
            //        {
            //            return items[index];
            //        }

            //        return default(T);
            //    }
            //}
            #endregion

            #region question15

            //            Covariance allows a more specific type to be used where a more general type is expected

            //The out keyword is used for covariance in generic interfaces and delegates

            //interface IProducer<out T>
            //        {
            //            T Get();
            //        }

            #endregion

            #region question16

//            Contravariance allows a more general type to be used where a more specific type is expected

//The in keyword is used for contravariance

//interface IConsumer<in T>
//        {
//            void Consume(T item);
//        }

//        Here T is used as an input type.

//        For example, a consumer of object can be used where a consumer of string is expected because string is an object

            #endregion
    }
    }
}

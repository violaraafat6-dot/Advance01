using System.Buffers;
using System.Reflection.Metadata;
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
            #region question17

            //            Covariance
            //Uses out/ Works with output values / Allows more specific type / Example: IProducer <out T >
            //Contravariance
            //Uses in/ Works with input/ Allows more general type / Example: IConsumer <in T >

            //So, covariance is related to producing / returning values, while contravariance is related to consuming / accepting values
            #endregion

            #region question18

            //            Static members in a generic type are 
            //separate for each closed generic type
            //ex

            //class Counter<T>
            //        {
            //            public static int Count;

            //            public Counter()
            //            {
            //                Count++;
            //            }
            //        }
            #endregion

            #region question19

            //            A class can inherit from a generic class by specifying the type parameter
            //ex
            //class Repository<T>
            //        {
            //            public void Add(T item)
            //            {
            //                Console.WriteLine("Item Added");
            //            }
            //        }

            //        class UserRepository : Repository<string>
            //        {
            //        }
            //        Now UserRepository inherits from Repository<string>

            //        It can use the methods of the generic base class with string as the type
            #endregion

            #region question20

            //    class Cache<TKey, TValue>
            //{
            //    private class CacheItem
            //    {
            //        public TValue Value { get; set; }
            //        public DateTime ExpirationTime { get; set; }
            //    }

            //    private Dictionary<TKey, CacheItem> items =
            //        new Dictionary<TKey, CacheItem>();

            //    public void Add(TKey key, TValue value, TimeSpan expiration)
            //    {
            //        CacheItem item = new CacheItem();

            //        item.Value = value;
            //        item.ExpirationTime = DateTime.Now.Add(expiration);

            //        items[key] = item;
            //    }

            //    public TValue Get(TKey key)
            //    {
            //        if (!items.ContainsKey(key))
            //            return default(TValue);

            //        CacheItem item = items[key];

            //        if (DateTime.Now > item.ExpirationTime)
            //        {
            //            items.Remove(key);
            //            return default(TValue);
            //        }

            //        return item.Value;
            //    }

            //    public void Remove(TKey key)
            //    {
            //        if (items.ContainsKey(key))
            //        {
            //            items.Remove(key);
            //        }
            //    }

            //    public bool Contains(TKey key)
            //    {
            //        if (!items.ContainsKey(key))
            //            return false;

            //        CacheItem item = items[key];

            //        if (DateTime.Now > item.ExpirationTime)
            //        {
            //            items.Remove(key);
            //            return false;
            //        }

            //        return true;
            //    }
            //}

            #endregion

            #region search in&out


//            in and out in Generics – C#

//In C#, the in and out keywords are used with Generic Interfaces and Delegates. They are related to Generic Variance.

//There are two types:

//            1. out – Covariance

//            The out keyword is used when the generic type T is used as an output.

//It means that T can be returned from a method, but it cannot be used as an input parameter.

//Example:

//interface IProducer<out T>
//        {
//            T Get();
//        }

//        Here, T is used as a return type, so we can use out.

//Example:

//IProducer<string> stringProducer = ...;
//        IProducer<object> objectProducer = stringProducer;

//        This is allowed because string is derived from object.

//        So, a Producer of string can be treated as a Producer of object.

//In short:

//out = T comes out of the generic.

//Producer<string>->Producer<object>


//2. in – Contravariance

//The in keyword is used when the generic type T is used as an input.

//It means that T can be used as a method parameter, but it cannot be used as a return type.

//Example:

//interface IConsumer<in T>
//        {
//            void Consume(T value);
//        }

//        Here, T is used as a parameter, so we use in.

//Example:

//IConsumer<object> objectConsumer = ...;
//        IConsumer<string> stringConsumer = objectConsumer;

//        This is allowed because an object can accept a string.

//        So, a Consumer of object can be treated as a Consumer of string.

//In short:

//in = T goes into the generic.

//Consumer<object>->Consumer<string>


//The difference:

//out = Covariance = Output = Producer

//in = Contravariance = Input = Consumer


//Why do we use in and out?

//They allow compatible conversions between generic types while maintaining type safety.

//Important:

//The in and out keywords here are not the same as the in and out keywords used with method parameters.

//Here, they are used with generic type parameters in interfaces and delegates.


            #endregion
        }
    }
}

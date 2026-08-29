using Advance01;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advance01
{
    #region question6


    //    A generic interface is an interface that uses a type parameter so it can work with different data types

    //interface IRepository<T>
    //    {
    //        void Add(T item);
    //        T Get(int id);
    //    }

    #endregion

    #region question7

    //    The struct constraint means that the generic type must be a value type

    //class Example<T> where T : struct
    //    {
    //        public T Value { get; set; }
    //    }
    ///
    //Example<int> example = new Example<int>();


    #endregion


    #region question8


//    The class constraint means that the generic type must be a reference type

//class Example<T> where T : class
//    {
//        public T Value { get; set; }
//}
//Another ex

//public class Repository<T> where T. class
//    {
//        public T Item(get; set; }
//public Repository(T item)
//        {
//            Item = item;
//        }
//    }
//class Person
//{
//    public string Name(get; set; )
//}
//class Program
//{
//    static void Main()
//var r1 = new Repository<string>("Hello": );
//    Var r2 = new
//    Repository<Person>(new Person { Name = "Al1" });
//}
//}



    #endregion
}

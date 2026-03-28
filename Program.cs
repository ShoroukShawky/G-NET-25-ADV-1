using System.Diagnostics.Metrics;

namespace G_NET_25_ADV_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // A generic class uses type parameters that are replaced with actual types when you create an instance
            // reusability, type safety, no casting
            #endregion
            #region Q2
            //      class Container<T>
            //{
            //    public T item;
            //    public void Add(T value) => item = value;
            //    public T Get() => item;
            //}
            #endregion
            #region Q3
            // a generic class can use more than one type placeholder

            //class pair<TKey, TValue>
            // {
            //    public TKey key;
            //    public TValue value;
            // }
            #endregion
            #region Q4
            // A generic method declares its own type parameter(s), It can exist in both generic and non-generic classes
            // The compiler often infers the type argument

            //void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}
            #endregion
            #region Q5
            //T FindMax<T>(T a, T b) where T : IComparable<T>
            //{
            //    if (a.CompareTo(b) < 0) return b;
            //    else return a;

            //}

            #endregion
            #region Q6
            // generic interfaces define contracts with type parameters, classes implementing them specify the actual types


            //    interface iRepository<T>
            //{
            //    T Get(int id);
            //    void Add(T item);
            //}

            #endregion
            #region Q7
            // T must be a value type

            //    class MyClass<T> where T : struct
            //{
            //     public T x;
            //}

            //MyClass<int> x = new MyClass<int>; // allowed
            //MyClass<string> y = new MyClass<string>; // error
            #endregion
            #region Q8
            // T must be a reference type

            //  class MyClass<T> where T : class 
            //{
            //    public T Value;
            //}
            #endregion
            #region Q9
            // T must have parameterless constructor

            //  class MyClass<T> where T : new() 
            //{
            //    public T Create
            //    {
            //           return new T();
            //    }
            //}
            #endregion
            #region Q10
            // T must implement interface

            //  class MyClass<T> where T : IComparable<T> 
            //{
            //    public T Value;
            //}
            #endregion
            #region Q11
            // T must inherit from BaseClass

            //   class Animal
            //{
            //    public string Name { get; set; }
            //    public string Speak()
            //    {
            //        return "";
            //    }

            //}

            //class AnimalShelter<T> where T : Animal
            //{ 
            //    public string Name { get; set; }
            //}


            #endregion
            #region Q12
            //public class MyClass<T> where T : class, IComparable<T>, new()
            //{
            //    public T Create()
            //    {
            //   return new T();
            //    }
            //}
            #endregion
            #region Q13
            // default returns the default value for type T
            // null for reference types
            // 0 or false for value types
            #endregion
            #region Q14
            //    class SafeList<T>
            //{
            //    List<T> items = new();

            //    public void Add(T item) { items.Add(item); }

            //    public T GetAt(int index)
            //    {
            //        if (index >= 0 && index < items.Count)
            //        {
            //            return items[index];
            //        }
            //        return default(T);
            //    }
            //}
            #endregion
            #region Q15
            // Covariance allows you to use a more derived type than originally specified. Marked with out keyword
            // The out keyword is used to indicate that the type parameter is only used for return values and not as input
            #endregion
            #region Q16
            // Contravariance allows you to use a less derived type than originally specified. Marked with in keyword
            // in keyword is used to indicate that the type parameter is only used as a method parameter and not returned
            #endregion
            #region Q17
            // covariance (out):
            // works with output(return values)
            // allows using a more specific type

            //contravariance(in):
            //works with input(parameters)
            //allows using a more general type
            #endregion
            #region Q18
            // each closed generic type has its own copy of static fields

            // Ex:
            //var a = new MyClass<int>(); 
            //var b = new MyClass<string>(); 
            //var c = new MyClass<string>(); 

            //Console.WriteLine(MyClass<int>.count); // 1
            //Console.WriteLine(MyClass<string>.count); // 2



            #endregion
            #region Q19
            // we can inherit from a generic class by diffrent ways:
            // 1- inherit and pass type parameter
            // 2- inherit with concrete type
            // 3- add new type parameter
            #endregion
            #region Q20
            //  class Cache<TKey, TValue>
            //{
            //    private Dictionary<TKey, (TValue value, DateTime expire)> map = new Dictionary<TKey, (TValue, DateTime)>();
            //    public void Add(TKey key, TValue value, int sec)
            //    {
            //        map[key] = (value, DateTime.Now.AddSeconds(sec));
            //    }

            //    public void Remove(TKey key)
            //    {
            //        map.Remove(key);
            //    }

            //    public bool contains(TKey key)
            //    {
            //        return map.ContainsKey(key);
            //    }

            //    public TValue Get(TKey key)
            //    {
            //        if (map.ContainsKey(key))
            //        {
            //            var value = map[key];
            //            if (DateTime.Now < value.expire)
            //                return value.value;
            //            map.Remove(key);
            //        }
            //        return default;
            //    }


            #endregion

        }
    }


    class MyClass<T>
    {
        public static int count = 0;
        public MyClass()
        {
            count++;
        }
    }
}
    
    



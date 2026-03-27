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
        }



    }

}

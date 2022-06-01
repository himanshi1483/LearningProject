namespace LearningProject
{
    public class GenericList<T>
    {
        public void Add(T input) { }
    }

    public class GenericClass
    {
        public int Field1 { get; set; }

    }
    public class TestGeneric
    {
        static void Main()
        {
            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);
            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("");
            // Declare a list of type ExampleClass.
            GenericList<GenericClass> list3 = new GenericList<GenericClass>();
            list3.Add(new GenericClass());
        }


    }
}

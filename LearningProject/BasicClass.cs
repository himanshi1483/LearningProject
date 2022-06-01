namespace LearningProject
{
    //Encapsulation is data hiding(information hiding) while Abstraction is detail hiding(implementation hiding).
    //While encapsulation groups together data and methods that act upon the data,
    //data abstraction deal with exposing to the user and hiding the details of implementation.
    //Encapsulation: Hiding the internal state and functionality of an object and only allowing access through a public set of functions.
    //Inheritance: Ability to create new abstractions based on existing abstractions.
    //Polymorphism: Ability to implement inherited properties or methods in different ways across multiple abstractions.
    public class BasicClass : InterfaceExample
    {
        // Internal: Only accessible within the same assembly.
        internal static int x = 1;

        //A protected member is accessible within its class and by derived class instances.
        protected int y = 123;

        //A protected internal member of a base class is accessible from any type within its containing assembly.
        //It is also accessible in a derived class located in another assembly only if the access occurs through a variable of the derived class type. 
        protected internal int myValue = 0;

        //A private protected member is accessible by types derived from the containing class, but only within its containing assembly.
        private protected int testVal = 1;

        //Properties behave like fields when they are accessed.
        //However, unlike fields, properties are implemented with accessors that define the statements executed when a property is accessed or assigned.
        [field: NonSerialized] //Attaching attribute
        public string? FirstName { get; set; }

        //A method is a code block that contains a series of statements.
        //A program causes the statements to be executed by calling the method and specifying any required method arguments.
        public string ConcatName(string name, string surname)
        {
            //String Interpolation
            string fullname = String.Format($"My full name is {name} {surname}");
            return fullname;
        }

        public string ConcatNameAndCity(string name, string surname, string city)
        {
            string fullname = String.Format($"My full name is {name} {surname} from {city}");
            return fullname;
        }

        //The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
        //The implementation of a virtual member can be changed by an overriding member in a derived class.
        //When a virtual method is invoked, the run-time type of the object is checked for an overriding member.
        //The overriding member in the most derived class is called, which might be the original member, if no derived class has overridden the member.
        //By default, methods are non-virtual. You cannot override a non-virtual method.
        //You cannot use the virtual modifier with the static, abstract, private, or override modifiers.
        public virtual double Area()
        {
            return x * y;
        }
        public virtual string? Name { get; set; }
    }

    //The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace.
    //All the parts must use the partial keyword.All the parts must be available at compile time to form the final type.
    //There are several situations when splitting a class definition is desirable:
    //--When working on large projects, spreading a class over separate files enables multiple programmers to work on it at the same time.
    public partial class Employee : BasicClass
    {
        public void DoWork()
        {
        }
    }

    public partial class Employee
    {
        public void GoToLunch()
        {
        }

        private string? _name;

        // Override auto-implemented property with ordinary property
        // to provide specialized accessor behavior.
        public override string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    _name = "Unknown";
                }
            }
        }
    }

    //The abstract modifier indicates that the thing being modified has a missing or incomplete implementation.
    //Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own.
    //Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class.
    // the abstract modifier requires a class to be inherited.
    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Square : Shape
    {
        private int _side;

        public Square(int n) => _side = n;

        // GetArea method is required to avoid a compile-time error.
        public override int GetArea() => _side * _side;

        static void TestMain()
        {
            var sq = new Square(12);
            Console.WriteLine($"Area of the square = {sq.GetArea()}");
        }
    }

    //When applied to a class, the sealed modifier prevents other classes from inheriting from it.
    //When applied to a method or property, the sealed modifier must always be used with override.
    //Because structs are implicitly sealed, they cannot be inherited.
    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    class SealedTest2
    {
        static void Test2Main()
        {
            var sc = new SealedClass();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine($"x = {sc.x}, y = {sc.y}");
        }
    }


}

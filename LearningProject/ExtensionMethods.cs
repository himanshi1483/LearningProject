namespace LearningProject
{
    public static class ExtensionMethods
    {
        // Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.
        // Extension methods are static methods, but they're called as if they were instance methods on the extended type.
        // Their first parameter specifies which type the method operates on.
        // The parameter is preceded by the this modifier.
        // Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive.
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
        //At compile time, extension methods always have lower priority than instance methods defined in the type itself.
        //In other words, if a type has a method named Process(int i), and you have an extension method with the same signature,
        //the compiler will always bind to the instance method.
    }
}

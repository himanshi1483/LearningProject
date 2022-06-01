namespace LearningProject
{
    public interface InterfaceExample : InterfaceExample2
    {
        string ConcatName(string name, string surname);
    }

    public interface InterfaceExample2
    {
        string ConcatNameAndCity(string name, string surname, string city);
    }
}

[System.AttributeUsage(System.AttributeTargets.Class)]
public class Author : System.Attribute
{
    private string name;
    public double version; // this i
    public Author(string name) // this is positional parameter
    {
        this.name = name;
        version = 1.0;
    }
}

[Author("Milo", version = 1.2)]
class SampleA
{

}
Person person = new Person("Denis", 31);

Console.WriteLine(person.Name);
Console.WriteLine(person.Age);

public class Person
{
    private string _name;
    private int _age;

    public Person(string name, int age)
    {
        this._name = name;
        this._age = age;
        
    }

    public string Name
    {
        get
        {
            return this._name;
        }
         
    }
    public int Age
    {
        get
        {
            return this._age;
        }

    }

    
}
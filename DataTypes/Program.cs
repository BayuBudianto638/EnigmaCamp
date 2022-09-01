// Encapsulation
// Contoh 1
// C# program to illustrate encapsulation
using System;
public class Shinobi
{
    // private variables declared
    // these can only be accessed by
    // public methods of class
    private string shinobiName;
    private int shinobiAge;
    private string level;

    // using accessors to get and
    // set the value of studentName
    public string Name
    {
        get
        {
            return shinobiName;
        }

        set
        {
            shinobiName = value;
        }
    }

    // using accessors to get and
    // set the value of studentAge
    public int Age
    {
        get
        {
            return shinobiAge;
        }

        set
        {
            shinobiAge = value;
        }
    }

    public string Level
    {
        get
        {
            return level;
        }

        set
        {
            level = value;
        }
    }
}

// Driver Class
class EnigmaCamp
{
    // Main Method
    static public void Main()
    {
        // creating object
        Shinobi obj = new Shinobi();

        // calls set accessor of the property Name,
        // and pass "Uchiha Itachi" as value of the
        // standard field 'value'
        obj.Name = "Uchiha Itachi";

        // calls set accessor of the property Age,
        // and pass "21" as value of the
        // standard field 'value'
        obj.Age = 21;

        // calls set accessor of the property level
        obj.Level = "Jounin";

        // Displaying values of the variables
        Console.WriteLine("Name: " + obj.Name);
        Console.WriteLine("Age: " + obj.Age);
        Console.WriteLine("Level: " + obj.Level);
        Console.ReadKey();
    }
}

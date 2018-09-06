<Query Kind="Program" />

void Main()
{
    // Aggregation Examples - Aggregate, Sum, Average, Min, Max
    List<Person> people = new List<Person>()
    {
        new Person("Tod", "Vachev", 1, 180, 26, Gender.Male),
        new Person("John", "Johnson", 2, 170, 21, Gender.Male),
        new Person("Anna", "Maria", 3, 150, 22, Gender.Female),
        new Person("Kyle", "Wilson", 4, 164, 29, Gender.Male),
        new Person("Anna", "Williams", 5, 164, 28, Gender.Male),
        new Person("Maria", "Ann", 6, 160, 19, Gender.Female),
        new Person("John", "Jones", 7, 160, 22, Gender.Female),
        new Person("Samba", "TheLion", 8, 175, 23, Gender.Male),
        new Person("Aaron", "Myers", 9, 182, 21, Gender.Male),
        new Person("Aby", "Wood", 10, 165, 20, Gender.Female),
        new Person("Maddie","Lewis",  11, 160, 19, Gender.Female),
        new Person("Lara", "Croft", 12, 162, 23, Gender.Female)
    };
    int[] ints = new int[] { 1, 2, 2, 2, 3, 3 };

    // 01. Aggregate
    int intsSum = ints.Aggregate((p, x) => p + x);
	intsSum.Dump();
    int intsProduct = ints.Aggregate(23, (p, x) => p * x); // It starts with 23
	intsProduct.Dump();

    // 02. Average and Sum
    int intsSum2 = ints.Sum();
	intsSum2.Dump();
    double intsAverage = ints.Average();
	intsAverage.Dump();

    // 03. Average and Sum with Lambda Expressions
    int sumOfAges = people.Sum(p => p.Age);
	sumOfAges.Dump();
    var averageAge =  people.Sum(p => p.Age) * 1.0 / people.Count();
	averageAge.Dump();
    double averageAge2 = people.Average(p => p.Age);
	averageAge2.Dump();

    // 04. Min and Max with Lambda Expressions
    int minAge = people.Min(p => p.Age);
	minAge.Dump();
    int maxAge = people.Max(p => p.Age);	
	maxAge.Dump();
}

// Define other methods and classes here
internal class Person
{
    private string firstName;
    private string lastName;
    private int id;
    private int height;
    private int age;

    private Gender gender;

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            this.lastName = value;
        }
    }

    public int ID
    {
        get
        {
            return this.id;
        }
        set
        {
            this.id = value;
        }
    }

    public int Height
    {
        get
        {
            return this.height;
        }
        set
        {
            this.height = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

    public Gender Gender
    {
        get
        {
            return this.gender;
        }
        set
        {
            this.gender = value;
        }
    }

    public Person(string firstName, string lastName, int id, int height, int age, Gender gender)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.Height = height;
        this.Age = age;
        this.Gender = gender;
    }
}

internal enum Gender
{
    Male,
    Female
}
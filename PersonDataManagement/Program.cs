using PersonDataManagement;
public class Programe
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to person data Management...!");
        List<Person> listPersonsInCity = new List<Person>();
        AddRecords(listPersonsInCity);
        Console.WriteLine("                           ");
        TopTwo_Records_Age_Lessthan_Sixty(listPersonsInCity);
        Console.WriteLine("                           ");
        Checking_For_TeenAge(listPersonsInCity);
        Console.WriteLine("                           ");
        AverageAge(listPersonsInCity);
        Console.WriteLine("                           ");
        SpecificName(listPersonsInCity);
        SkipRecord(listPersonsInCity);
    }
    private static void AddRecords(List<Person> listPersonsInCity)
    {
        listPersonsInCity.Add(new Person("55", "Jhon", "12 main street, Newyork", 18));
        listPersonsInCity.Add(new Person("56", "Jordan", "12 main street, California", 60));
        listPersonsInCity.Add(new Person("51", "Mate", "12 main street, America", 55));
        listPersonsInCity.Add(new Person("50", "Markone", "12 main street, England", 65));
        listPersonsInCity.Add(new Person("54", "Ashish", "12 main street, India", 15));
        listPersonsInCity.Add(new Person("52", "Jho", "12 main street, mascow", 25));
        foreach (var item in listPersonsInCity)
        {
            Console.WriteLine(item.SSN + " " + item.Name + " " + item.Address + " " + item.Age);
        }
    }
    private static void TopTwo_Records_Age_Lessthan_Sixty(List<Person> listPersonsInCity)
    {
        foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
        {
            Console.WriteLine("Name : " + person.Name + " \t\tAge : " + person.Age);
        }
    }
    private static void Checking_For_TeenAge(List<Person> listPersonsInCity)
    {
        if (listPersonsInCity.Any(e => (e.Age >= 13 && e.Age <= 19)))
        {
            Console.WriteLine("Yes, We have TeenAge In List");
        }
        else
            Console.WriteLine("No, We Don't have TeenAge In List");
    }
    private static void AverageAge(List<Person> listPersonsInCity)
    {
        double avegAge = listPersonsInCity.Average(e => e.Age);
        Console.WriteLine("The Average Age of all the person is :- " + avegAge);
    }
    private static void SpecificName(List<Person> list)
    {
        Console.WriteLine("\nChecking whether a person having name 'Jhon' exists or not...");
        if (list.Exists(e => e.Name == "Jhon"))
        {
            Console.WriteLine("Yes, A person having name 'Jhon' exists in our list");
        }
        else
        {
            Console.WriteLine("No,We Don't Have Name in list");
        }
    }
    private static void SkipRecord(List<Person> list)
    {
        Console.WriteLine("\nSkipping every person whose age is less than 60 years...");
        foreach (Person person in list.Skip(e => e.Age < 60))
        {
            Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
        }
    }
}
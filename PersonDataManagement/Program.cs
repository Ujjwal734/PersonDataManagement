using PersonDataManagement;
public class Programe
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to person data Management...!");
        List<Person> listPersonsInCity = new List<Person>();
        AddRecords(listPersonsInCity);
        TopTwo_Records_Age_Lessthan_Sixty(listPersonsInCity);
        Checking_For_TeenAge(listPersonsInCity);

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
}
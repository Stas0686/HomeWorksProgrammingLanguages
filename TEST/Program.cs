Person Petr;
Petr = new Person();
Petr.firstName = "Petr";
Petr.lastName = "Ivanov";
Petr.ShowFullName();
class Person

{
    // Поля
    public string firstName;
    public string lastName;
    // Метод
    public void ShowFullName()
    {
        Console.WriteLine("Name is " + firstName + " " + lastName);
    }
}

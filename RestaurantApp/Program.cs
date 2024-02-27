// See https://aka.ms/new-console-template for more information


PersonalRegister service = new PersonalRegister();

service.register();


class PersonalRegister
{

    string name;
    string loan;

    public void register()
    {

        Console.WriteLine("Please, enter employee name");

        name = Console.ReadLine();

        Console.WriteLine("Please, enter employee salary");
        loan = Console.ReadLine();

        Console.WriteLine("name " + name + " " + "loan " + loan);
    }
}

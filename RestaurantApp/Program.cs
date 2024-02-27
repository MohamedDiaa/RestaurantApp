// See https://aka.ms/new-console-template for more information


PersonalRegister service = new PersonalRegister();

service.register();


class PersonalRegister
{

    string name;
    string loan;


    public void requestName() {
        Console.WriteLine("Please, enter employee name");
        name = Console.ReadLine();
    }

    public void requestSalary()
    {
        Console.WriteLine("Please, enter employee salary");
        loan = Console.ReadLine();
    }

    public void showResult()
    {
        Console.WriteLine("name " + name + " " + "loan " + loan);
    }

    public void register() {
        requestName();
        requestSalary();
        showResult();
    }
}

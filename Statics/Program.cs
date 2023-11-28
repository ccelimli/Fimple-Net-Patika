Console.WriteLine("Çalışna: {0}", Employee.DisplayCountOfEmployee);

Employee employee = new Employee("Çağatay", "Çelimli", "IT");
Employee employee1 = new Employee("Çağatay", "Çelimli", "IT");
Employee employee2 = new Employee("Çağatay", "Çelimli", "IT");
Employee employee3 = new Employee("Çağatay", "Çelimli", "IT");
Employee employee4 = new Employee("Çağatay", "Çelimli", "IT");

Console.WriteLine("Çalışna: {0}", Employee.DisplayCountOfEmployee);

Console.WriteLine("Toplam: {0}", Operations.Topla(3, 7));


class Employee
{
    private static int CountOfEmployee;

    public static int DisplayCountOfEmployee { get => CountOfEmployee; }
    private string Name;
    private string Surname;
    private string Department;

    static Employee() {
        CountOfEmployee = 0;
    }

    public Employee(string Name, string Surname, string Department)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Department = Department;
        CountOfEmployee++;
    }
}

static class Operations
{
    public static int Topla(int FirstNumber, int SecondNumber) {
        return FirstNumber + SecondNumber;    
    }

    static int Ciart(int FirstNumber, int SecondNumber)
    {
        return FirstNumber - SecondNumber;
    }


}
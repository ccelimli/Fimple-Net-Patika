Student student= new Student();
student.Name = "Çağatay";
student.Surname = "Çelimli";
student.StudentNo = 123;
student.Classes = 1;

student.Display();
Console.WriteLine("------------------------------------");
student.ClassIncrease();
student.Display();
Console.WriteLine("------------------------------------");
student.ClassDecrease();
student.Display();
Console.WriteLine("------------------------------------");
student.ClassDecrease();
student.Display();
class Student
{
    private string name;
    private string surname;
    private int studentNo;
    private int classes;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int StudentNo { get => studentNo; set => studentNo = value; }
    public int Classes { get => classes; set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf En Az 1 Olabilir!\n");
                classes = 1;
            }
            else
            {
                classes = value;
            }
        }
    }

    public Student(){}


    public Student(string Name, string Surname, int StudentNo, int Classes)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.StudentNo = StudentNo;
        this.Classes = Classes;
    }



    public void Display()
    {
        Console.WriteLine("İsim: " + Name + "\nSoyisim: " + Surname + "\nNumara: " + StudentNo + "\nSınıf: " + Classes);
    }

    public void ClassIncrease()
    {
        this.Classes=this.Classes+1;
    }

    public void ClassDecrease()
    {
        this.Classes=this.Classes-1;
    }
}
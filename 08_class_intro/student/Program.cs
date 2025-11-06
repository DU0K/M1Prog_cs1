namespace student;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Student student2 = new Student();

        studentinfo(student1, "Bernard", 17, 6785);
        studentinfo(student2, "donald", 16, 8614);

        print(student1);
        print(student2);
    }
    static void print(Student arg1)
    {
        Console.WriteLine("student: " + arg1.naam);
        Console.WriteLine("leeftijd: " + arg1.leeftijd);
        Console.WriteLine("studentnummer: " + arg1.studentennummer);
    }
    static void studentinfo(Student student, string Naam, int Leeftijd, int Studentennummer)
    {
        student.naam = Naam;
        student.leeftijd = Leeftijd;
        student.studentennummer = Studentennummer;        
    }
}

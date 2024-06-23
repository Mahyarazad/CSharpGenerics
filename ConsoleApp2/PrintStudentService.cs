
// See https://aka.ms/new-console-template for more information


public class PrintStudentService
{
    private readonly IPersonRepository<Student> _studentRepository;

    public PrintStudentService(IPersonRepository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public void Print()
    {
        var students = _studentRepository.Search("s");

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }


    }
}

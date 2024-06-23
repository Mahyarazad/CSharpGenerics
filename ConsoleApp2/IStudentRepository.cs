// See https://aka.ms/new-console-template for more information
public interface IPersonRepository<T> : IRepositoy<T> where T :Person, IComparable<T>, new()
{
    IEnumerable<T> Search(string name);
    T Create(Name name);
    T CreateDefault();
}


public interface IStudentRepository 
{ 
    IEnumerable<T> Search<T>(string name) where T :Student;
    T Create<T>(Name name) where T : Student;
    T CreateDefault<T>() where T :Student, new();
}

public class StudentRepositoy : IPersonRepository<Student>
{
    private Name[] _names = new Name[10];

    public StudentRepositoy()
    {
        _names[0] = new Name("Max", "Amini");
        _names[1] = new Name("Mamad", "Naghi");
        _names[2] = new Name("Steve", "Smith");
        _names[3] = new Name("Nick", "Chapas");
        _names[4] = new Name("Maahyar", "Azad");
        _names[5] = new Name("Ali", "Hosseni");
        _names[6] = new Name("Arash", "Alv");
        _names[7] = new Name("Amirali", "Bahrami");
        _names[8] = new Name("Hossen", "Ronaghi");
        _names[9] = new Name("limp", "Bizkit");
    }

    public Student Create(Name name)
    {
        return new Student(name.First, name.Last);
    }

    public Student CreateDefault()
    {
        return new Student();
    }

    public IEnumerable<Student> List()
    {
        int index = 0;
        while (index< _names.Length)
        {
            yield return new Student(_names[index].First, _names[index].Last);
            index++;
        }
    }

    public IEnumerable<Student> Search(string name)
    {
        return List().Where(x => x.FirstName.Contains(name) || x.LastName   .Contains(name));
    }

    public IEnumerable<Student> SortedList()
    {
        var students = List().ToList();
        students.Sort();
        return students;
    }
}
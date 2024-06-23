
// See https://aka.ms/new-console-template for more information

public class Student : Person, IComparable<Student>
{
    public Student() : this("FirstName", "LastName")
    {
        
    }
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if(obj is Student otherStudent)
        {
            if(otherStudent.LastName == this.LastName)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }

            return this.LastName.CompareTo(otherStudent.LastName);
        }
        throw new ArgumentException("Not a student", nameof(obj));
    }

    public int CompareTo(Student? other)
    {
        if (other is null) return 1;
        if (other.LastName == this.LastName)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }

        return this.LastName.CompareTo(other.LastName);
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }


}
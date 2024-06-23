// See https://aka.ms/new-console-template for more information
public interface IRepositoy<T> where T : IComparable<T>
{
    IEnumerable<T> List();
    IEnumerable<T> SortedList();
}

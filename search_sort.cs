public class search_sort{
     List<string> names = new List<string> { "<name>", "Ana", "Felipe" };
    public void search(){
        var index = names.IndexOf("Felipe");
if (index != -1)
{
  Console.WriteLine($"The name {names[index]} is at index {index}");
}
var notFound = names.IndexOf("Not Found");
Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
    }

    public void sort(){
        names.Sort();
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
    }
}
public class create_list{
    List<string> names = new List<string> { "<name>", "Ana", "Felipe" };
    public void cl(){
        
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
    }

    public void modify_list_content(){
        Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
    }
    public void index_property(){
        Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
    }

    public void count_property(){
        Console.WriteLine($"The list has {names.Count} people in it");
    }
}
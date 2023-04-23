public class Declare_and_use_variables{
    public void variable(){
        string aFriend = "Bill";
        Console.WriteLine(aFriend);

        aFriend = "Maira";
        Console.WriteLine(aFriend);

        Console.WriteLine("Hello " + aFriend);

        Console.WriteLine($"Hello , {aFriend}");
    }
}
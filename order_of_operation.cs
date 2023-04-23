public class order_of_operation{
      public void oo(){
        int a = 5;
        int b = 4;
        int c = 2;
        // int d = a + b * c;
        // int d = (a + b) * c;
        // int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
        int d = (a + b) / c;
        Console.WriteLine(d);
      }
}
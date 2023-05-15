using System;

class MainClass {
  public static void Main (string[] args) {
    double Balance1, Balance2, Balance3;

    Console.Write("Balance 1: ");
    Balance1 = double.Parse(Console.ReadLine());
    Console.Write("Balance 2: ");
    Balance2 = double.Parse(Console.ReadLine());
    Console.Write("Balance 3: ");
    Balance3 = double.Parse(Console.ReadLine());

    double amount;
    double remainingBalance1 = Balance1;
    double remainingBalance2 = Balance2;
    double remainingBalance3 = Balance3;

    do {
      Console.Write("Enter payment amount (0 or negative number to exit): ");
      amount = double.Parse(Console.ReadLine());

      if (remainingBalance1 >= amount) {
        remainingBalance1 -= amount;
      } else if (remainingBalance2 >= amount) {
        remainingBalance2 -= amount;
      } else if (remainingBalance3 >= amount) {
        remainingBalance3 -= amount;
      } else {
        Console.WriteLine("Left : {0}", amount);
        break;
      }

      Console.WriteLine("Balance 1: {0}, Balance 2: {1}, Balance 3: {2}", remainingBalance1, remainingBalance2, remainingBalance3);
    } while (amount > 0);
  }
}
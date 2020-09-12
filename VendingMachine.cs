using System;

class VendingMachine{
  public int Count = 30;
  public int Capacity = 100;
  public int MoneyCollected = 300;
  public string Manufacturer = "Vendy Inc.";

  public void Display(){
    Console.WriteLine("I am the display method for displaying the menu!");
  }
  public void DispenseProducts(){
    Console.WriteLine("I am the DispenseProducts method for dispensing the product!");
  }
  public void Refill(){
    Console.WriteLine("I am the Refill method for refilling the product!");
  }
}

class Demo{
  public static void Main(String[] args){
    var VendingMachine = new VendingMachine();
    Console.WriteLine("The capacity of the machine is: {0}", VendingMachine.Capacity);
    VendingMachine.Display();
  }
}
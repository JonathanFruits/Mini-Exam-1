using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter your name");
    string name = Console.ReadLine();
    
    Console.WriteLine("Please enter your height in inches " + name );
    int height = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter your weight in pounds " + name);
    double weight = Convert.ToDouble(Console.ReadLine());
    
    //(703 * weight ) / ( height * height);
    double BMI = (703 * weight ) / ( height * height);

    if (BMI <18.5){
      Console.WriteLine (name + " is underweight");
     }

    if (BMI == 18.5 && <24.9){
      Console.WriteLine (name + " is at a healthy weight");
    }
    
    if (BMI == 25 && <29.9) {
      Console.WriteLine (name + " is overweight");
    }
    
    if (BMI >= 30){
      Console.WriteLine(name + " is overweight");
    }

    






  }
}
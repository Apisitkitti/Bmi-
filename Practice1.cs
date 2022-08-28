using System;
public class BMI_test
{
    public static void Main(String[] args)
    {
        string name = inputName();
        string height = inputtall();
        string weight = inputweight();
        double tall = stringtodouble(height)/100;
        double maweight = stringtodouble(weight);
        double bmi = inputbmi(tall,maweight);
        information(name,tall,maweight,bmi);

    }
    public static string inputName()
    {
        Console.Write("Pls input your name : ");
        return Console.ReadLine();
        
        
    }
    public static string inputtall()
    {
        Console.Write("Pls input your height : ");
        return  Console.ReadLine();
        
    }
    public static string inputweight()
    {
        Console.Write("Pls input your weight : ");
        return Console.ReadLine();
    }
    
    public static double stringtodouble(string number)
    {
     if(double.TryParse(number,out double bodyweight))
     {
        return bodyweight;
     }   
        throw new Exception("Pls input again ");
    }
    public static double inputbmi(double tall , double weight)
    {
        return weight/Math.Pow(tall,2);
    } 
    
    public static void information(string name,double tall,double weight,double bmi)
    {
        Console.WriteLine("************************************************");
        Console.WriteLine("Name: {0}",name);
        Console.WriteLine("Tall: {0}",tall*100);
        Console.WriteLine("weight: {0}",weight);
        Console.WriteLine("Your BMI is: {0}",bmi);
        Console.WriteLine("************************************************");
    }




}
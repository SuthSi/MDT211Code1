public class Program{
    static void Main (string[] args){
        string name = InputName();
        int number = InputNumber();
        string owner = InputOwner();
        int value = InputValue();
        Info info = new Info();
        info.PrintInformation(name,number,owner,value);
        string gold1 = InputMoney();
        double gold2 = ConvertStringToDouble(gold1);
        CalculateMoney money = new CalculateMoney();
        money.Calculate(gold2);
    }
    public static string InputName(){
        Console.Write("Please input Name: ");
        return Console.ReadLine();
    }
    public static int InputNumber(){
        Console.Write ("Please input Number: ");
        return int.Parse(Console.ReadLine());
    }
    public static string InputOwner(){
        Console.Write("Please input Owner Name: ");
        return Console.ReadLine();
    }
    public static int InputValue(){
        Console.Write ("Please input Registered Value: ");
        return int.Parse(Console.ReadLine());
    }
    public static string InputMoney(){
        Console.Write ("Please input Money: ");
        return Console.ReadLine();
    }
    public static double ConvertStringToDouble(string value){
        if(double.TryParse(value, out double number)){
            return number;
        }
        throw new Exception("Please input your Money.");
    }
}
public class CalculateMoney{
    public void Calculate(double gold2){
        gold2 = gold2 * 100;
        int A,B,C,D,E,F,G,H,I,J,K,gold3;
        A=(int)(gold2/100000);
        gold3=(int)(gold2%100000);

        B=(int)(gold2/50000);
        gold3=(int)(gold2%50000);

        C=(int)(gold2/10000);
        gold3=(int)(gold2%10000);

        D=(int)(gold2/5000);
        gold3=(int)(gold2%5000);

        E=(int)(gold2/2000);
        gold3=(int)(gold2%2000);

        F=(int)(gold2/1000);
        gold3=(int)(gold2%1000);

        G=(int)(gold2/500);
        gold3=(int)(gold2%500);

        H=(int)(gold2/200);
        gold3=(int)(gold2%200);

        I=(int)(gold2/100);
        gold3=(int)(gold2%100);

        J=(int)(gold2/50);
        gold3=(int)(gold2%50);

        K=(int)(gold2/25);
        gold3=(int)(gold2%25);

        Console.WriteLine("1000: {0}",A);
        Console.WriteLine("500: {0}",B);
        Console.WriteLine("100: {0}",C);
        Console.WriteLine("50: {0}",D);
        Console.WriteLine("20: {0}",E);
        Console.WriteLine("10: {0}",F);
        Console.WriteLine("5: {0}",G);
        Console.WriteLine("2: {0}",H);
        Console.WriteLine("1: {0}",I);
        Console.WriteLine("0.50: {0}",J);
        Console.WriteLine("0.25: {0}",K);
        Console.ReadLine();
    }
}
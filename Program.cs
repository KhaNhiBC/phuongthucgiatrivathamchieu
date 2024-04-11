using System.ComponentModel.Design.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        int c = 20;
        Console.WriteLine($"Gia tri ban dau la {a} va {b} va {c}");
        Mul(ref a, ref b);
        Example(out c);
        Console.WriteLine($"Gia tri sau khi thay doi la {a} va {b} va {c}");

    }

    static void Mul(ref int a, ref int b){
        a = 20*2;
        b = 30*2;
    }
    static void Example(out int c){
        c = 100;
    }
}
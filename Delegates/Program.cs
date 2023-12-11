// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;

partial class Program
{
    //declaration = new datatype
    delegate void Compute(int n1, int n2);
    delegate void Contractor(double budget);
    

    static void Main()
    {
        UsingGenericDelegates();
    }

    private static void UsingGenericDelegates()
    {
        Action<double> RockyRaniRegisterMarriage = new Action<double>((budget) =>
        {
            Console.WriteLine($"Registration fee charges: {budget * 95 / 100}");
            Console.WriteLine($"Reception charges: {budget * 5 / 100}");
        }
                );

        Func<int, int, string> modifiedCompute = (n1, n2) => $"Addition: {n1 + n2}";
        modifiedCompute += (n1, n2) => $"Subtraction: {n1 - n2}";
        modifiedCompute += (n1, n2) => $"Division: {n1 / n2}";

        Predicate<int> isActive = (v) =>
        {
            if (v == 0) return false;
            else return true;
        };

        //invocation of all the above delegates
        RockyRaniRegisterMarriage(50000d);
        Console.WriteLine(modifiedCompute(100, 200));
        Console.WriteLine($"Output of Predicate: {isActive(1)}");
    }

    private static void RoackyRaniMarriage()
    {
        Contractor RockyRaniMarriage = new Contractor((b) => Console.WriteLine($"Pandit charges: {b * 20 / 100}"));
        RockyRaniMarriage += (b) => Console.WriteLine($"Catering Charges: {b * 50 / 100}");
        RockyRaniMarriage += (b) => Console.WriteLine($"Mandap Decoration: {b * 5 / 100}");
        RockyRaniMarriage += (b) => Console.WriteLine($"Couple arrive in Porsche reserved for 2 days: {b * 15 / 100}");

        //get rocky and rani married viz,, invoke the delegate like a function
        RockyRaniMarriage(5000000);
    }

    private static void DelegatesUsingLambdas()
    {
        //instatntiation
        Compute objShortCompute = new Compute((a, b) => Console.WriteLine($"Addition: {a + b}"));
        objShortCompute += (s, t) => Console.WriteLine($"Subtraction: {s - t}");
        objShortCompute += (a, b) => Console.WriteLine($"Multiplication: {a * b}");
        objShortCompute += (s, t) => Console.WriteLine($"Division: {s / t}");

        //Invocation
        objShortCompute(250, -50);
    }

    private static void DelegatesUsingLongCutTechnique()
    {

        //instantiate
        Compute objCompute = new Compute(AddFn);
        objCompute += SubFn;
        objCompute += MulFn;
        objCompute += DivFn;

        //invoke the delegate exactly like a function
        objCompute(100, 200);
    }

    static void AddFn(int n1, int n2)
    {
        Console.WriteLine($"Output of division: {n1+n2}");
    }
    static void SubFn(int n1, int n2)
    {
        Console.WriteLine($"Output of division: {n1-n2}");
    }
    static void MulFn(int n1, int n2)
    {
        Console.WriteLine($"Output of division: {n1*n2}");
    }
    static void DivFn(int n1, int n2)
     {
        Console.WriteLine($"Output of division: {n1/n2}");
    }

}

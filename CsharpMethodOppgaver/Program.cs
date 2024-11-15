// See https://aka.ms/new-console-template for more information
    
//Oppgave 1
decimal num1 = 5.5m;
decimal num2 = 5.5m;

decimal SummarizeNums(decimal num1, decimal num2)
{
    return num1 + num2;
}
Console.WriteLine($"{SummarizeNums(num1,num2)}");

//Oppgave 2
void MakeText()
{
    Console.WriteLine("This Method doesn't return anything c:");
}

SummarizeNums(num1, num2);
MakeText();

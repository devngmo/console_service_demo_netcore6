// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int counter = 1;
int nReset = 0;
while (true)
{
    Console.WriteLine($"Reset [{nReset}] counter {counter}");
    Thread.Sleep(3000);
    counter++;
    if (counter > 999999999)
    {
        counter = 1;
        nReset++;
    }
}
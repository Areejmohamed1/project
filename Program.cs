// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 5; i < 30; i++)
{
    int perfectnum = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
        {
            perfectnum = perfectnum + j;
        }
    }
    if (perfectnum == i)
        Console.WriteLine("the perfect numbers is" + perfectnum);
}

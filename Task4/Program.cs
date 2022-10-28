int numA = new Random().Next(-100, 100);
int numB = new Random().Next(-100, 100);
int numC = new Random().Next(-100, 100);

Console.WriteLine(numA);
Console.WriteLine(numB);
Console.WriteLine(numC);

if (numA > numB)
{
    if (numA > numC) Console.WriteLine(numA);
    else Console.WriteLine(numC);
}

else
{
    if (numB > numC) Console.WriteLine(numB);
    else Console.WriteLine(numC);
}
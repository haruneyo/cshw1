int numA = new Random().Next(-100, 100);
int numB = new Random().Next(-100, 100);

Console.WriteLine(numA);
Console.WriteLine(numB);

if (numA > numB) Console.WriteLine(numA);
else
    Console.WriteLine(numB);
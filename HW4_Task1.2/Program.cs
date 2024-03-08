// Alexandra Camarena
// MIS 3013 
// HW4 Task 1.2

//Q2

int n;
Console.Write("n=? ");
string nStr= Console.ReadLine();
n= Convert.ToInt32(nStr);

int facR = Factorial(n);
string outMesStr = string.Format($"{n}!=");
Console.Write(outMesStr);

for (int i =  n; i < n; i --)
{
    Console.Write(i);
    if (i >= 2) 
    {
        Console.Write("*");
    }
}
outMesStr = string.Format($"={facR}");
Console.Write(outMesStr);

for (int i = n; i >= 1; i--)
{
    Console.Write(i);
    Console.Write("*");
}

outMesStr = string.Format($"={facR}");
Console.WriteLine(outMesStr);

int Factorial(int N)
{
    int r = 1;
    for (int i = 1; i <= N; i++)
    {
        r = r * i;
    }
    return r;
}


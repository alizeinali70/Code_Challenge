
int res = 0;

int fibo(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;

    res = fibo(n - 1) + fibo(n-2);

    return res;
}



 int Fib(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    int fib0 = 1;
    int fib1 = 1;

    for (int i = 0; i < n - 2; i++)
    {
        int temp = fib1;
        fib1 = fib0 + fib1;
        fib0 = temp;
    }
    return fib1;
}

int result = Fib(10);
Console.WriteLine(result);
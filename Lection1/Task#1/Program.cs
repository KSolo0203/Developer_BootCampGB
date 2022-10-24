// Find Greatest Common Divisor. Euclidean algorithm

int FindGCD (int A, int B, int count)
{
    if (A < B) (A, B) = (B, A);
    if (A == 0) return B;
    else if (B == 0) return A;
    else
    {
        System.Console.WriteLine($"Счетчик итераций: {count}");
        count ++;
        return FindGCD(B, A % B, count);
    }
}

int count = 1;
System.Console.WriteLine(FindGCD(192,270, count));
int Summ(int n){
    int sum = 0;
    while (n != 0){
        sum += n%10;
        n /= 10;
    }
    return Math.Abs(sum);
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summ(n));

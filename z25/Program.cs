int Degree(int a, int b){
    int d = a;
    for (int i = 1; i < b; i++){
        d *= a;
    }
    return d;
}

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Degree(a,b));

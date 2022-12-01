// Немного видоизменила задачу
// В итоге выводится массив заданного размера
// И разделение производится с заданного элемента (если конечно надо делить, я не до конца поняла пример)

int[] FillingArray(int n){
    Random rnd = new Random();
    int[] arr = new int[n];
    for(int i = 0; i < n; i++){
        arr[i] = rnd.Next(0,10);
    }
    return arr;
}

void OutputArray(int[] a, int n, int start){
    Console.Write($"[");
    for(int i = start; i < n-1; i++){
        Console.Write($"{a[i]} ");
    }
    Console.WriteLine($"{a[n-1]}]");
}

Console.WriteLine("Введите число - размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = FillingArray(n);
OutputArray(arr, n, 0);

Console.WriteLine("Введите элемент, с которого хотите разбить массив на части");
int m = Convert.ToInt32(Console.ReadLine());

if (m >= n || m < 1){
    Console.WriteLine("Данный параметр не может быть задан");
}
else{
    OutputArray(arr, m, 0);
    OutputArray(arr, n, m);
}

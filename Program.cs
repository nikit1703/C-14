Console.WriteLine("Введите количество элементов массива: ");
int size  = int.Parse(Console.ReadLine());

string[] arr1 = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
	arr1[i] = result;  

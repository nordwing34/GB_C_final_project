/*
Итоговый проект

Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
*/

string[] myStrArray = new string[] {
	"Строка Раз",
	"Строка Два",
	"Строка Три",
	"Строка Четыре"
};

System.Console.Clear();
System.Console.WriteLine("Исходный массив строк: ");
GetSourceArray(myStrArray);
System.Console.WriteLine(String.Empty);

System.Console.Write("Введите длину строки ");
int lengthStr = SetNumber(1, 8, "от 1 до 8: ");
// System.Console.WriteLine(lengthStr);
System.Console.WriteLine(String.Empty);

System.Console.WriteLine($"Из них строки с длиной не более {lengthStr} символов: ");
GetDestArray(lengthStr, myStrArray);




/*** Функции ******************************************************************/
// Универсальная функция для приёма чисел от пользователя
// Принимает: 1) минимальное значение, 2) максимальное значение, 3) комментарий
// Не позволяет ввести число, которое не попадает в заданный диапазон
int SetNumber(int minInt, int maxInt, string message){
	int ret = 0;

	while (true){
		System.Console.Write($"({message}): ");
		ret = Convert.ToInt32(System.Console.ReadLine());
		if(ret >= minInt && ret <= maxInt){
			break;
		}
	}
	return ret;
}

// Функция выводит в консоль массив
void GetSourceArray(string[] sourceArr){
	foreach (var item in sourceArr){
		System.Console.WriteLine($"{item}");
	}
}

// Функция выводит в консоль строки массива, удовлетворяющие условию
void GetDestArray(int maxStr, string[] destArray){
	System.Console.WriteLine("ИТОГ: " + lengthStr);
}


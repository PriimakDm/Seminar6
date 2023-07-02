// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int [] CreateArray (int length)
{
    int [] arrayNew = new int [length];
    for (int i = 0; i < arrayNew.Length; i++)
    {
        Console.WriteLine("input any number: ");
        arrayNew [i] = (Convert.ToInt32(Console.ReadLine()));
    }
    return arrayNew;
}

void ShowArray (int [] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write (arrayToShow[i]);
        if (i != arrayToShow.Length - 1) Console.Write (", ");
        else Console.Write (".");
    }
    Console.WriteLine ("");
}

int PositivNam (int [] arrayPositiv)
{
    int count = 0;
    for (int i = 0; i < arrayPositiv.Length; i++)
    {
        if (arrayPositiv[i] > 0) count++;
    }
return count;
}

Console.WriteLine("How many numbers do you want to enter? ");
int length = (Convert.ToInt32(Console.ReadLine()));

int [] createdArrey = CreateArray (length);
ShowArray(createdArrey);
int countArr = PositivNam(createdArrey);

Console.WriteLine($"number of positive numbers {countArr}");
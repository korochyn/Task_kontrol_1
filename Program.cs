// Урок 1. Контрольная работа
// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. 
// Мы должны убедится, что базовое знакомство с IT прошло успешно.
// 
// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, 
// как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] > [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] > [“-2”]
//[“Russia”, “Denmark”, “Kazan”] > []

int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}

//Создание массива 
string [] GenerateArray(int row)
{
    string [] array = new string[row];
    for (int i = 0; i < row; i++)
    {
        
        Console.Write($"Ведите  {i+1}-й элемент массива:  ");
        array[i] = Console.ReadLine()!;
        
    }
    return array;
}

// Метод вывода массива
void PrintArray (string [] array)
{
    Console.Write("[");
    for(int i=0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

// Определение длинs массива
int Array_Length(string [] array, int del)
{
    int count =0;

    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i].Length <= del) count++;
        
    }
    return count;
}


// метод упорядочивания по убыванию длин строк элементов массива
string [] sorting_Length(string [] array)
{

    string max = array[0];
                 
    for (int r = 0; r < array.Length-1; r++) 
        {
        for (int i = 0; i < array.Length-1; i++) 
            {
            if (array[i+1].Length < array[i].Length) 
                {
                    max = array[i+1];
                    array[i+1]=array[i];
                    array[i]=max;
                }
       
            }   
        }
            
    
    return array;
}


//Создание массива 
string [] GenerateArray_del(string [] array, int del)
{
    string [] array_del = new string[del];
    for (int i = 0; i < del; i++)
    {
        
        array_del[i] = array[i];
        
    }
    return array_del;
}




int row = Promt("Введите длину массива  :");
string [] array = GenerateArray(row);

Console.WriteLine("Вами был введен массив в виде: ");
PrintArray (array);

int del = Promt("Введите ограничительную величину :");
int count = Array_Length(array, del);
Console.WriteLine($"{count} элемета массива имеют длину меньше чем ограничительная величина {del}");
string [] array_new = sorting_Length(array);
Console.WriteLine("После сорировки по длине строк массив имеет вид:");
PrintArray(array_new);
Console.WriteLine($"Массив строк имеющих длину не более чем {del} имеет вид:");
string [] array_del = GenerateArray_del(array_new, count);
PrintArray(array_del);
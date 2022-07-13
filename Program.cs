void Task1(){

    /*
    Напишите программу, которая на вход принимает два числа и выдаёт, 
    какое число большее, а какое меньшее.
    */

    Console.Write("Введите первое число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    string result = $"Первое число '{numberA}' меньше второго числа '{numberB}'";

    if(numberA > numberB){
        result = $"Первое число '{numberA}' больше второго числа '{numberB}'";
    }
    else{
        if(numberA == numberB){
            result = "Оба числа равны";
        }
    }

    Console.WriteLine(result);
}

void Task2(){
    
    /*
    Напишите программу, которая принимает на вход три числа 
    и выдаёт максимальное из этих чисел.
    */
    

    Console.Write("Введите первое число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int numberC = Convert.ToInt32(Console.ReadLine());
    int numberMax = numberA;
    string result = $"Первое число '{numberMax}' максимальное";

    if(numberMax < numberB){
        numberMax = numberB;
        result = $"Второе число '{numberMax}' максимальное";
    }
    if(numberMax < numberC){
        numberMax = numberC;
        result = $"Третье число '{numberMax}' максимальное";
    }

    Console.WriteLine(result);
}

void Task3(){

    /*
    Напишите программу, которая на вход принимает число и выдаёт, 
    является ли число чётным (делится ли оно на два без остатка).
    */

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string result = "Число нечётное";

    if(number % 2 == 0){
        result = "Число чётное";
    }

    Console.WriteLine(result);

}

void Task4(){

    /*
    Напишите программу, которая на вход принимает число (N), 
    а на выходе показывает все чётные числа от 1 до N.
    */

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    int startNumber = 1;

    while(startNumber <= number){
        if(startNumber % 2 == 0){
            Console.Write(startNumber + ",");
        }
        startNumber += 1;
    }

    Console.Write("\b ");

}

// Task1();
// Task2();
// Task3();
Task4();

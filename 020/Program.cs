// 20. Дано число. Проверить кратно ли оно 7 и 23


string number = Console.ReadLine();

int number1 = Convert.ToInt32(number);

if((number1 % 7 == 0) && (number1 % 23 == 0)){

    Console.WriteLine(true);

} else{
    Console.WriteLine(false);
}





// 22.По двум заданным числам проверять является ли одно квадратом другого.

string a= Console.ReadLine();
string b= Console.ReadLine();
int a1 = Convert.ToInt32(a);
int b1= Convert.ToInt32(b);
if (a1*a1== b1 || b1*b1==a1){
    Console.WriteLine(true);
}else {
    Console.WriteLine(false);
}
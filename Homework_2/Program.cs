//Подсчитать сумму цифр в числе
Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
do
{
    sum = sum + number%10;
    number = number/10;
}
while(number>0);
Console.WriteLine(sum);

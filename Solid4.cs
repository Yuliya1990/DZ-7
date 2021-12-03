using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IDiscount
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);

    
}
interface IAttrItem
{
    void SetColor(byte color);
    void SetSize(byte size);
}
interface Price
{
    void SetPrice(double price);
}

class Book: IDiscount, Price
{
    void ApplyDiscount(String discount){};
    void ApplyPromocode(String promocode){};
}
class Wear: Price, IAttrItem
{

    void SetColor(byte color){};
    void SetSize(byte size){};
    void SetPrice(double price){};
}

class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}
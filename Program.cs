using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Как тебя зовут?");
var pogonialo = Console.ReadLine();
Console.WriteLine("Привет, " + pogonialo + " как твои дела?");
var nevajno = Console.ReadLine();
Console.WriteLine("Ясно, хочешь этих мягких французских булок?");
var otvet = Console.ReadLine();
if (otvet == "да")
{
    Console.WriteLine("Сколько булок тебе нужно?");
    try
    {
        var chislo1 = int.Parse(Console.ReadLine());
        var cena1 = 10;
        var cena2 = cena1 * chislo1;
        Console.WriteLine("С вас " + cena2 + " денег");
    }
    catch (FormatException)
    {
        Console.WriteLine("Введи корректное число, целое и цифрами, так сколько булок ты хочешь?");
        var chislo2 = int.Parse(Console.ReadLine());
        var cena3 = 10;
        var cena4 = cena3 * chislo2;
        Console.WriteLine("с вас " + cena4 + " денег");
    }
}
if (otvet == "нет")
{
    Console.WriteLine("Жаль, но я знаю, что тебе может пригодится");
}
Console.WriteLine("Хочешь я дам тебе кота?");
var kot = Console.ReadLine();
if (kot == "да")
{
    Console.WriteLine("Держи");
    Console.WriteLine(@"
    ┈┈┈╭┳┳╮
    ┈┈┈┣╭╮┫┈┏╮┈╭┓
    ┈┈┈┣╰╰╯━┫╋┳╋┃
    ┈┈┈╰┫┈╮┈┣▇━▇┫
    ┈┈┈┈┃┈┻╮╰╰┻╯╯┳╮┈
    ┈┈▔▔▔▔▔▔▔▔▔▔▔▔▔┈");
}
if (kot == "нет")
{
    Console.WriteLine("Странный ты человек, от кота отказался");
}
//Girdigimiz sayiyi 1den baslayarak tek sayilarini yazdiran dongu

int  sayac = Int.Parse(Console.WriteLine("Sayi giriniz:"));
for (int i = 1; i<=sayac; i++)
{
    if(i%2 == 1)
    {
        Console.WriteLine(i);
    }
}

//1-1000 arasindaki cift ve tek sayilarin toplami veren dongu

int tekToplam = 0;
int ciftToplam = 0;
for (int i = 1; i <= 1000; i++)
{
    if(i%2 == 1)
        tekToplam += i;
    else
        ciftToplam += i;
}
Console.WriteLine("Tek Toplam : " + tekToplam);
Console.WriteLine("Cift Toplam : " + ciftToplam);

//break continue
for (int i = 1; i < 10; i++)
{
    if(i==4);
        break;
    Console.WriteLine(i);
}
for (int i = 1; i < 10; i++)
{
    if(i==4)
        continue;
    Console.WriteLine(i);
}
//Sonsuz dongu
/*for (; ;)
{
    Console.WriteLine("Sonsuz Dongu");
}*/
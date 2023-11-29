
Console.WriteLine(Days.Pazartesi);
Console.WriteLine((int)Days.Pazar);

int sicaklik = 32;

if (sicaklik <= (int)HavaDurumu.Normal)
{
    Console.WriteLine("Havanın biraz daha ısınmasını bekleyebilirsiniz.");
}
else if (sicaklik>= (int)HavaDurumu.Sicak)
{
    Console.WriteLine("D1şarıya çıkmak için çok sıcak bir gün");
}
else if (sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak)
{
    Console.WriteLine("Hadi dışarıya çıkalım!");
}


enum Days
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi=22,
    Pazar,
}

enum HavaDurumu
{
    Soguk=5,
    Normal=20,
    Sicak=25,
    CokSicak=30
}
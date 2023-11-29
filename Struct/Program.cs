Dikdortgen dikdortgen = new Dikdortgen();
Console.WriteLine("Class: "+ dikdortgen.Hesapla().ToString());

Dikdortgen_Struct dikdortgen_Struct;
dikdortgen_Struct.Uzun = 5;
dikdortgen_Struct.Kisa = 5;

Console.WriteLine("Struct: "+ dikdortgen_Struct.Hesapla().ToString());
class Dikdortgen
{
    public int Uzun;
    public int Kisa;

    public Dikdortgen()
    {
        Uzun = 3;
        Kisa = 1;
    }

    public int Hesapla()
    {
        return Uzun * Kisa;
    }
}

struct Dikdortgen_Struct
{
    public int Uzun;
    public int Kisa;

    public Dikdortgen_Struct(int Uzun, int Kisa)
    {
        this.Uzun = Uzun; this.Kisa = Kisa;
    }

    public int Hesapla()
    {
        return Uzun * Kisa;
    }
}
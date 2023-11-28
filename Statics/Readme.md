**Static S�n�f ve �yeler**


**Static �yeler**


Bir s�n�f�n static olamayan �yelerine nesneler arac�l���yla eri�irken static olan metotlara ve �zelliklere ise nesne olu�turmadan o s�n�f�n ismi arac�l���yla eri�iriz.


```
class Ogrenci {
    public static int OgrenciSayisi = 0;
    public string Isim;
    public string Soyisim;
    public Ogrenci() {
        OgrenciSayisi++;
    }
}

class Program {
    static void Main(string[] args) {
        //Static s�n�f �yesine eri�im
        Console.WriteLine("��renci say�s�: {0}",Ogrenci.OgrenciSayisi);

        //Static olmayan sinif �yesine eri�im
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Isim = "Deniz";
        ogrenci1.Soyisim = "Arda";
        
        Ogrenci ogrenci2 = new Ogrenci();
        ogrenci2.Isim = "Ay�e";
        ogrenci2.Soyisim = "Y�lmaz";

        Console.WriteLine("��renci Say�s�: {0}", Ogrenci.OgrenciSayisi);
    }
}
```

Yukar�da hem static hemde static olmayan s�n�f �yesine sahip bir s�n�f tan�m� ve program i�erisinden kullan�m� g�r�yorsunuz. Static olmayan �yeler nesne baz�nda yarat�l�rken static s�n�f �yeleri uygulama �al��t��� s�rece kendilerine atanan veriyi tutarlar. Yani yukar�daki �rnek i�in konu�ursak, "Isim" ve "Soyisim" her nesne yarat�ld���nda ba�lang�� de�eri olarak null al�r, atamas� yap�ld���ndaysa nesne baz�nda de�erini tutar. Ama "Ogrenci Say�s�" field'� program boyunca nesne yarat�ld�k�a ��renci say�s�n�n de�erini 1 artt�rarak bu veriyi korur.



Yukar�daki �rnekte de g�rebilece�iniz gibi bir �zelli�i static yapmak i�in geri d�n�� tipi ya da veri tipinden �nce eri�im belirleyiciden sonra **"static"** anahtar kelimesini koyman�z yeterlidir.



Normal metotlar gibi kurucu metotlar� da static olarak tan�mlayabiliriz. S�n�f�n static �yelerinin ba�lang�� de�erlerini static kurucular arac�l���yla yapabiliriz. Parametre almazlar ve eri�im belirleyicileri yoktur.



**Static S�n�flar**


Metotlar ve �zellikler gibi s�n�flar da static anahtar kelimesi ile olu�turulabilirler. Yukar�daki �rnekte de g�rebilece�iniz �zere normal s�n�flar i�erisinde static metotlar ve �yeler kullanabiliriz. Peki o halde neden s�n�flar� static yapma ihtiyac�m�z olsun? Buna okunabilirli�i artt�rmak i�in diyebiliriz.



Bir s�n�f�n t�m �yeleri static ise s�n�f� da static yapmak kullan�m� kolayla�t�ran bir yakla��m olur.
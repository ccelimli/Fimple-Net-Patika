**Static Sýnýf ve Üyeler**


**Static Üyeler**


Bir sýnýfýn static olamayan üyelerine nesneler aracýlýðýyla eriþirken static olan metotlara ve özelliklere ise nesne oluþturmadan o sýnýfýn ismi aracýlýðýyla eriþiriz.


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
        //Static sýnýf üyesine eriþim
        Console.WriteLine("Öðrenci sayýsý: {0}",Ogrenci.OgrenciSayisi);

        //Static olmayan sinif üyesine eriþim
        Ogrenci ogrenci1 = new Ogrenci();
        ogrenci1.Isim = "Deniz";
        ogrenci1.Soyisim = "Arda";
        
        Ogrenci ogrenci2 = new Ogrenci();
        ogrenci2.Isim = "Ayþe";
        ogrenci2.Soyisim = "Yýlmaz";

        Console.WriteLine("Öðrenci Sayýsý: {0}", Ogrenci.OgrenciSayisi);
    }
}
```

Yukarýda hem static hemde static olmayan sýnýf üyesine sahip bir sýnýf tanýmý ve program içerisinden kullanýmý görüyorsunuz. Static olmayan üyeler nesne bazýnda yaratýlýrken static sýnýf üyeleri uygulama çalýþtýðý sürece kendilerine atanan veriyi tutarlar. Yani yukarýdaki örnek için konuþursak, "Isim" ve "Soyisim" her nesne yaratýldýðýnda baþlangýç deðeri olarak null alýr, atamasý yapýldýðýndaysa nesne bazýnda deðerini tutar. Ama "Ogrenci Sayýsý" field'ý program boyunca nesne yaratýldýkça öðrenci sayýsýnýn deðerini 1 arttýrarak bu veriyi korur.



Yukarýdaki örnekte de görebileceðiniz gibi bir özelliði static yapmak için geri dönüþ tipi ya da veri tipinden önce eriþim belirleyiciden sonra **"static"** anahtar kelimesini koymanýz yeterlidir.



Normal metotlar gibi kurucu metotlarý da static olarak tanýmlayabiliriz. Sýnýfýn static üyelerinin baþlangýç deðerlerini static kurucular aracýlýðýyla yapabiliriz. Parametre almazlar ve eriþim belirleyicileri yoktur.



**Static Sýnýflar**


Metotlar ve özellikler gibi sýnýflar da static anahtar kelimesi ile oluþturulabilirler. Yukarýdaki örnekte de görebileceðiniz üzere normal sýnýflar içerisinde static metotlar ve üyeler kullanabiliriz. Peki o halde neden sýnýflarý static yapma ihtiyacýmýz olsun? Buna okunabilirliði arttýrmak için diyebiliriz.



Bir sýnýfýn tüm üyeleri static ise sýnýfý da static yapmak kullanýmý kolaylaþtýran bir yaklaþým olur.
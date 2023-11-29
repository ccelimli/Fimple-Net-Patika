**Struct(Yapý) Nedir ?**


Struct'lar yani yapýlar sýnýflara çok benzerler. Struct ile yapýp sýnýf ile yapamayacaðýz bir iþlem yoktur diyebiliriz. Peki o halde struct yani yapýlara neden ihtiyaç duyulur?



Class kullanmanýzý gerektirecek kadar komplex olmayan yapýlarýnýz varsa ve verileri kapsüllemek iþinizi görecekse yapýlarý tercih edebilirsiniz.



**Yapýlarýn özellikleri:**



Class lar referans tipli özellikler gösterir, Yapýlar ise deðer tipli özellikler gösterirler. En temel fark budur.
Diðer struct ya da sýnýflardan kalýtým almazlar.
Interface'lerden kalýtým alabilirler.
**new** anahtar sözcüðü ile nesneleri yaratýlabilir.
Sýnýflar gibi metot, property ve field'lardan oluþurlar.
Sýnýf içerisinde struct, struct içerisinde de sýnýf oluþturulabilir.
Static üye barýndýrabilirler.


Yapýlarýn söz dizimi:


```
struct Ogrenci {
    public string Isim;
    public string Soyisim {get;set;}
    public static int OgrenciSayýsý=0;
}
```
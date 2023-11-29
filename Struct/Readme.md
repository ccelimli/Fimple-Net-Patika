**Struct(Yap�) Nedir ?**


Struct'lar yani yap�lar s�n�flara �ok benzerler. Struct ile yap�p s�n�f ile yapamayaca��z bir i�lem yoktur diyebiliriz. Peki o halde struct yani yap�lara neden ihtiya� duyulur?



Class kullanman�z� gerektirecek kadar komplex olmayan yap�lar�n�z varsa ve verileri kaps�llemek i�inizi g�recekse yap�lar� tercih edebilirsiniz.



**Yap�lar�n �zellikleri:**



Class lar referans tipli �zellikler g�sterir, Yap�lar ise de�er tipli �zellikler g�sterirler. En temel fark budur.
Di�er struct ya da s�n�flardan kal�t�m almazlar.
Interface'lerden kal�t�m alabilirler.
**new** anahtar s�zc��� ile nesneleri yarat�labilir.
S�n�flar gibi metot, property ve field'lardan olu�urlar.
S�n�f i�erisinde struct, struct i�erisinde de s�n�f olu�turulabilir.
Static �ye bar�nd�rabilirler.


Yap�lar�n s�z dizimi:


```
struct Ogrenci {
    public string Isim;
    public string Soyisim {get;set;}
    public static int OgrenciSay�s�=0;
}
```
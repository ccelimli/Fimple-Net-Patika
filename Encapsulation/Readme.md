# Encapsulation Kavram� ?


C#'�n %100 nesne y�nelimli bir dil oldu�undan bahsetmi�tik. **Encapsulation** yani **Kaps�lleme** kavram� bir �zeli�i ba�ka s�n�flardan saklamak ya da korumakt�r.



�rne�in siz bir propery yani �zellik tan�m� yapt�n�z ve di�er s�n�flar i�erisinden eri�ilsin ama sadece okumak i�in eri�ilsin de�eri d��ar�dan de�i�tirilemesin istiyorsunuz. Bunu kaps�lleme yaparak sa�layabilirsiniz. Kaps�lleme i�lemini ise property leri kullanarak yapabilirsiniz.



Kaps�lleme sayesinden nesneler bilin�siz olarak kullan�mdan korunmu� olur. Fakat baz� durumlarda private field'lara eri�memiz ve �zelliklerini de�i�tirmemiz gerekebilir. Bu durumda **Property Kavram�** devreye girer. Property bir field'�n de�erini geri d�nd�rmeye(**Get**) ve yeni bir de�er(**Set**) atamaya olanak sa�lar.



�rnek bir property kullan�m� a�a��daki gibidir:


```
class Ogrenci {   
private string name; //field  
public string Name //property  
    {  
        get { return name; }  
        set{ name = value; }  
    }
}
```

Yukar�da Ogrenci s�n�f� i�erisinde "name" isminde private bir field tan�m� g�r�yorsunuz. Yani bu field'a s�n�f d���nda bir yerden eri�ilemez. Alt�ndaysa "Name" isminde "name" field'�n� geri d�nd�ren **Get metodu** ve "name" field �na yeni de�er atamas�n� yapabilen bir **Set metodu** bar�nd�ran bir property tan�m� g�r�yoruz.



Burada property tan�mlayarak "name" field'�n� s�n�f d���ndan yap�labilecek bilin�siz atamalardan koruduk. Public property nin set metodu i�erisinde bu field'a atanabilecek verileri kontrol edebilir ve m�dahale edebiliriz.



A�a��daki �rnekte ya� olarak negatif bir de�er atamas�na engel olan property tan�m�n� g�rebilirsiniz.


```
class Person {
    private int age=0;
    public int Age
    {
        get { return age; }
        set {
            if (value > 0)
            age = value;
        }
    }
}
```
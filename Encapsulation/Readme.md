# Encapsulation Kavramý ?


C#'ýn %100 nesne yönelimli bir dil olduðundan bahsetmiþtik. **Encapsulation** yani **Kapsülleme** kavramý bir özeliði baþka sýnýflardan saklamak ya da korumaktýr.



Örneðin siz bir propery yani özellik tanýmý yaptýnýz ve diðer sýnýflar içerisinden eriþilsin ama sadece okumak için eriþilsin deðeri dýþarýdan deðiþtirilemesin istiyorsunuz. Bunu kapsülleme yaparak saðlayabilirsiniz. Kapsülleme iþlemini ise property leri kullanarak yapabilirsiniz.



Kapsülleme sayesinden nesneler bilinçsiz olarak kullanýmdan korunmuþ olur. Fakat bazý durumlarda private field'lara eriþmemiz ve özelliklerini deðiþtirmemiz gerekebilir. Bu durumda **Property Kavramý** devreye girer. Property bir field'ýn deðerini geri döndürmeye(**Get**) ve yeni bir deðer(**Set**) atamaya olanak saðlar.



Örnek bir property kullanýmý aþaðýdaki gibidir:


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

Yukarýda Ogrenci sýnýfý içerisinde "name" isminde private bir field tanýmý görüyorsunuz. Yani bu field'a sýnýf dýþýnda bir yerden eriþilemez. Altýndaysa "Name" isminde "name" field'ýný geri döndüren **Get metodu** ve "name" field ýna yeni deðer atamasýný yapabilen bir **Set metodu** barýndýran bir property tanýmý görüyoruz.



Burada property tanýmlayarak "name" field'ýný sýnýf dýþýndan yapýlabilecek bilinçsiz atamalardan koruduk. Public property nin set metodu içerisinde bu field'a atanabilecek verileri kontrol edebilir ve müdahale edebiliriz.



Aþaðýdaki örnekte yaþ olarak negatif bir deðer atamasýna engel olan property tanýmýný görebilirsiniz.


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
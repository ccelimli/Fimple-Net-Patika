**Enum**
Uygulama geliþtirirken sabit deðerlerle çalýþmak durumunda kalýrýz. Bu noktalarda okunabilirliði yüksek bir program yazmak istiyorsak enum'lardan faydalanýrýz.

"enum" anahtar kelimesi enumeration yani numaralandýrma kelimesinden gelir. Sayýsal verilerý string ifadelerle saklamanýzý saðlar. Okunabilirliðe katkýsý da tam olarak burdan gelir diyebiliriz.

```
enum Gunler 
{
Pazartesi, 
Sali, 
Carsamba, 
Persembe, 
Cuma, 
Cumartesi, 
Pazar
};
```
Yukarýda Gunler enum'ýný görüyorsunuz. Enum lar default olarak 1'den baþlar.

Gunler.Pazartesi ifadesi ile Pazartesi'nin string ifadesine eriþebiliriz. Eðer Pazartesinin 1. gün oldugu bilgisine ihtiyacýmýz varsa o da þu þekildedir: (int)Gunler.Pazartesi**
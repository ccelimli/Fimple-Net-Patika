**Enum**
Uygulama geli�tirirken sabit de�erlerle �al��mak durumunda kal�r�z. Bu noktalarda okunabilirli�i y�ksek bir program yazmak istiyorsak enum'lardan faydalan�r�z.

"enum" anahtar kelimesi enumeration yani numaraland�rma kelimesinden gelir. Say�sal veriler� string ifadelerle saklaman�z� sa�lar. Okunabilirli�e katk�s� da tam olarak burdan gelir diyebiliriz.

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
Yukar�da Gunler enum'�n� g�r�yorsunuz. Enum lar default olarak 1'den ba�lar.

Gunler.Pazartesi ifadesi ile Pazartesi'nin string ifadesine eri�ebiliriz. E�er Pazartesinin 1. g�n oldugu bilgisine ihtiyac�m�z varsa o da �u �ekildedir: (int)Gunler.Pazartesi**
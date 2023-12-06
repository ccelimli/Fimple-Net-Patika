using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class DirectoryOperationManager : IDirectoryOperations
    {
        List<Person> PersonList = new List<Person>();
        public DirectoryOperationManager()
        {
            PersonList.Add(new Person("Birinci", "Kullanıcı", "01111111111"));
            PersonList.Add(new Person("İkinci", "Kullanıcı", "02222222222"));
            PersonList.Add(new Person("Üçüncü", "Kullanıcı", "03333333333"));
            PersonList.Add(new Person("Dördüncü", "Kullanıcı", "04444444444"));
            PersonList.Add(new Person("Beşinci", "Kullanıcı", "05555555555"));
        }

        public void Add()
        {
            Person person = new Person();
            try
            {
            repeat:
                Console.WriteLine("-Numara Kaydet-\n");
                Console.WriteLine("Ad: ");
                person.FirstName = Console.ReadLine();
                Console.WriteLine("Soyad: ");
                person.LastName = Console.ReadLine();
                Console.WriteLine("Telefon No: ");
                person.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Kaydedilecek kişi:\n " +
                                  "Ad: {0}", person.FirstName + "\n" +
                                  "Soyad: {0}", person.LastName + "\n" +
                                  "Telefon: {0}", person.PhoneNumber + "\n");
                Console.WriteLine("Onaylıyor musunuz?\n" + "1 - Evet\n2 - Vazgeç\n 3 - Bilgileri Düzenle");
                short Choose = Convert.ToInt16(Console.ReadLine());

                switch (Choose)
                {
                    case 1:
                        foreach (Person persons in PersonList)
                        {
                            if (persons.PhoneNumber == person.PhoneNumber)
                            {
                                Console.WriteLine("Bu numara zaten kayıtlı!");
                                break;
                            }
                        }
                        PersonList.Add(person);
                        Console.WriteLine("Ekleme Başarılı");
                        break;
                    case 2:
                        Console.WriteLine("Kayıt iptal edildi.");
                        break;
                    case 3:
                        goto repeat;
                    default:
                        Console.WriteLine("Yanlış Seçim!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete()
        {
            try
            {
            repeat:
                Console.WriteLine("Silmek istediğiniz telefon numarası: ");
                string phoneNumber = Console.ReadLine();
                bool isFound = false;

                foreach (Person item in PersonList)
                {
                    if (item.PhoneNumber == phoneNumber)
                    {
                        Console.WriteLine("{0} {1} isimli kişiyi silmek istediğinize emin misiniz?", item.FirstName, item.LastName);
                        Console.WriteLine("1 - Evet\n 2 - Hayır");
                        short isDelete = Convert.ToInt16(Console.ReadLine());
                        if (isDelete == 1)
                        {
                            PersonList.Remove(item);
                            Console.WriteLine("Başarılı");
                            isFound = true;
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("Kayıt Bulunamadı! Tekrar Denemek İster Misiniz? ");
                    Console.WriteLine("1 - Evet\n 2 - Hayır");
                    short isRepeat = Convert.ToInt16(Console.ReadLine());
                    if (isRepeat == 1)
                    {
                        goto repeat;
                    }
                    else
                    {
                        return;
                    }
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public void GetAll()
        {
            try
            {
                bool isExit = false;
                List<Person> sortedPersonList = new List<Person>();

                while (!isExit)
                {
                    Console.WriteLine("1 - A-Z'ye Listele");
                    Console.WriteLine("2 - Z-A'ya Listele");
                    Console.WriteLine("0 - Ana Menüye Dön");
                    Console.Write("Seçim: ");
                    ushort choose = Convert.ToUInt16(Console.ReadLine());

                    switch (choose)
                    {
                        case 0:
                            isExit = true;
                            break;
                        case 1:
                            sortedPersonList = PersonList.OrderBy(person => person.FirstName).ToList();
                            break;
                        case 2:
                            sortedPersonList = PersonList.OrderByDescending(person => person.FirstName).ToList();
                            break;
                        default:
                            Console.WriteLine("Hatalı seçim!");
                            break;
                    }

                    foreach (Person person in sortedPersonList)
                    {
                        Console.WriteLine($"Ad: {person.FirstName} \n" +
                                          $"Soyad: {person.LastName} \n" +
                                          $"Telefon Numarası: {person.PhoneNumber}" + "\n\n");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception : {exception.Message}");
            }
        }

        public void GetByNameOrSurname()
        {
            try
            {
            repeat:
                Console.WriteLine("1 - Ad veya soyada göre arama yap: ");
                Console.WriteLine("2 - Telefon numarasına göre arama yap: ");
                short Choose = Convert.ToInt16(Console.ReadLine());
                bool isFound = false;

                switch (Choose)
                {
                    case 1:
                        Console.Write("Aramak istediğiniz kişinin adını veya soyadını giriniz: ");
                        string personInfo = Console.ReadLine().ToLower().Trim();

                        for (int i = 0; i < PersonList.Count; i++)
                        {
                            if ((PersonList[i].FirstName.ToLower().Equals(personInfo)) || (PersonList[i].LastName.ToLower().Equals(personInfo)))
                            {
                                isFound = true;
                                Console.WriteLine($"Kayıt bulundu\n\n" +
                                    $"Kişi Adı: {PersonList[i].FirstName}\n" +
                                    $"Kişi Soyadı: {PersonList[i].LastName}\n" +
                                    $"Kişi Telefon Numarası: {PersonList[i].PhoneNumber}\n");
                            }
                        }

                        if (!isFound)
                        {
                            Console.WriteLine("Kayıt Bulunamadı! Tekrar denemek ister misiniz?");
                            Console.WriteLine("1 -  Evet \n2 -  Hayır");
                            ushort isRepeat = Convert.ToUInt16(Console.ReadLine());

                            if (isRepeat == 1)
                                goto repeat;
                            else return;
                        }
                        break;
                    case 2:
                        Console.Write("Aramak istediğiniz kişinin telefon numarasını giriniz : ");
                        string personPhoneNumber = Console.ReadLine().Trim();

                        for (int i = 0; i < PersonList.Count; i++)
                        {
                            if (PersonList[i].PhoneNumber.Equals(personPhoneNumber))
                            {
                                isFound = true;
                                Console.WriteLine($"Kayıt bulundu\n" +
                                    $"Kişi Adı: {PersonList[i].FirstName}\n" +
                                    $"Kişi Soyadı: {PersonList[i].LastName}\n" +
                                    $"Kişi Telefon Numarası: {PersonList[i].PhoneNumber}\n");
                            }
                        }

                        if (!isFound)
                        {
                            Console.WriteLine("Kayıt Bulunamadı! Tekrar denemek ister misiniz ?");
                            Console.WriteLine("1 - Evet \n2 - Hayır");
                            ushort isRepeat = Convert.ToUInt16(Console.ReadLine());

                            if (isRepeat == 1)
                                goto repeat;
                            else return;
                        }
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim!");
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception : {exception.Message}");
            }
        }

        public void Update()
        {
            try
            {
            repeat:
                Console.WriteLine("|---------------- Telefon Numarası Güncelle -----------------|");
                Console.Write("Güncellemek istediğiniz kişinin adını veya soyadını giriniz : ");
                string personInfo = Console.ReadLine().ToLower().Trim();
                bool isFound = false;

                for (int i = 0; i < PersonList.Count; i++)
                {
                    if ((PersonList[i].FirstName.ToLower().Equals(personInfo)) || (PersonList[i].LastName.ToLower().Equals(personInfo)))
                    {
                    updateRepeat:
                        Console.WriteLine($"{PersonList[i].FirstName} {PersonList[i].LastName} kişisi rehberde bulundu.");
                        Console.WriteLine("Kişinin hangi bilgisini güncellemek istiyorsunuz ?");
                        Console.WriteLine("(1) AD\n(2) SOYAD\n(3) TELEFON NUMARASI\n(4) Tüm Bilgiler\n(0) Güncellemekten Vazgeç");
                        ushort choose = Convert.ToUInt16(Console.ReadLine());
                        isFound = true;

                        switch (choose)
                        {
                            case 0:
                                return;
                            case 1:
                                Console.Write("Kişinin yeni adını girin : ");
                                string updateFirstName = Console.ReadLine();
                                PersonList[i].FirstName = updateFirstName;

                                Console.WriteLine($"Kişinin adı {PersonList[i].FirstName} olarak güncellenmiştir.");
                                break;
                            case 2:
                                Console.Write("Kişinin yeni soyadını girin : ");
                                string updateLastName = Console.ReadLine();
                                PersonList[i].LastName = updateLastName;

                                Console.WriteLine($"Kişinin soyadı {PersonList[i].LastName} olarak güncellenmiştir.");
                                break;
                            case 3:
                                Console.Write("Kişinin yeni telefon numarası girin : ");
                                string updatePhoneNumber = Console.ReadLine();
                                PersonList[i].PhoneNumber = updatePhoneNumber;

                                Console.WriteLine($"Kişinin telefon numarası {PersonList[i].PhoneNumber} olarak güncellenmiştir.");
                                break;
                            case 4:
                                Console.Write("Kişinin yeni adını girin : ");
                                string allUpdateFirstName = Console.ReadLine();

                                Console.Write("Kişinin yeni soyadını girin : ");
                                string allUpdateLastName = Console.ReadLine();

                                Console.Write("Kişinin yeni telefon numarası girin : ");
                                string allUpdatePhoneNumber = Console.ReadLine();

                                PersonList[i].FirstName = allUpdateFirstName;
                                PersonList[i].LastName = allUpdateLastName;
                                PersonList[i].PhoneNumber = allUpdatePhoneNumber;

                                Console.WriteLine($"Kayıt " +
                                    $"Ad: {PersonList[i].FirstName} " +
                                    $"Soyad: {PersonList[i].LastName} " +
                                    $"Telefon Numarası: {PersonList[i].PhoneNumber} olarak güncellenmiştir.");
                                break;
                            default:
                                Console.WriteLine("Lütfen doğru bir seçim yapınız!!!");
                                goto updateRepeat;
                        }
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine("Aradığınız kişi rehberde bulunmamaktadır.Tekrar denemek ister misiniz ?");
                    Console.WriteLine("(1) Evet \n(2) Hayır");
                    ushort isRepeat = Convert.ToUInt16(Console.ReadLine());

                    if (isRepeat == 1)
                        goto repeat;
                    else return;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception : {exception.Message}");
            }
        }
    }
}


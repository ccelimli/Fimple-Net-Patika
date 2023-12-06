using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class TelephoneDirectory
    {
        private bool isExit=false;
        IDirectoryOperations _directoryOperations;

        public TelephoneDirectory(IDirectoryOperations directoryOperations)
        {
            this._directoryOperations = directoryOperations;
        }

        public bool IsExit { get=> this.isExit; set=> this.isExit=value;}
        
        public void Start()
        {
            try
            {
                while (!IsExit)
                {
                    Console.WriteLine("1- Numara Kaydet\n" +
                                      "2- Numara Sil\n" +
                                      "3- Numara Güncelle\n" +
                                      "4- Rehberi Listele\n" +
                                      "5- Arama Yap\n" +
                                      "0- Çıkış\n"+
                                      "\nSeçim: ");

                    int choose = Convert.ToInt16(Console.ReadLine());

                    switch (choose)
                    {
                        case 0:
                            this.IsExit = true; 
                            break;
                        case 1:
                            this._directoryOperations.Add();
                            break;
                        case 2:
                            this._directoryOperations.Delete();
                            break;
                        case 3:
                            this._directoryOperations.Update();
                            break;
                        case 4:
                            this._directoryOperations.GetAll();
                            break; 
                        case 5:
                            this._directoryOperations.GetByNameOrSurname();
                            break;
                        default:
                            Console.WriteLine("Hatalı Seçim!");
                            break;
                    }
                }
            }catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}

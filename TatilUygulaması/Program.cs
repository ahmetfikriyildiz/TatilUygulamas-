using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TatilUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool anotherVacation = true;
            while (anotherVacation)
            {
                string location = "";
                int lValue = 0;
                bool validInput = false;
                int personCount = 0;
                int transportation = 0;
                string tName = "";
                int tValue = 0;

                while (!validInput)
                {
                    Console.WriteLine("Gitmek istediğiniz yerin adını seçiniz : ");
                    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
                    Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
                    Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
                    Console.Write("Seçiminiz: ");
                    location = Console.ReadLine().ToLower();

                    switch (location)
                    {
                        case "bodrum":
                            location = "Bodrum";
                            validInput = true;
                            lValue = 4000;
                            break;
                        case "marmaris":
                            location = "Marmaris";
                            validInput = true;
                            lValue = 3000;
                            break;
                        case "çeşme":
                            location = "Çeşme";
                            validInput = true;
                            lValue = 5000;
                            break;
                        default:
                            Console.WriteLine("Hatalı bir seçim yaptınız. ");
                            Console.WriteLine("Lütfen tekrar deneyiniz. ");
                            break;
                    }
                }
                validInput = false;


                Console.WriteLine("-------------------");
                while (personCount == 0)
                {
                    Console.WriteLine("Tatili kaç kişi için planlanlamak istiyorusunuz.");
                    Console.Write("Cevabınız: ");
                    personCount = Convert.ToInt32(Console.ReadLine());
                }


                Console.WriteLine("-------------------");

                while (!validInput)
                {
                    Console.WriteLine("Lütfen tatilinize nasıl gitmek istediğinizi seçiniz: ");
                    Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
                    Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
                    Console.Write("Seçiminiz: ");
                    transportation = Convert.ToInt32(Console.ReadLine());
                    switch (transportation)
                    {
                        case 1:
                            tName = "Karayolu";
                            validInput = true;
                            tValue = 1500;
                            break;
                        case 2:  
                            tName = "Havayolu";
                            validInput = true;
                            tValue = 4000;
                            break;
                        default:
                            Console.WriteLine("Hatalı bir seçim yaptınız. Lütfen 1 ya da 2 olarak seçim yapınız.");
                            break;
                    }

                }
                Console.WriteLine("-------------------");
                int toplamFiyat = lValue + (tValue * personCount);

                Console.WriteLine($"Seçtiğiniz lokasyon: {location}");
                Console.WriteLine($"Planlanan tatil için kişi sayısı: {personCount}");
                Console.WriteLine($"Seçtiğiniz ulaşım yolu: {tName}");
                Console.WriteLine($"Toplam tatil tutarı: {toplamFiyat}");
                
                Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (Evet/Hayır)");
                string anotherVacationAnswer = Console.ReadLine().ToLower();
                if (anotherVacationAnswer != "evet")
                {
                    anotherVacation = false;
                    Console.WriteLine("İyi günler!");
                }
                Console.WriteLine("-----------------------------------------------------------");                
            }
        }
    }
}

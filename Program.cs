using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;

namespace envanter_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Basit bir envanter sistemi
             * Eşyaların isimlerini saklayın
             * Oyuncuya mevcut envanteri göster
             * oyuncu eşya eklesin kaldırsın
             Ama doluyken envanter eşya ekleiyemesin çıkartsın


             * */

            //Not:Elimden geldiğince ingilizce yaptım ama kodları karıştırmamak adına
            // Yorumları Türkçe yaptım :)

            //Argüman parametresini yineledik
            foreach (var arg in args)
            {
                Console.WriteLine(arg); 
            }
           
            // Değişkenler
            
            int press;              //Envanteri gösterme
            int dv;                //Silinen Değer
            int index;            //Eleman
            int buy;             //Satın Alınan Değer
            string get;         //Silinen eşyadan sonra yerine konan eşyayı seçme
            string new_item;   // Seçilen eşya
            string vote;      //Silinecek eşyayı seçme
            int x=0;         //Bunu önceden koydum ne işe yarıyor bende blmiyorum ama silmekte istemedim :)
            int money=5000, ns=2250, bow=500, spear=4000; //Paramız ve satın alınacak eşyalar

            //Listeleme ve envanterdeki eşyalarımız için dizi oluşturduk
            List<string>capacity = new List<string>();

            //Envanterimiz
            capacity.Add("Diamond Sword");
            capacity.Add("Dirt");
            capacity.Add("Stone");
            capacity.Add("Bed");
            capacity.Add("Wood");

            Console.WriteLine("Press 1 to see inventory");

            //Srtring bir ifadeyi int'e çeviriyoruz
            press = Convert.ToInt32(Console.ReadLine());



            //Burada Envanteri gösteriyoruz
            if (press == 1)
            {
                //Dizimizdeki elemanlar veya envanterimiz
                Console.WriteLine("Inventroy: ");
                Console.WriteLine("1-" + capacity[0]);
                Console.WriteLine("2-" + capacity[1]);
                Console.WriteLine("3-" + capacity[2]);
                Console.WriteLine("4-" + capacity[3]);
                Console.WriteLine("5-" + capacity[4]);
                Console.ReadLine();




            

                Console.WriteLine("*********************************************");

                Console.WriteLine("Do you want to buy something? (Yes=1, No=0)");

                //Envanter dolu olduğu için seçim yapamaz! İsterse
                //Eşya satın alır isterse almaz

                //Alırsaki senaryo
                buy = Convert.ToInt32(Console.ReadLine()); //Srtring bir ifadeyi int'e çeviriyoruz
                if (buy == 1)
                {
                    Console.WriteLine("Throw something of inventory.");
                    Console.WriteLine("*****************************");

                    //Bu değeri okutarak switch bölmüne geçiyoruz
                    vote = Console.ReadLine();

                    //String bir ifadeyi int'e çeviriyoruz
                    dv = Convert.ToInt32(Console.ReadLine());

                    //Silinen envanterden sonra eğer bir şey almıyacaksa indeks boş kalmasın diye
                    //Hepsini sola kaydırır.
                    capacity.RemoveAt(dv);


                    //Envanter dolu bir slot silmek zorunda klavyeden rakamlara basarak seçim yap
                    switch (vote)
                    {
                        case "1":
                            Console.WriteLine("First remove at item.");
                            capacity.Remove("Diamond");
                            if (dv == 1)
                            {

                            }


                            break;
                        case "2":
                            Console.WriteLine("Second remove at item.");
                            capacity.Remove("Dirt");
                            if (dv == 2)
                            {

                            }

                            break;
                        case "3":
                            Console.WriteLine("Thrid remove at item.");
                            capacity.Remove("Stone");
                            if (dv == 3)
                            {

                            }


                            break;
                        case "4":
                            Console.WriteLine("Forth remove at item.");
                            capacity.Remove("Bed");
                            if (dv == 4)
                            {

                            }


                            break;
                        case "5":
                            Console.WriteLine("Fifth remove at item.");
                            capacity.Remove("Wood");
                            if (dv == 5)
                            {

                            }

                            break;

                        default:
                            Console.WriteLine("Please such a true chocie.");
                            break;



                    }
                    Console.WriteLine("**************************");
                    dv = Console.Read();

                    Console.ReadLine();

                    Console.WriteLine("the secction you selected has been deleted.");

                    Console.WriteLine("What do you want to buy? Your money=5000$");

                    //Hangi silahı istiyor bunu envanterinde boş olan bir indekse koyabilecek
                    Console.WriteLine("1- Nether Sword=2250$");
                    Console.WriteLine("2- Bow=500$");  //Para olayını canım istedi biraz eğlence olsun
                    Console.WriteLine("3- Sper=4000$");


                    Console.WriteLine("**************************");
                    get = Console.ReadLine();

                    //Silah seçiyor şimdide ona göre envanterine eklenicek
                    switch (get)
                    {
                        case "1":
                            Console.WriteLine("Nether Sword purchased.");

                            capacity.Insert(dv, "Nether Sword");

                            money -= ns;
                            Console.WriteLine("Your remaining money: $" + money);
                            break;

                        case "2":
                            Console.WriteLine("Bow purchased.");

                            capacity.Insert(dv, "Bow");
                            money -= bow;
                            Console.WriteLine("Your remaining money: $" + money);

                            break;
                        case "3":
                            Console.WriteLine("Spear purchased");
                            capacity.Insert(dv, "Spear");

                            money -= spear;
                            Console.WriteLine("Your remaining money: $" + money);

                            break;

                        default:
                            Console.WriteLine("Please such a true chocie.");
                            break;
                    }

                    Console.WriteLine("****************************");

                    //Burada eşyaları yineliyoruz
                    foreach (string item in capacity)
                    {
                        Console.Write(item);
                    }

                    Console.WriteLine("Update inventory: ");

                    //Yeni envanteri yazdırıyoruz
                    for (int i = 0; i <= capacity.Count; i++)
                    {
                        Console.WriteLine(i + 1 + "-" + capacity[i]);
                    }

                    Console.ReadLine();


                }

                //Hiç bir şey satın alamadı :(
                if (buy == 0)
                {
                    Console.WriteLine("Ok. :(");
                    Console.ReadLine();
                }

                //Yanlış tuşa bastığında uygulama tıkanmasın veya eksik bir şey çıkartmasın diye
                //Bir koşul daha tanımladım

                if (buy != 1 || buy != 0)
                {
                    Console.WriteLine("Ohh! Sorry there is no such choice :(");
                    Console.ReadLine();

                }
            }
           
            //Eğer gerekli tuşa basmazsa envanter göstermem
            else
            {
                Console.WriteLine("You couldn't see the inventory");
                Console.ReadLine();
            }
        }
    }
}

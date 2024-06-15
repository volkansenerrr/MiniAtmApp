using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kayıtlı Kullanıcı Bilgileri

            string kayitliSifre = "12345";
            int bakiye = 10000;

            #endregion

            Console.WriteLine("................................");
            Console.WriteLine(".                              .");
            Console.WriteLine(". Morpheus ATM'ye Hoşgeldiniz. .");
            Console.WriteLine(".                              .");
            Console.WriteLine("................................");

            Console.WriteLine(" ");

            bool kontrol1 = true;

            int girisHakki = 3;

            while (kontrol1)
            {
                Console.Write("Şifre : ");
                string gelenSifre = Console.ReadLine();



                if (gelenSifre == kayitliSifre) // Giriş bilgileri doğruysa giriş yap, değilse hata mesajı göster.
                {

                    bool kontrol2 = true;

                    while (kontrol2)
                    {
                        #region Menü

                        Console.WriteLine("................................");
                        Console.WriteLine("[1] Bakiye Görüntüle");
                        Console.WriteLine("[2] Para Çek");
                        Console.WriteLine("[3] Para Yatır");
                        Console.WriteLine("[q] Çıkış Yap");
                        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
                        Console.WriteLine("................................");
                        string islem = Console.ReadLine();

                        #endregion

                        Console.Clear();

                        #region Bakiye Görüntüle

                        if (islem == "1")
                        {
                            Console.WriteLine("======================");
                            Console.WriteLine("Bakiye : " + bakiye + " TL");
                            Console.WriteLine("======================");
                            Console.WriteLine("[1] Ana Menü");
                            Console.WriteLine("[q] Çıkış");
                            Console.WriteLine("======================");
                            islem = Console.ReadLine();

                            Console.Clear();

                            if (islem == "1")
                            {
                                continue;
                            }
                            else if (islem == "q")
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                Console.WriteLine("Hoşçakalın.");
                                kontrol1 = false;
                                kontrol2 = false;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı işlem yaptınız. Çıkış yapılıyor..");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }

                        #endregion

                        #region Para Çekme İşlemi

                        else if (islem == "2")
                        {
                            Console.WriteLine("======================");
                            Console.WriteLine("Mevcut Bakiye : " + bakiye + " TL");
                            Console.WriteLine("======================");
                            Console.Write("Çekmek istediğiniz tutarı girin : ");
                            int cekimTutari = Convert.ToInt32(Console.ReadLine());

                            if (cekimTutari <= bakiye && cekimTutari > 0)
                            {
                                Console.WriteLine("======================");
                                Console.WriteLine("Paranız hazırlanıyor..");
                                bakiye -= cekimTutari;
                                Console.WriteLine("Yeni Bakiyeniz = " + bakiye + " TL");
                                Console.WriteLine("======================");
                                Console.WriteLine("[1] Ana Menü");
                                Console.WriteLine("[q] Çıkış");
                                Console.WriteLine("======================");
                                islem = Console.ReadLine();
                                if (islem == "1")
                                {
                                    continue;
                                }
                                else if (islem == "q")
                                {
                                    Console.WriteLine("Çıkış yapılıyor..");
                                    Console.WriteLine("Hoşçakalın.");
                                    kontrol1 = false;
                                    kontrol2 = false;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı işlem, çıkış yapılıyor..");
                                    kontrol2 = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiye yetersiz!");
                                Console.WriteLine("Ana Menüye Dönülüyor...");
                                continue;
                            }
                        }

                        #endregion

                        #region Para Yatırma İşlemi

                        else if (islem == "3")
                        {
                            Console.WriteLine("======================");
                            Console.WriteLine("Mevcut Bakiye : " + bakiye + " TL");
                            Console.WriteLine("======================");
                            Console.Write("Yatırmak istediğiniz tutarı girin : ");
                            int paraYatirma = Convert.ToInt32(Console.ReadLine());
                            bakiye += paraYatirma;
                            Console.WriteLine("Yeni Bakiyeniz = " + bakiye + " TL");
                            Console.WriteLine("======================");
                            Console.WriteLine("[1] Ana Menü");
                            Console.WriteLine("[q] Çıkış");
                            Console.WriteLine("======================");
                            islem = Console.ReadLine();
                            if (islem == "1")
                            {
                                continue;
                            }
                            else if (islem == "q")
                            {
                                Console.WriteLine("Çıkış yapılıyor..");
                                kontrol1 = false;
                                kontrol2 = false;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı işlem, çıkış yapılıyor..");
                                kontrol2 = false;
                            }
                        }

                        #endregion

                        #region Çıkış Yap

                        else if (islem == "q")
                        {
                            Console.WriteLine("Hoşçakalın.");
                            kontrol1 = false;
                            kontrol2 = false;
                        }

                        #endregion

                        else
                        {
                            Console.WriteLine("Geçersiz işlem, lütfen tekrar deneyin.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Şifre hatalı. Tekrar deneyin."); // Hata mesajı

                    Console.Clear();

                    girisHakki--; // Hatalı girişte giriş hakkını 1 azalt

                    if (girisHakki == 0) // Giriş hakkı 0 olduğunda 
                    {
                        Console.WriteLine("Şifrenizi 3 kere yanlış girdiniz. Şifreniz bloke oldu. Müşteri hizmetlerini arayıp şifrenizin blokesini kaldırabilirsiniz. Hoşçakalın."); // Şifrenin bloke olması
                        kontrol1 = false;
                    }
                }
            }
        }
    }
}

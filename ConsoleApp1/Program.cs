using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int index1;
            int index2;
            int index3;
            int index4;
            int indexMessage;
            string enemyName = "";
            int enemyHp = 0;
            int enemyDamage = 0;
            int enemyAc = 0;
            int playerRoll = random.Next(1, 21);
            int playerAttackBonus = 2;
            int playerSideAttackBonus = 0;
            #region mesaj dizileri
            string[] missMessages = {
                "Havayı kestin!",
                "Silahını son anda Boşa çıkarttı!",
                "Iskaa!!",
                "Ucundan Kaçırdın!!",
                "İmkansız!? Atlatmayı başardı."
            };
            string[] hitMessagess0 ={
                "Kılıcın rakibe ulaştı!",
                "Rakibine sağlam geçirdin!!",
                "Rakibin kaçmayı denedi ama sen daha hızlısın!",
                "Üfff bu acıtmış olmalı!!",
                "Rakibin açığını yakaladın. Değerlendirmekten çekinmedin."
            };
            string[] CritMessages =
            {
                "Critical!! Rakibinin her hamlesini okuyup Kılıcını Karnına sapladın!!!",
                "Critical!! Korkudan titremeye başladı"
            };
            #endregion
            #region düşman oluşturma dizileri
            int[] levelOneEnemyAc = { 8, 9, 10 };
            int[] levelTwoEnemyAc = { 11, 12, 13, 14 };
            int[] levelThreeEnemyAc = { 15, 16, 17 };
            int[] levelOneEnemyHealth = { 60, 55, 70, 75, 65 };
            int[] levelOneEnemyDamege = { 15, 20, 25 };
            int[] levelTwoEnemyHealth = { 95, 100, 120, 110 };
            int[] levelTwoEnemyDamege = { 30, 35, 25 };
            int[] levelThreeEnemyHealth = { 150, 160, 145, 170 };
            int[] levelThreeEnemyDamege = { 40, 45, 55 };
            string[] enemyNames = { "Maximus", "Spartacus", "Ceasar", "Crixus", "Flamma", "Commodus", "Draven", "Cassius", "Varro", "Tiberius", "Brutus", "Aurelius", "Draxus", "Severus", "Karnax" };
            #endregion
            #region ekipman dizileri
            //Zırhlar
            string[] equipmentArmour =
            {
                "Gündelik Kıyafet",
                "Deri Zırh",
                "Zincir Zırh",
                "Demir Zırh",
                "Plaka Zırh"
            };
            int[] ArmourClass = { 10, 11, 13, 15, 17 };
            int[] ArmourPrice = { 0, 50, 180, 400, 750 };
            bool[] ownedArmour = { true, false, false, false, false };

            //Silahlar
            string[] equipmentWeapon =
            {
                "Körelmiş Hançer",
                "Sağlam Hançer",
                "Kullanılmış Kılıç",
                "İyi Çelik Kılıç",
                "Longsword",
                "Demircinin Şaheseri",
            };
            int[] weaponDamage = { 5, 10, 15, 25, 40, 50 };
            int[] weaponPrice = { 0, 40, 100, 250, 400, 900 };
            bool[] ownedWeapons = { true, false, false, false, false, false };
            #endregion
            int enemyLevel = 1;
            int enemyTurn = 1;
            int enemyDamagecarpan = 4;
            //Oyuncu Değerleri
            int playerHp = 100;
            int playerBaseDamage = 10;
            int weponDamage = weaponDamage[0];
            int playerDamage = playerBaseDamage + weponDamage;
            int playerGold = 50;
            int playerWins = 0;
            int playerHealthPot = 2;
            int playerAdrenaline = 50;
            int playerFocus = 20;
            int playerAc = 10;
            int playerMaxHp = 100;
            string armedWeapon = equipmentWeapon[0];
            string armedArmour = equipmentArmour[0];
            void CallEnemy()
            {
                if (enemyLevel == 1)
                {
                    index1 = random.Next(0, levelOneEnemyHealth.Length);
                    index2 = random.Next(0, levelOneEnemyDamege.Length);
                    index3 = random.Next(0, enemyNames.Length);
                    index4 = random.Next(0, levelOneEnemyAc.Length);
                    enemyName = enemyNames[index3];
                    enemyDamage = levelOneEnemyDamege[index2];
                    enemyHp = levelOneEnemyHealth[index1];
                    enemyAc = levelOneEnemyAc[index4];
                }
                else if (enemyLevel == 2)
                {
                    index1 = random.Next(0, levelTwoEnemyHealth.Length);
                    index2 = random.Next(0, levelTwoEnemyDamege.Length);
                    index3 = random.Next(0, enemyNames.Length);
                    index4 = random.Next(0, levelTwoEnemyAc.Length);
                    enemyHp = levelTwoEnemyHealth[index1];
                    enemyDamage = levelTwoEnemyDamege[index2];
                    enemyName = enemyNames[index3];
                    enemyAc = levelTwoEnemyAc[index4];
                }
                else if (enemyLevel == 3)
                {
                    index1 = random.Next(0, levelThreeEnemyHealth.Length);
                    index2 = random.Next(0, levelThreeEnemyDamege.Length);
                    index3 = random.Next(0, enemyNames.Length);
                    index4 = random.Next(0, levelThreeEnemyAc.Length);
                    enemyHp = levelThreeEnemyHealth[index1];
                    enemyDamage = levelThreeEnemyDamege[index2];
                    enemyName = enemyNames[index3];
                    enemyAc = levelThreeEnemyAc[index4];
                }
                Console.WriteLine("-------------------");
                Console.WriteLine("|Rakibin:" + enemyName + "|");
                Console.WriteLine("|Canı:" + enemyHp + "|");
                Console.WriteLine("|Hasarı:" + enemyDamage + "|");
                Console.WriteLine("|Zırh Kalitesi:" + enemyAc + "|");
                Console.WriteLine("-------------------");

            }
            void CalculeteDamage()
            {
                playerRoll = random.Next(1, 21);
                Console.WriteLine("-------------");
                Console.WriteLine("atak zarın:" + playerRoll);
                Console.WriteLine("atak bonusun:" + playerAttackBonus);
                Console.WriteLine("-------------");
                if (playerRoll == 20)
                {
                    enemyHp -= playerDamage * 2;
                    indexMessage = random.Next(0, CritMessages.Length);
                    Console.WriteLine(CritMessages[indexMessage]);
                    playerFocus -= 15;
                    playerAdrenaline -= 15;
                }
                else if (playerRoll == 1)
                {
                    Console.WriteLine("Kendi Kılıcının üstüne oturdun. Sebebini söylemek ister misin?");
                    playerHp -= playerDamage;
                }
                else if (playerRoll + playerAttackBonus + playerSideAttackBonus >= enemyAc)
                {
                    enemyHp -= (playerDamage + (playerAdrenaline / 10) + (playerFocus / 20));
                    indexMessage = random.Next(0, hitMessagess0.Length);
                    Console.WriteLine(hitMessagess0[indexMessage]);
                    playerFocus -= 5;
                    playerAdrenaline -= 5;
                }
                else
                {
                    indexMessage = random.Next(0, missMessages.Length);
                    Console.WriteLine(missMessages[indexMessage]);
                }
                if (playerAdrenaline <= 0) { playerAdrenaline = 1; }
                else if (playerAdrenaline > 100) { playerAdrenaline = 100; }
                if (playerFocus <= 0) { playerFocus = 0; }
                else if (playerFocus > 100) { playerFocus = 100; }
                playerSideAttackBonus = 0;
            }
            void Defense()
            {
                playerRoll = random.Next(1, 21);
                Console.WriteLine("================");
                Console.WriteLine("Savunma zarın:" + playerRoll);
                Console.WriteLine("================");
                if (playerRoll == 1)
                {
                    Console.WriteLine("Kılıcının üstüne oturdun sebebini sorabilir miyim?");
                    playerHp -= playerDamage;
                }
                else if (playerRoll > 1 && playerRoll < 6)
                {
                    Console.WriteLine("savunma yapıyorsun ,sanırım(?)");
                    enemyDamagecarpan = 6;
                }
                else if (playerRoll > 5 && playerRoll < 11)
                {
                    Console.WriteLine("savunma yapmayı deniyorsun ama ne fayda rakip yine de vurabiliyor!!");
                    enemyDamagecarpan = 5;
                    playerFocus += 5;
                    playerAdrenaline += 15;
                }
                else if (playerRoll > 10 && playerRoll < 20)
                {
                    Console.WriteLine("başarılı savunma!! rakibe geçit vermedin");
                    playerFocus += 15;
                    playerAdrenaline += 10;
                    enemyDamagecarpan = 0;
                }
                else
                {
                    Console.WriteLine("Kritik Başarı!!!");
                    Console.WriteLine("rakibini sersemlettin. kendi turunu boş geçecek.");
                    playerFocus += 20;
                    playerAdrenaline += 15;
                    enemyTurn -= 2;
                }
            }
            void CalculuteDamageForEnemy()
            {
                if (enemyTurn <= 0)
                {
                    Console.WriteLine("Rakibin Sersemlemeden yeni Kurtulmaya çalışıyor.");
                    enemyTurn++;
                    enemyDamagecarpan = 4;
                    playerSideAttackBonus += 2;
                    return;
                }
                playerRoll = random.Next(enemyLevel * 3, 21);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("rakibinin zarı:" + playerRoll);
                if (playerRoll == 20)
                {
                    Console.WriteLine("Kritik darbe Rakibin Çok sağlam vurdu");
                    playerHp -= enemyDamage * 2 * enemyDamagecarpan / 4;
                }
                else if (playerRoll > playerAc)
                {
                    Console.WriteLine("Rakibin sana vurdu");
                    playerHp -= enemyDamage * enemyDamagecarpan / 4;
                }
                else
                {
                    Console.WriteLine("Düşmanın sana vuramadı");

                }
                Console.WriteLine("-------------------------------------");
                enemyDamagecarpan = 4;
            }
            void inventory()
            {
                for (int i = 0; i < weaponDamage.Length; i++)
                {
                    if (ownedWeapons[i])
                    {
                        Console.WriteLine((i + 1) + ". Silah:" + equipmentWeapon[i]);
                        Console.WriteLine("Hasarı:" + weaponDamage[i]);
                        Console.WriteLine();
                    }
                }
                for (int i = 0; i < ArmourClass.Length; i++)
                {
                    if (ownedArmour[i])
                    {
                        Console.WriteLine((i + 1) + ". Zırh:" + equipmentArmour[i]);
                        Console.WriteLine("AC:" + ArmourClass[i]);
                        Console.WriteLine();
                    }
                }
            }
            void updatePlayer()
            {
                playerDamage = playerBaseDamage + weponDamage;

            }
            bool oyunDevam = true;
            bool dovusDevam = false;
            Console.WriteLine("======== Gladyatör Arenası ========");
            while (oyunDevam)
            {
                dovusDevam = true;
                enemyTurn = 1;
                bool inventorychange = true;
                playerAdrenaline = 50;
                playerFocus = 20;
                Console.WriteLine("**========|1-Arenaya Gir  |======**");
                Console.WriteLine("**|2-Ekipmanlarını  Gözden Geçir|**");
                Console.WriteLine("**========|   3-Dinlen    |======**");
                Console.WriteLine("**========|4-Demirciye Gir|======**");
                Console.WriteLine("**=====|5-Gladyatör Bilgileri|===**");
                Console.WriteLine("**========| 6-Oyundan Çık |======**");
                int secim1;
                bool success1 = int.TryParse(Console.ReadLine(), out secim1);
                if (!success1 || secim1 <= 0 || secim1 > 6)
                {
                    Console.WriteLine("Lütfen Geçerli Giriş Yapın");
                    continue;
                }
                switch (secim1)
                {
                    case 1:
                        if (playerHp <= 0)
                        {
                            Console.WriteLine("Canın yok Giremezsin git dinlen");
                            continue;
                        }
                        Console.WriteLine("Arenaya Girdin rakibin seçiliyor");
                        CallEnemy();
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Dövüşmek istiyor musun?");
                        Console.WriteLine("1-Evet");
                        Console.WriteLine("2-Hayır");
                        Console.WriteLine("-----------------------");
                        int secim2;
                        bool success2 = int.TryParse(Console.ReadLine(), out secim2);
                        if (!success2 || secim2 <= 0 || secim2 >= 3)
                        {
                            Console.WriteLine("Lütfen Geçerli Giriş Yapın");
                            continue;
                        }
                        switch (secim2)
                        {
                            case 1:
                                Console.WriteLine("DÖVÜŞÜ KABUL ETTİN!!");
                                dovusDevam = true;
                                break;
                            case 2:
                                Console.WriteLine("Dövüşten kaçıyorsun. Seyirciler seni yuhalıyor");
                                continue;
                        }
                        Console.WriteLine(enemyName + " Ve Sen birbirinize Yaklaşıyorsunuz");
                        while (dovusDevam)
                        {
                            Console.WriteLine("============================");
                            Console.WriteLine("|| Canın:" + playerHp + "/" + playerMaxHp + "|| Hasarın:" + playerDamage + "||");
                            Console.WriteLine("|| Odak:" + playerFocus + "|| Adrenalin:" + playerAdrenaline + "||");
                            Console.WriteLine("|| Ac:" + playerAc + "|| İksir Sayın:" + playerHealthPot + "||");
                            Console.WriteLine("============================");
                            Console.WriteLine("|| Düşman Canı:" + enemyHp + "|| Hasarı:" + enemyDamage + "||");
                            Console.WriteLine("============================");
                            Console.WriteLine("||1-Saldır  ||");
                            Console.WriteLine("||2-Savun   ||");
                            Console.WriteLine("||3-İksir İç||");
                            Console.WriteLine("||4-Odaklan ||");
                            Console.WriteLine("||5-Topukla ||");
                            Console.WriteLine("============================");
                            Console.WriteLine("Ne Yapmak İstiyorsun (1-5) :");
                            Console.WriteLine("============================");
                            int secim3;
                            bool success3 = int.TryParse(Console.ReadLine(), out secim3);
                            if (!success3 || secim3 <= 0 || secim3 > 5)
                            {
                                Console.WriteLine("Lütfen Geçerli Giriş Yapın");
                                continue;
                            }
                            switch (secim3)
                            {
                                case 1:
                                    Console.WriteLine("Rakibine Saldırıyorsun");
                                    CalculeteDamage();

                                    break;
                                case 2:
                                    Console.WriteLine("Defansa Yatıyorsun");
                                    Defense();
                                    break;
                                case 3:
                                    Console.WriteLine("İksir İçmeye çalışıyorsun...");
                                    if (playerHealthPot <= 0) { Console.WriteLine("iksirinin olmadığını hatırlayıp hayata devam ediyorsun"); }
                                    else
                                    {
                                        if (enemyTurn <= 0)
                                        {
                                            Console.WriteLine("Rakibinin durumundan faydalanıp iksiri gömdün.");
                                            playerHp += 30;
                                            if (playerHp >= playerMaxHp) { playerHp = playerMaxHp; }
                                            playerFocus += 15;
                                            playerAdrenaline += 10;
                                            playerHealthPot--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Rakibini tınlamayıp iksir içiyorsun.");
                                            Console.WriteLine("Rakibinin kalbi kırıldı beynini yarmaya geliyor.");
                                            playerHp += 30;
                                            if (playerHp >= playerMaxHp) { playerHp = playerMaxHp; }
                                            playerFocus += 15;
                                            playerAdrenaline += 10;
                                            enemyDamagecarpan = 6;
                                            playerHealthPot--;
                                        }
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Rakibinin Hareketlerini Okumaya Çalışıyorsun");
                                    playerRoll = random.Next(1, 3);
                                    if (playerRoll == 1)
                                    {
                                        Console.WriteLine("Seyirci Sesleri odaklanmanı engellesede Hareket düzenini görmeye başlıyorsun");
                                        playerFocus += 20;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Rakibin Harektlerini çok iyi okuyorsun,Sanki bir sonraki Hamlesini sen belirliyorsun.");
                                        playerFocus += 40;
                                        enemyDamagecarpan = 2;
                                        playerSideAttackBonus += 2;
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("Silahlarını bırakıp teslim oluyorsun.Seyirciler seni yuhalıyor.");
                                    dovusDevam = false;
                                    break;
                            }
                            if (!dovusDevam) { break; }
                            if (enemyHp <= 0)
                            {
                                Console.WriteLine("düşmanı Yendin");
                                playerWins++;
                                Console.WriteLine("ödülün altınına eklendi");
                                playerGold += random.Next(enemyLevel * 20, enemyLevel * 40);
                                break;
                            }
                            CalculuteDamageForEnemy();
                            if (playerHp <= 0)
                            {
                                Console.WriteLine("Ağır Yaralandın,Seni dışarı sürüklüyolar.Sanki birisi ceplerini karıştırıyor");
                                playerGold -= random.Next(6, 16);
                                if (playerGold <= 0) { playerGold = 0; }
                                playerHp = 0;
                                break;
                            }
                            Console.WriteLine("Canın:" + playerHp);
                            Console.WriteLine(enemyName + " Canı:" + enemyHp);
                        }
                        break;
                    case 2:
                        Console.WriteLine("=====Ekipmanlarını Gözden Geçiriyorsun=====");
                        Console.WriteLine("Zırhın:" + armedArmour);
                        Console.WriteLine("Silahın:" + armedWeapon);
                        Console.WriteLine("-------------------------------------------");
                        inventory();
                        while (inventorychange)
                        {

                            Console.WriteLine("Değişiklik Yapmak İster misiniz?");
                            Console.WriteLine("2-Hayır======*******======1-Evet");
                            int secim4;
                            bool success4 = int.TryParse(Console.ReadLine(), out secim4);
                            if (!success4 || secim4 <= 0 || secim4 > 2)
                            {
                                Console.WriteLine("Yanlış Girdin Düzgün Gir:");
                                continue;
                            }
                            switch (secim4)
                            {
                                case 1:
                                    Console.WriteLine("Tek seferde yalnızca bir zırh ve bir silah kuşanabilirsin.");
                                    Console.WriteLine("Zırhı(1) mı yoksa Silahını(2) mı değiştireceksin?");
                                    int secim5;
                                    bool success5 = int.TryParse(Console.ReadLine(), out secim5);
                                    if (!success5 || secim5 < 1 || secim5 > 2)
                                    {
                                        Console.WriteLine("hatalı giriş");
                                        continue;
                                    }
                                    switch (secim5)
                                    {
                                        case 1:
                                            Console.WriteLine("İstediğin Zırhın envanter Listesindeki Numarasını gir:");
                                            int armourChoice;
                                            bool choice = int.TryParse(Console.ReadLine(), out armourChoice);
                                            if (!choice || armourChoice - 1 >= ownedArmour.Length || armourChoice - 1 < 0)
                                            {
                                                Console.WriteLine("Hatalı Giriş");
                                                continue;
                                            }
                                            else if (!ownedArmour[armourChoice - 1]) { Console.WriteLine("Sende bu zırh yok"); }
                                            else
                                            {
                                                Console.WriteLine("Zırhın başarıyla değiştirildi");
                                                Console.WriteLine("Kuşandığın Zırhın:" + equipmentArmour[armourChoice - 1]);
                                                armedArmour = equipmentArmour[armourChoice - 1];
                                                playerAc = ArmourClass[armourChoice - 1];
                                            }
                                            break;
                                        case 2:
                                            Console.WriteLine("İsteidiğin Silahın envanter Listesindeki Numarasını gir:");
                                            int weaponChoice;
                                            bool choice1 = int.TryParse(Console.ReadLine(), out weaponChoice);
                                            if (!choice1 || weaponChoice - 1 >= ownedWeapons.Length || weaponChoice - 1 < 0)
                                            {
                                                Console.WriteLine("Hatalı Giriş");
                                                continue;
                                            }
                                            else if (!ownedWeapons[weaponChoice - 1]) { Console.WriteLine("Sende Bu silah yok"); }
                                            else
                                            {
                                                Console.WriteLine("Silahın Başarıyla değiştirildi:");
                                                Console.WriteLine("Kuşandığın Silahın:" + equipmentWeapon[weaponChoice - 1]);
                                                armedWeapon = equipmentWeapon[weaponChoice - 1];
                                                weponDamage = weaponDamage[weaponChoice - 1];
                                                updatePlayer();
                                            }
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Ana Menüye Dönüyorsun");
                                    inventorychange = false;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("===========-----DİNLENME-----==========");
                        int freeCap = playerMaxHp / 2;
                        int missingHp = playerMaxHp - playerHp;
                        int paidCost = (missingHp * enemyLevel + 7) / 8;
                        bool handa = true;
                        Console.WriteLine("Canın:" + playerHp + "/" + playerMaxHp);
                        Console.WriteLine("Dinlenmek için gidebileceğin yerler:");
                        while (handa)
                        {
                            Console.WriteLine("1-Ahır");
                            Console.WriteLine("Rahat olmasada ücretsiz. Ahırın sahibi merhametli olduğu için aldırmıyor");
                            Console.WriteLine("(maksimum canının yarısına kadar burada kalabilirsin.)");
                            Console.WriteLine("2-Han");
                            Console.WriteLine("Sıcak bir yatak,soğuk bir bira tüm dertlerini alabilir.");
                            Console.WriteLine("(Handa kalmak canını fuller. Kalmak için gereken altın:" + paidCost);
                            Console.WriteLine("Nerede kalmak istersin?(1-2)");
                            Console.WriteLine("(3-Ana Menü)");
                            int secim6;
                            bool success6 = int.TryParse(Console.ReadLine(), out secim6);
                            if (!success6 || secim6 < 1 || secim6 > 3) { Console.WriteLine("Hatalı giriş düzgün gir"); continue; }
                            switch (secim6)
                            {
                                case 1:
                                    if (playerHp >= playerMaxHp / 2) { Console.WriteLine("Zaten ahırın sana verebileceğinden iyi durumdasın"); }
                                    else
                                    {
                                        Console.WriteLine("Ahırda Kalıyorsun Yavaş yavaş iyileşiyorsun");
                                        playerHp = playerMaxHp / 2;
                                        Console.WriteLine("Canın:" + playerHp + "/" + playerMaxHp);
                                        handa = false;
                                    }
                                    break;
                                case 2:
                                    if (playerGold < paidCost) { Console.WriteLine("Paran yetmiyor"); }
                                    else if (playerHp == playerMaxHp) { Console.WriteLine("Canın full zaten Çılgın"); handa = false; }
                                    else
                                    {
                                        Console.WriteLine("Handa keyif yapıyorsun sabaha fullenirsin. hancı senden aldığı keseyle zevkten 4 köşe.");
                                        playerGold -= paidCost;
                                        playerHp = playerMaxHp;
                                        Console.WriteLine("Canın:" + playerHp + "/" + playerMaxHp);
                                        handa = false;
                                    }
                                    break;
                                case 3:
                                    handa = false;
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("=============DEMİRCİ===========");
                        bool demirci = true;
                        Console.WriteLine("----------------Fiyat Listesi----------------");
                        Console.WriteLine("-------------------Zırhlar-------------------");
                        Console.WriteLine();
                        for (int i = 1; i < ArmourClass.Length; i++)
                        {
                            if (!ownedArmour[i])
                            { Console.WriteLine(i + ". Zırh:" + equipmentArmour[i] + " || Fiyatı:" + ArmourPrice[i] + " || AC:" + ArmourClass[i]); }
                            else { Console.WriteLine("Çoktan Satın Aldın!!!"); }
                        }
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("-----------------Silahlar---------------------");
                        for (int i = 1; i < weaponPrice.Length; i++)
                        {
                            if (!ownedWeapons[i])
                            { Console.WriteLine(i + ". Silah:" + equipmentWeapon[i] + " || Fiyatı:" + weaponPrice[i] + " || Hasarı:" + weaponDamage[i]); }
                            else { Console.WriteLine("Çoktan Satın Aldın!!!"); }
                        }
                        Console.WriteLine("İksir Fiyarı:25");
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------");
                        while (demirci)
                        {
                            Console.WriteLine("Bir şey alacak mısın?");
                            Console.WriteLine("1-Zırh");
                            Console.WriteLine("2-Silah");
                            Console.WriteLine("3-İksir");
                            Console.WriteLine("4-Hayır(Ana Menü)");
                            int secim7;
                            bool success7 = int.TryParse(Console.ReadLine(), out secim7);
                            if (!success7 || secim7 < 1 || secim7 > 4)
                            {
                                Console.WriteLine("Hatalı Giriş lütfen tekrar gir");
                                continue;
                            }
                            switch (secim7)
                            {
                                case 1:
                                    Console.WriteLine("Almak İstediğin Zırhın Numarasını Gir:");
                                    int armourbuy;
                                    bool choice3 = int.TryParse(Console.ReadLine(), out armourbuy);
                                    if (armourbuy < 0 || armourbuy >= ArmourPrice.Length || !choice3) { Console.WriteLine("Hatalı Giriş!"); continue; }
                                    else if (ownedArmour[armourbuy]) { Console.WriteLine("Zaten Sende Var!!"); continue; }
                                    else if (playerGold < ArmourPrice[armourbuy])
                                    {
                                        Console.WriteLine("paran yetmiyor.");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Satın Aldın. Envanterine Eklendi");
                                        playerGold -= ArmourPrice[armourbuy];
                                        ownedArmour[armourbuy] = true;
                                    }

                                    break;
                                case 2:
                                    Console.WriteLine("Almak İstediğin Silahın Numarasını Gir:");
                                    int weaponbuy;
                                    bool choice4 = int.TryParse(Console.ReadLine(), out weaponbuy);
                                    if (weaponbuy < 0 || weaponbuy >= weaponPrice.Length || !choice4) { Console.WriteLine("Hatalı Giriş!"); continue; }
                                    else if (ownedWeapons[weaponbuy]) { Console.WriteLine("Zaten Sende Var!!"); continue; }
                                    else if (playerGold < weaponPrice[weaponbuy])
                                    {
                                        Console.WriteLine("paran yetmiyor.");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Satın Aldın. Envanterine Eklendi");
                                        playerGold -= weaponPrice[weaponbuy];
                                        ownedWeapons[weaponbuy] = true;
                                    }
                                    break;
                                case 3:
                                    if (playerGold < 25) { Console.WriteLine("paran yetmiyor..."); continue; }
                                    else { Console.WriteLine("İksir Aldın"); playerHealthPot++; playerGold -= 25; }
                                    break;
                                case 4:
                                    Console.WriteLine("Ana Menüye Dönüyorsun...");
                                    demirci = false;
                                    break;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("=============GLADYATÖR BİLGİLERİ============");
                        Console.WriteLine("Canın:" + playerHp + "/" + playerMaxHp);
                        Console.WriteLine("Hasarın:" + playerDamage + "|| Ac:" + playerAc);
                        Console.WriteLine("Kuşanılan Zırh:" + armedArmour + " || Kuşanılan Silah:" + armedWeapon);
                        Console.WriteLine("Altının" + playerGold);
                        Console.WriteLine("İksir Sayın:" + playerHealthPot);
                        Console.WriteLine("Galibiyetlerin:" + playerWins);
                        Console.WriteLine("!!!Galibiyet sayın onu geçtiğinde 2. level, 20 yi geçtiğinde 3. level düşmanlarla karşılaşacaksın!!!");
                        Console.WriteLine("Düşman Seviyesi:" + enemyLevel);
                        break;
                    case 6:
                        Console.WriteLine("Oyundan Ayrılıyorsun...");
                        oyunDevam = false;
                        break;
                }
                if (!oyunDevam) { break; }
                if (playerWins > 20)
                {
                    enemyLevel = 3;
                }
                else if (playerWins > 10)
                {
                    enemyLevel = 2;
                }
                else if (playerWins > 0)
                {
                    enemyLevel = 1;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Space_Mission_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region oyun ismi
            Console.OutputEncoding = System.Text.Encoding.UTF8; // çıktı kodlamasını UTF-8 yapar. çünkü ASCII de bazı özel karakterler yazdırılamaz
            try// burda her bilgisayarda çalışması için ekran boyutlarını ayarlıyoruz
            {
                if (Console.WindowWidth < 100) Console.WindowWidth = 100;
                if (Console.WindowHeight < 35) Console.WindowHeight = 35;
            }
            catch { }

            Console.CursorVisible = false;//imleci gizlemek
            Console.ForegroundColor = ConsoleColor.Cyan;

            //burda dizi kullanamadığımız için her satırı string olarak kaydediyouz
            string s0 = @"  ____  ____   _     ____ _____ ";
            string s1 = @" / ___||  _ \ / \   / ___| ____|";
            string s2 = @" \___ \| |_) / _ \ | |   |  _|  ";
            string s3 = @"  ___) |  __/ ___ \| |___| |___ ";
            string s4 = @" |____/|_| /_/   \_\\____|_____|";
            string m0 = @"  __  __ ___ ____ ____ ___ ___  _   _ ";
            string m1 = @" |  \/  |_ _/ ___/ ___|_ _/ _ \| \ | |";
            string m2 = @" | |\/| || |\___ \___ \| | | | |  \| |";
            string m3 = @" | |  | || | ___) |__) | | |_| | |\  |";
            string m4 = @" |_|  |_|___|____/____/|__\___/|_| \_|";
            string sim0 = @"  ____ ___ __  __ _   _ _        _  _____ ___  ____  ";
            string sim1 = @" / ___|_ _|  \/  | | | | |      / \ _   _/ _ \|  _ \ ";
            string sim2 = @" \___ \| || |\/| | | | | |     / _ \ | || | | | |_) |";
            string sim3 = @"  ___) | || |  | | |_| | |___ / ___ \| || |_| |  _ < ";
            string sim4 = @" |____/___|_|  |_|\___/|_____/_/   \_\_| \___/|_| \_\";

            int yaziX = 4;// sütun tanımladım

            //yazının yavaş yavaş yazılmasını sağlamak için thread sleep kullandım
            Console.SetCursorPosition(yaziX, 2); Console.Write(s0); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 3); Console.Write(s1); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 4); Console.Write(s2); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 5); Console.Write(s3); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 6); Console.Write(s4); Thread.Sleep(200);
            Console.SetCursorPosition(yaziX, 8); Console.Write(m0); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 9); Console.Write(m1); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 10); Console.Write(m2); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 11); Console.Write(m3); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 12); Console.Write(m4); Thread.Sleep(200);
            Console.SetCursorPosition(yaziX, 14); Console.Write(sim0); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 15); Console.Write(sim1); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 16); Console.Write(sim2); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 17); Console.Write(sim3); Thread.Sleep(100);
            Console.SetCursorPosition(yaziX, 18); Console.Write(sim4); Thread.Sleep(500);

            //roketin satırlarını string olarak kaydettim
            string r0 = "     /\\     ";
            string r1 = "    /  \\    ";
            string r2 = "   /====\\   ";
            string r3 = "  //|==|\\\\  ";
            string r4 = " // |==| \\\\ ";
            string r5 = " || |==| || ";
            string r6 = " || |==| || ";
            string r7 = " \\\\ \\==/ // ";
            string r8 = "  \\\\====//  ";
            string r9 = "   /====\\   ";
            string r10 = "  // || \\\\  ";
            string r11 = " //  ||  \\\\ ";
            string r12 = "   (::::)   ";
            string r13 = "  ((::::))  ";
            string r14 = "  (( :: ))  ";
            string r15 = "  (( :: ))  ";
            string r16 = "   (  : )   ";
            string r17 = "    '  '    ";

            string silgi = "            ";//roket her yukarı kaydığında altında bunu ekliyoruz
            int roketX = 72; //hangi sütunda kaycak onu belirledim

            //roketi yavaş yavaş yüksetmek için dögü kullandım 15 hamlede çıkış tamalanıyor
            for (int y = 15; y >= 0; y--)
            {

                Console.SetCursorPosition(roketX, y + 0); Console.Write(r0);
                Console.SetCursorPosition(roketX, y + 1); Console.Write(r1);
                Console.SetCursorPosition(roketX, y + 2); Console.Write(r2);
                Console.SetCursorPosition(roketX, y + 3); Console.Write(r3);
                Console.SetCursorPosition(roketX, y + 4); Console.Write(r4);
                Console.SetCursorPosition(roketX, y + 5); Console.Write(r5);
                Console.SetCursorPosition(roketX, y + 6); Console.Write(r6);
                Console.SetCursorPosition(roketX, y + 7); Console.Write(r7);
                Console.SetCursorPosition(roketX, y + 8); Console.Write(r8);
                Console.SetCursorPosition(roketX, y + 9); Console.Write(r9);
                Console.SetCursorPosition(roketX, y + 10); Console.Write(r10);
                Console.SetCursorPosition(roketX, y + 11); Console.Write(r11);
                Console.SetCursorPosition(roketX, y + 12); Console.Write(r12);
                Console.SetCursorPosition(roketX, y + 13); Console.Write(r13);
                Console.SetCursorPosition(roketX, y + 14); Console.Write(r14);
                Console.SetCursorPosition(roketX, y + 15); Console.Write(r15);
                Console.SetCursorPosition(roketX, y + 16); Console.Write(r16);
                Console.SetCursorPosition(roketX, y + 17); Console.Write(r17);
                

                Thread.Sleep(150); // Yükselme hızı

                // roket 18 satır bu dögü her satırı tke tek boşluk yapar
                for (int k = 0; k < 18; k++)
                {
                    Console.SetCursorPosition(roketX, y + k);
                    Console.Write(silgi);
                }
            }

            //consolu temizledim
            Thread.Sleep(300);
            Console.Clear();
            Console.ResetColor();
            Console.CursorVisible = true;//imleci geri getirdim

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("========================================");
            Console.WriteLine("       ROKET FIRLATILDI! OYUN BAŞLADI   ");
            Console.WriteLine("========================================");
            Console.ResetColor();
            #endregion

            Console.ForegroundColor = ConsoleColor.Cyan;
            int day = 1;
            string currentLocation = "Space Station";
            int creadits = 100;
            int fuel = 60;
            int oxygen = 70;
            int energy = 65;
            int health = 100;
            int missionScore = 0;
            int inventory = 0;
            int successfulOperation = 0;
            bool mercuryExplore = false, marsExplore = false, europaExplore = false;
            int sellect=0;
            while (sellect !=6)
            {
                Console.WriteLine();
                Console.Write("Day: ");
                Console.WriteLine(day);
                Console.Write("Current Location: ");
                Console.WriteLine(currentLocation);
                Console.Write("Creadits: ");
                Console.WriteLine(creadits + " C");
                Console.Write("Fuel: ");
                Console.WriteLine(fuel + "/100");
                Console.Write("Oxygen: ");
                Console.WriteLine(oxygen + "/100");
                Console.Write("Energy: ");
                Console.WriteLine(energy + "/100");
                Console.Write("Health: ");
                Console.WriteLine(health + "/100");
                Console.Write("Mission Score: ");
                Console.WriteLine(missionScore);
                Console.Write("Inventory: ");
                Console.WriteLine(inventory + " Minerals");
                Console.WriteLine();
                Console.WriteLine("1. Travel to a Planet ");
                Console.WriteLine("2. Explore to Planet ");
                Console.WriteLine("3. Collect Minerals ");
                Console.WriteLine("4. Supply Station ");
                Console.WriteLine("5. Display Mission Status ");
                Console.WriteLine("6. End of the Day ");
                Console.WriteLine("7. Quit Mission ");
                Console.WriteLine();

                Console.Write("Enter Your Choice: ");
                string sellecta = (Console.ReadLine());
                int.TryParse(sellecta, out sellect);
                Console.WriteLine();
                while (sellect < 1 || sellect > 7)
                {
                    Console.Write("Invaild input! Enter Your Choice (1-7): ");
                    sellecta = Console.ReadLine();
                    int.TryParse(sellecta, out sellect);
                }

                switch (sellect)
                {
                    case 1:
                        bool travelCompleted = false;

                        while (!travelCompleted)
                        {
                            Console.Write("Select destination (1: Mercury, 2: Mars, 3: Europa): ");
                            string placeInput = Console.ReadLine();
                            int.TryParse(placeInput, out int place);

                            while (place < 1 || place > 3)
                            {
                                Console.Write("Invalid input! Please select destination (1: Mercury, 2: Mars, 3: Europa): ");
                                placeInput = Console.ReadLine();
                                int.TryParse(placeInput, out place);
                            }

                            switch (place)
                            {
                                case 1:
                                    if (currentLocation == "Mercury")
                                    {
                                        Console.WriteLine("You are already in this location. Please again input.");
                                        break;
                                    }
                                    if (fuel < 10)
                                    {
                                        Console.WriteLine($"You doesn't enough fule. You need {10 - fuel} fuel.");
                                        break;
                                    }
                                    if (oxygen < 8)
                                    {
                                        Console.WriteLine($"You doesn't enough oxygen. You need {8 - oxygen} oxygen.");
                                        break;
                                    }
                                    fuel -= 10;
                                    oxygen -= 8;
                                    currentLocation = "Mercury";
                                    Console.WriteLine("Travel successful! Welcome to Mercury.");
                                    Console.WriteLine($"Fuel consumed: 10. Remaining: {fuel}");
                                    Console.WriteLine($"Oxygen consumed: 8. Remaining: {oxygen}");
                                    travelCompleted = true;
                                    break;

                                case 2:
                                    if (currentLocation == "Mars")
                                    {
                                        Console.WriteLine("You are already in this location. Please again input.");
                                        break;
                                    }
                                    if (fuel < 15)
                                    {
                                        Console.WriteLine($"You doesn't enough fule. You need {15 - fuel} fuel.");
                                        break;
                                    }
                                    if (oxygen < 12)
                                    {
                                        Console.WriteLine($"You doesn't enough oxygen. You need {12 - oxygen} oxygen.");
                                        break;
                                    }
                                    fuel -= 15;
                                    oxygen -= 12;
                                    currentLocation = "Mars";
                                    Console.WriteLine("Travel successful! Welcome to Mars.");
                                    Console.WriteLine($"Fuel consumed: 15. Remaining: {fuel}");
                                    Console.WriteLine($"Oxygen consumed: 12. Remaining: {oxygen}");
                                    travelCompleted = true;
                                    break;

                                case 3:
                                    if (mercuryExplore && marsExplore && inventory >= 4)
                                    {
                                        if (currentLocation == "Europa")
                                        {
                                            Console.WriteLine("You are already in this location. Please again input.");
                                            break;
                                        }
                                        if (fuel < 20)
                                        {
                                            Console.WriteLine($"You doesn't enough fule. You need {20 - fuel} fuel.");
                                            break;
                                        }
                                        if (oxygen < 16)
                                        {
                                            Console.WriteLine($"You doesn't enough oxygen. You need {16 - oxygen} oxygen.");
                                            break;
                                        }
                                        fuel -= 20;
                                        oxygen -= 16;
                                        currentLocation = "Europa";
                                        Console.WriteLine("Travel successful! Welcome to Europa.");
                                        Console.WriteLine($"Fuel consumed: 20. Remaining: {fuel}");
                                        Console.WriteLine($"Oxygen consumed: 16. Remaining: {oxygen}");
                                        travelCompleted = true;
                                    }
                                    else
                                    {
                                        int neededMinerals = Math.Max(0, 4 - inventory);

                                        if (!mercuryExplore && !marsExplore)
                                        {
                                            Console.WriteLine($"You can't travel Europa. You need to explore Mercury and Mars first, and collect {neededMinerals} more minerals.");
                                        }
                                        else if (!mercuryExplore)
                                        {
                                            Console.WriteLine($"You can't travel Europa. You need to explore Mercury first, and collect {neededMinerals} more minerals.");
                                        }
                                        else if (!marsExplore)
                                        {
                                            Console.WriteLine($"You can't travel Europa. You need to explore Mars first, and collect {neededMinerals} more minerals.");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You can't travel Europa. You need {neededMinerals} more minerals.");
                                        }
                                        Console.WriteLine();
                                    }
                                    break;
                            }
                        }
                        break;

                    case 2:
                        if (currentLocation == "Mercury")
                        {
                            if (mercuryExplore)
                            {
                                Console.WriteLine($"You already explored {currentLocation}!");
                                break;
                            }
                            if (health < 31)
                            {
                                Console.WriteLine($"You doesn't enough health. You need {31 - health} health.");
                                break;
                            }
                            if (energy < 12)
                            {
                                Console.WriteLine($"You doesn't enough energy. You need {8 - energy} energy.");
                            }

                            mercuryExplore = true;
                            energy -= 12;
                            missionScore += 10;
                            health -= 5;
                            creadits += 15;
                            successfulOperation++;
                            Console.WriteLine($"Exploration successful! You explored {currentLocation}.");
                            Console.WriteLine($"Energy consumed 12. Reamaining {energy}");
                            Console.WriteLine($"Space Shift Health lost 5. Reamaining {health}");
                            Console.WriteLine($"Earned 15 Credits and 10 Points.");
                            Console.WriteLine($"Current successful field operations: {successfulOperation}.");
                        }
                        else if (currentLocation == "Mars")
                        {
                            if (marsExplore)
                            {
                                Console.WriteLine($"You already explored {currentLocation}!");
                                break;
                            }
                            if (health < 50)
                            {
                                Console.WriteLine($"You doesn't enough health. You need {50 - health} health.");
                                break;
                            }
                            if (energy < 18)
                            {
                                Console.WriteLine($"You doesn't enough energy. You need {18 - energy} energy.");
                            }
                            marsExplore = true;
                            energy -= 18;
                            missionScore += 20;
                            health -= 10;
                            creadits += 25;
                            successfulOperation++;
                            Console.WriteLine($"Exploration successful! You explored {currentLocation}.");
                        }
                        else if (currentLocation == "Europa")
                        {
                            if (europaExplore)
                            {
                                Console.WriteLine($"You already explored {currentLocation}!");
                                break;
                            }
                            if (health < 60)
                            {
                                Console.WriteLine($"You doesn't enough health. You need {31 - health} health.");
                                break;
                            }
                            if (energy < 25)
                            {
                                Console.WriteLine($"You doesn't enough energy. You need {25 - energy} energy.");
                            }
                            europaExplore = true;
                            energy -= 25;
                            missionScore += 30;
                            health -= 15;
                            creadits += 40;
                            successfulOperation++;
                            Console.WriteLine($"Exploration successful! You explored {currentLocation}.");
                        }
                        else
                        {
                            // Oyuncu hala Space Station'daysa
                            Console.WriteLine("You are at the Space Station! Travel to a planet first to explore.");
                        }
                        break;

                    case 3:
                        if(currentLocation=="Mercury")
                        {
                            energy -= 8;
                            successfulOperation++;
                            inventory += 2;
                            Console.WriteLine("Mineral collection successful!");
                            Console.WriteLine($"Energy consumed: 8. Remaining: {energy} ");
                            Console.WriteLine($"Collected 2 minerals from Mercury.");
                            Console.WriteLine($"Current successful field operations: {successfulOperation}");
                            break;

                        }
                        if(currentLocation=="Mars")
                        {
                            energy -= 8;
                            successfulOperation++;
                            inventory += 2;
                            Console.WriteLine("Mineral collection successful!");
                            Console.WriteLine($"Energy consumed: 8. Remaining: {energy} ");
                            Console.WriteLine($"Collected 2 minerals from Mercury.");
                            Console.WriteLine($"Current successful field operations: {successfulOperation}");
                            break;

                        }
                        if(currentLocation=="Europe")
                        {
                            energy -= 8;
                            successfulOperation++;
                            inventory += 2;
                            Console.WriteLine("Mineral collection successful!");
                            Console.WriteLine($"Energy consumed: 8. Remaining: {energy} ");
                            Console.WriteLine($"Collected 2 minerals from Mercury.");
                            Console.WriteLine($"Current successful field operations: {successfulOperation}");
                            break;

                        }
                        break;

                    case 4:
                        Console.WriteLine("--- SUPPLY STATION --- ");
                        Console.WriteLine("1. Buy Fuel (5 fuel for 12 C) ");
                        Console.WriteLine("2. Buy Oxygen (5 oxygen for 10 C) ");
                        Console.WriteLine("3. Recharge Energy (20 energy for 10 C) ");
                        Console.WriteLine("4. Repair Spaceship (20 health for 15 C) ");
                        Console.WriteLine("5. Sell All Minerals (6 C per mineral) ");
                        Console.WriteLine("6. Return to Main Menu ");
                        int supplySellect=0;
                        while (supplySellect != 6)
                        {

                            Console.Write("Enter your choice: ");
                            string supplySellecta = Console.ReadLine();
                            int.TryParse(supplySellecta, out supplySellect);
                            Console.WriteLine();
                            if (supplySellect == 5)
                            {
                                Console.WriteLine($"{inventory} minerals for {inventory * 6} C.");
                                creadits = creadits + (inventory * 6);
                                Console.WriteLine($"Current credits: {creadits}");
                                Console.WriteLine();
                            }
                            if (supplySellect == 1)
                            {
                                Console.WriteLine($"Purchased 5 Fuel.");
                                fuel = fuel + 5;
                                creadits -= 12;
                                Console.WriteLine($"Current credits: {creadits} C. Currrent fuel: {fuel}.");
                                Console.WriteLine();
                            }
                            if (supplySellect == 2)
                            {
                                Console.WriteLine($"Purchased 5 Oxygen.");
                                oxygen = oxygen + 5;
                                creadits -= 10;
                                Console.WriteLine($"Current credits: {creadits} C. Currrent oxygen: {oxygen}.");
                                Console.WriteLine();
                            }
                            if (supplySellect == 3)
                            {
                                Console.WriteLine($"Purchased 20 Oxygen.");
                                energy = energy + 20;
                                creadits -= 10;
                                Console.WriteLine($"Current credits: {creadits} C. Currrent energy: {energy}.");
                                Console.WriteLine();
                            }
                            if (supplySellect == 4)
                            {
                                Console.WriteLine($"Purchased 20 health.");
                                health = health + 20;
                                creadits -= 15;
                                Console.WriteLine($"Current credits: {creadits} C. Currrent health: {health}.");
                                Console.WriteLine();
                            }
                        }

                        break;



                }
            }

            Console.Read();
        }

    }
}

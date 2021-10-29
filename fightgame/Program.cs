using System;
using System.Collections.Generic;
using System.Linq;


namespace fightgame
{
    class Program
    {
        private static Random _rnd = new Random();

        static void Main(string[] args)
        {
            int charhp = 100;
            int sworddmg = 30;
            Console.WriteLine("Welcome to my game. Prepare to be amazed :)");
            Console.WriteLine("do you want to figt or read rules? to fight type f for rules type r");
            string first = Console.ReadLine();

            var level2 = new List<Mob>();
            level2.Add(new Mob(150));
            level2.Add(new Mob(170));
            level2.Add(new Mob(200));

            var mobs = new List<Mob>();
            mobs.Add(new Mob(100));
            mobs.Add(new Mob(120));
            int killCount = 0;
            if (first == "r")
            {
                Console.WriteLine("The rules are simple you will play as an old warrior going to save the world from the enemy! So there is no rules");
                Console.WriteLine("Watch out for magical mobs you will understand why");
                Console.WriteLine("Good job");

            }
            else if (first == "f")
            {
                var isLvl2 = true;
                bool isRunning = true;
                Console.WriteLine("Alright you want to fight you are a brave man");
                Console.WriteLine("You only have 100hp and a sword that makes 30dmg per hit watch out so that you dont miss");
                Console.WriteLine("Since this is your first battle you will attack first");
                Mob mob = mobs.FirstOrDefault();
                while (isRunning)
                {

                    int hit = _rnd.Next(0, 99);
                    if (hit < 50)
                    {
                        mob.Health = mob.Health - sworddmg;
                        Console.WriteLine("you hit the enemy good job the mob only has " + mob.Health + " hp left");
                    }
                    else
                    {
                        Console.WriteLine("you missed thats too bad hope he wont hit you now you have " + charhp + " hp left");
                        charhp = charhp - 20;

                    }
                    if (charhp == 0)
                    {
                        Console.WriteLine("You died!");
                        break;
                        Console.ReadLine();
                    }

                    if (mob.Health <= 0)
                    {
                        killCount++;
                        mobs.Remove(mob);
                        Console.WriteLine("Good job you have killed " + killCount + " enemy! Your sword is now more powefull than ever");
                        sworddmg = sworddmg + 10;
                        mob = mobs.FirstOrDefault();
                        if (mob != null)
                        {
                            Console.WriteLine("A new mob came to backstab you when he smelled the blood of his friend! He has " + mob.Health + " hp");
                            sworddmg = sworddmg + 10;
                        }
                        else
                        {
                            Console.WriteLine("You have killed all the mobs!");

                        }
                        while (isLvl2)
                        {
                            if (charhp <= 1)
                            {
                                var mobs2 = new List<Mob>();
                                Mob lvl2 = mobs2.FirstOrDefault();
                                mobs2.Add(new Mob(150));
                                mobs2.Add(new Mob(170));
                                mobs2.Add(new Mob(200));

                            }
                        }
                    }

                    string end = Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine("Good job level one complete!");
                Console.ReadLine();
            }
        }
    }
}
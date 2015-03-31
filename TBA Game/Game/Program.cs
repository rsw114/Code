using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player user = new Player(); //create player character
            Monster dragon = new Monster(); //create new dragon
            Monster drake = new Monster(); //create new drake

            Potions health = new Potions("health", 3);
            Potions strength = new Potions("strength", 3);
            Potions wisdom = new Potions("wisdom", 3);
            Potions food = new Potions("food", 3);

            Weapons Fiery = new Weapons("Firery Greatsword", false);
            Weapons Silver = new Weapons("Silver Broadsword", false);
            Weapons Wooden = new Weapons("Wooden Sword", false);

            Console.WriteLine("What is your character's name?");
            user.Name = Console.ReadLine();

            bool def = false; // error handling
            string choice;
            //user chooses difficulty
            do
            {
                Console.WriteLine("Please choose your difficulty.");
                Console.WriteLine("Your choices are easy, medium or hard");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "easy":
                        {
                            user.Strength = 20;
                            user.Wisdom = 20;
                            user.Health = 100;
                            user.Hunger = 0;
                            user.Score = 0;

                            dragon.Name = "Dragon";
                            dragon.Strength = 8;
                            dragon.Wisdom = 8;
                            dragon.Health = 50;

                            drake.Name = "Drake";
                            drake.Strength = 3;
                            drake.Wisdom = 3;
                            drake.Health = 20;

                            def = false;
                            break;
                        }

                    case "medium":
                        {
                            user.Strength = 15;
                            user.Wisdom = 15;
                            user.Health = 75;
                            user.Hunger = 20;
                            user.Score = 0;

                            dragon.Name = "Dragon";
                            dragon.Strength = 15;
                            dragon.Wisdom = 15;
                            dragon.Health = 75;

                            drake.Name = "Drake";
                            drake.Strength = 4;
                            drake.Wisdom = 4;
                            drake.Health = 25;

                            def = false;
                            break;
                        }

                    case "hard":
                        {
                            user.Strength = 8;
                            user.Wisdom = 8;
                            user.Health = 50;
                            user.Hunger = 30;
                            user.Score = 0;

                            dragon.Name = "Dragon";
                            dragon.Strength = 20;
                            dragon.Wisdom = 20;
                            dragon.Health = 100;

                            drake.Name = "Drake";
                            drake.Strength = 5;
                            drake.Wisdom = 5;
                            drake.Health = 30;

                            def = false;
                            break;
                        }

                    default: //incorrect entry for difficulty
                        {
                            Console.WriteLine("Invalid");
                            def = true;
                            break;
                        }
                }
            }
            while (def == true);


            Console.WriteLine("Welcome to the maze");
            room1(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
            Console.ReadLine();
        }

        public static void room1(Player user, Monster dragon, Monster drake, Potions health, Potions strength, Potions wisdom,
           Potions food, Weapons Fiery, Weapons Silver, Weapons Wooden)
        {
            
            Console.WriteLine("This room has 2 doors, North or West");
            Console.WriteLine("The room may also have potions and weapons for you to discover so be sure to search carefully.");
            Console.WriteLine("Oh, and be wary of monsters, we wouldn't want you to get hurt.......");
            Console.ReadLine();


            string choice;
            bool done = false;
            do
            {
                Console.WriteLine("You can move around the room (go: forward, backward, left or right) or just go into another room (go: North or West)");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "go backward":
                        {
                            Console.WriteLine("You trip over an uneven floorboard, lose one health");
                            user.Health = user.Health - 1;
                            Console.WriteLine("Your health is now " + user.Health);
                            Console.WriteLine("Be more careful next time and maybe that won't happen, remember your surroundings");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go forward":
                        {
                            Console.WriteLine("You find a wardrobe");
                            Console.WriteLine("What do you do? Leave or Open?");
                            choice = Console.ReadLine();

                            if (choice == "Leave ")
                            {
                                done = false;
                            }
                            if (choice == "Open")
                            {
                                Console.WriteLine("You find some dusty moth bitten clothes that aren't much use to anyone");
                                done = false;
                                Console.ReadLine();
                            }
                            break;
                        }
                    case "go right":
                        {
                            Console.WriteLine("You find a cupboard built into the wall");
                            Console.WriteLine("What do you do? Leave or Open?");
                            choice = Console.ReadLine();

                            if (choice == "Leave")
                            {
                                Console.WriteLine("Fine it's your choice but don't go crying if anything happens");
                                done = false;
                            }
                            if (choice == "Open")
                            {
                                Console.WriteLine("You have found a small mahogany wooden box.");
                                Console.WriteLine("Inside you find a vial, the lable reads 'hunger potion'");
                                Console.WriteLine("You can either Store or Use the potion");
                                choice = Console.ReadLine();

                                if (choice == "Store")
                                {
                                    Console.WriteLine("Your potion is now in inventory");
                                    food.PAmount = food.PAmount + 1;
                                    Console.WriteLine("You now have " + food.PAmount + " hunger potions");
                                    done = false;
                                    Console.ReadLine();
                                }
                                if (choice == "Use")
                                {
                                    Console.WriteLine("The potion stats have been added to your stats");
                                    UsePotion(user, food);
                                    done = false;
                                    Console.ReadLine();
                                }
                            }
                            break;
                        }
                    case "go left":
                        {
                            Console.WriteLine("You find a pile of dust with a leather pair of boots beside it, what could this mean?.....");
                            done = false;
                            Console.ReadLine();
                            break;
                        }


                    case "go North":
                        {
                            Console.WriteLine("You have gone North and have entered another room");
                            Console.ReadLine();
                            room2(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }


                    case "go West":
                        {
                            Console.WriteLine("You have gone West");
                            Console.ReadLine();
                            room3(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }

                    case "go East":
                        {
                            Console.WriteLine("You get mauled by a bear, and die a horrible death, maybe that'll teach you to listen to instructions");
                            Console.WriteLine("Your adventure ends here, as the bear's lunch.");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                        }

                    case "go South":
                        {
                            Console.WriteLine("You cannot get out of the maze");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go North-West":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go North-East":
                        {
                            Console.WriteLine("You cannot go this way, try a different direction");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go South-East":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go South-West":
                        {
                            Console.WriteLine("You cannot go this way, the ways you are able to go have been specified to you already");
                            done = false;
                            Console.ReadLine();
                            break;
                        }

                }
            }
            while (done == false);


        }
        public static void room2(Player user, Monster dragon, Monster drake, Potions health, Potions strength, Potions wisdom,
            Potions food, Weapons Fiery, Weapons Silver, Weapons Wooden)
        {
            user.Hunger = user.Hunger + 10;
            Console.WriteLine("Your hunger is now " + user.Hunger);
            if (user.Hunger >= 100)
            {
                Console.WriteLine("You forgot to eat didn't you?");
                Console.WriteLine("You fall to your knees at the brink of death.");
                Console.WriteLine("Soon enough you will be food for the rats, they know you need to eat to live.");
                Console.WriteLine("Thus ends your adventure.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("This room has 4 doors, North-West, West, South-West or South");
            Console.WriteLine("The room may also have potions and weapons for you to discover so be sure to search carefully.");
            Console.WriteLine("And don't forget about the monsters....");
            Console.ReadLine();


            string choice;
            bool done = false;
            do
            {
                Console.WriteLine("You can move around the room (go: forward, backward, left or right) or just go into another room (go: North-West, West, South-West or South)");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "go backward":
                        {
                            Console.WriteLine("You find a dusty skeleton holding an old glass conical flask with a green liquid inside");
                            Console.WriteLine("What do you choose to do, Drink or Store?");
                            choice = Console.ReadLine();

                            if (choice == "Drink")
                            {
                                Console.WriteLine("You have chosen to drink the green liquid, a wise choice. You down the green liquid, increasing your strength by 1");
                                UsePotion(user, strength);
                                done = false;
                                Console.ReadLine();
                            }
                            if (choice == "Leave")
                            {
                                Console.WriteLine("You have chosen to Store it");
                                Console.WriteLine("The potion is now in your inventory");
                                strength.PAmount = strength.PAmount + 1;
                                Console.WriteLine("You now have " + strength.PAmount + " strength potions");
                                done = false;
                                Console.ReadLine();
                            }
                            break;
                        }
                    case "go forward":
                        {
                            Console.WriteLine("You find a dusty wooden trunk, with locks that have rusted away");
                            Console.WriteLine("What do you do? Leave or Open ?");
                            choice = Console.ReadLine();

                            if (choice == "Leave")
                            {
                                done = false;
                            }
                            if (choice == "Open")
                            {
                                Console.WriteLine("You find a wooden training sword");
                                Wooden.Got = true;
                                choice = Console.ReadLine();
                                
                            }
                            break;
                        }
                    case "go right":
                        {
                            Console.WriteLine("You find a cupboard built into the wall");
                            Console.WriteLine("What do you do? Leave or Open?");
                            choice = Console.ReadLine();

                            if (choice == "Leave it")
                            {
                                done = false;
                            }
                            if (choice == "Open it")
                            {
                                Console.WriteLine("You have found a small flask with the lable 'Wisdom' printed on the side.");
                                Console.WriteLine("You can either Store or Use the potion");
                                choice = Console.ReadLine();

                                if (choice == "Store")
                                {
                                    Console.WriteLine("Your potion is now in inventory");
                                    wisdom.PAmount = wisdom.PAmount + 1;
                                    done = false;
                                    Console.ReadLine();
                                }
                                if (choice == "Use")
                                {
                                    Console.WriteLine("The potion stats have been added to your stats");
                                    UsePotion(user, wisdom);
                                    done = false;
                                    Console.ReadLine();
                                }
                            }
                            break;
                        }
                    case "go left":
                        {
                            Console.WriteLine("You find a ham and cheese sandwich, mmmmmm");
                            Console.WriteLine("You can either Store or Eat the sandwich");
                            choice = Console.ReadLine();

                            if (choice == "Store")
                            {
                                Console.WriteLine("You have stored your sandwich");
                                food.PAmount = food.PAmount + 1;
                                done = false;
                                Console.ReadLine();
                            }
                            if (choice == "Eat")
                            {
                                Console.WriteLine("Well done young traveller, a wise choice, you consume your sandwich and your hunger level decreases");
                                UsePotion(user, food);
                                done = false;
                                Console.ReadLine();
                            }
                            break;

                        }


                    case "go North-West":
                        {
                            Console.WriteLine("You have gone North-West and have entered another room");
                            Console.ReadLine();
                            room5(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }


                    case "go West":
                        {
                            Console.WriteLine("You have gone West");
                            Console.ReadLine();
                            room4(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }

                    case "go South":
                        {
                            Console.WriteLine("You are going back to the first room");
                            Console.ReadLine();
                            room1(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }

                    case "go South-West":
                        {
                            Console.WriteLine("You have gone South-West");
                            Console.ReadLine();
                            room3(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }
                    case "go North":
                        {
                            Console.WriteLine("You cannot go North");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go East":
                        {
                            Console.WriteLine("You cannot go this way. The maze punishes you for not paying attention/being dumb");
                            Console.WriteLine("Lose 1 health point");
                            user.Health = user.Health - 1;
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go North-East":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go South-East":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                }
            }
            while (done == false);
        }
        public static void room3(Player user, Monster dragon, Monster drake, Potions health, Potions strength, Potions wisdom,
            Potions food, Weapons Fiery, Weapons Silver, Weapons Wooden)
        {
            user.Hunger = user.Hunger + 10;
            Console.WriteLine("Your hunger is now " + user.Hunger);
            if (user.Hunger >= 100)
            {
                Console.WriteLine("You forgot to eat didn't you?");
                Console.WriteLine("You fall to your knees at the brink of death.");
                Console.WriteLine("Soon enough you will be food for the rats, they know you need to eat to live.");
                Console.WriteLine("Thus ends your adventure.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("This room has 4 doors, North-East, West, North or East");
            Console.WriteLine("The room may also have potions and weapons for you to discover so be sure to search carefully.");
            Console.WriteLine("And don't forget about the monsters, they are out there somewhere....");
            Console.ReadLine();


            string choice;
            bool done = false;
            do
            {
                Console.WriteLine("You can move around the room (go: forward, backward, left or right) or just go into another room (go: North-West, West, North or East)");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "go backward":
                        {
                            Console.WriteLine("You discover a bottle labelled 'Wisdom Potion'");
                            Console.WriteLine("What do you choose to do, Drink or Store?");
                            choice = Console.ReadLine();

                            if (choice == "Drink")
                            {
                                Console.WriteLine("You drink the potion and you suddenly feel slightly smarter. 1 wisdom point has been added to your stats");
                                UsePotion(user, wisdom);
                                done = false;
                            }
                            if (choice == "Store")
                            {
                                Console.WriteLine("Your potion is now stored in your inventory");
                                wisdom.PAmount = wisdom.PAmount + 1;
                                done = false;
                            }
                            break;
                        }
                    case "go forward":
                        {
                            Console.WriteLine("You find the skeleton of what appears to be a warrior");
                            Console.WriteLine("Cobwebs litter the inside of the ribcage whilst you notice his left hand is still gripped tightly around the hilt of a silver broadsword");
                            Console.WriteLine("What do you do? Use or Store?");
                            choice = Console.ReadLine();

                            if (choice == "Use")
                            {
                                Console.WriteLine("You prise the sword out of the long dead warriors grip, it's not like he's going to be needing it anymore....");
                                Console.WriteLine("You equip the Silver Broadsword, eager to test out your new more powerful weapon");
                                Silver.Got = true;
                                done = false;
                            }
                           
                            break;
                        }
                    case "go right":
                        {
                            Console.WriteLine("You discover a wardrobe with heavy wooden doors");
                            Console.WriteLine("What do you do? Leave or Open?");
                            choice = Console.ReadLine();

                            if (choice == "Leave it")
                            {
                                done = false;
                            }
                            if (choice == "Open it")
                            {
                                Console.WriteLine("Bats fly out, but other than that the wardrobe is empty");
                                done = false;
                                Console.ReadLine();
                            }
                            break;
                        }
                    case "go left":
                        {
                            Console.WriteLine("You find a flask just lying on the floor");
                            Console.WriteLine("The flask has 'Health Potion' written on the side");
                            Console.WriteLine("You can either Store or Use the potion");
                            choice = Console.ReadLine();

                            if (choice == "Store")
                            {
                                Console.WriteLine("You have stored your potion");
                                health.PAmount = health.PAmount + 1;
                                done = false;
                                Console.ReadLine();
                            }
                            if (choice == "Use")
                            {
                                Console.WriteLine("One health point has been added to your stats");
                                UsePotion(user, health);
                                done = false;
                                Console.ReadLine();
                            }
                            break;

                        }


                    case "go North-East":
                        {
                            Console.WriteLine("You have gone North-East and have entered another room");
                            Console.ReadLine();
                            room2(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }


                    case "go West":
                        {
                            Console.WriteLine("You have gone West and found another room");
                            Console.ReadLine();
                            room7(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }

                    case "go North-West":
                        {
                            Console.WriteLine("You cannot go North-West");
                            done = false;
                            Console.ReadLine();
                            break;
                        }

                    case "go East":
                        {
                            Console.WriteLine("You have gone South-West and headed back to the first room");
                            Console.ReadLine();
                            room1(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }
                    case "go North":
                        {
                            Console.WriteLine("You have entered another room");
                            Console.ReadLine();
                            room4(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;

                        }
                    case "go South":
                        {
                            Console.WriteLine("The maze punishes you for not paying attention/being dumb");
                            Console.WriteLine("Lose 1 health point");
                            user.Health = user.Health - 1;
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go South-West":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go South-East":
                        {
                            Console.WriteLine("You cannot go this way, try again");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                }
            }
            while (done == false);
        }
        public static void room4(Player user, Monster dragon, Monster drake, Potions health, Potions strength, Potions wisdom,
            Potions food, Weapons Fiery, Weapons Silver, Weapons Wooden)
        {
            user.Hunger = user.Hunger + 10;
            Console.WriteLine("Your hunger is now " + user.Hunger);
            if (user.Hunger >= 100)
            {
                Console.WriteLine("You forgot to eat didn't you?");
                Console.WriteLine("You fall to your knees at the brink of death.");
                Console.WriteLine("Soon enough you will be food for the rats, they know you need to eat to live.");
                Console.WriteLine("Thus ends your adventure.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("This room has 4 doors, South, West, North or East");
            Console.WriteLine("The room may also have potions and weapons for you to discover so be sure to search carefully.");
            Console.WriteLine("And don't forget about the monsters, they are out there somewhere, seriously....");
            Console.ReadLine();
            Console.WriteLine("Before you can take a step a drak appears as if out of nowhere.");
            Console.WriteLine("Confident you can kill it easily you ready your weapon.");
            fighting(user, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);

            string choice;
            bool done = false;
            do
            {
                Console.WriteLine("You can move around the room (go: forward, backward, left or right) or just go into another room (go: South, West, North or East)");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "go backward":
                        {
                            Console.WriteLine("There's nothing behind you");
                            done = false;
                            break;
                        }
                    case "go forward":
                        {
                            Console.WriteLine("There is nothing here, not even dust. Just a very clean nothingness.");
                            done = false;
                            break;
                        }
                    case "go right":
                        {
                            Console.WriteLine("You discover a steaming, tender chicken leg, drizzled in bbq sauce, mmmm.....");
                            Console.WriteLine("What do you do? Store or Use?");
                            choice = Console.ReadLine();

                            if (choice == "Store")
                            {
                                Console.WriteLine("The food has been stored in your inventory");
                                food.PAmount = food.PAmount + 1;
                                done = false;
                            }
                            if (choice == "Use")
                            {
                                Console.WriteLine("You devour the chicken and your hunger decreases");
                                UsePotion(user, food);
                                done = false;
                                Console.ReadLine();
                            }
                            break;
                        }
                    case "go left":
                        {
                            Console.WriteLine("You find an old desk with a tall glass bottle placed in the middle of it");
                            Console.WriteLine("The bottle has 'Strength Potion' written on the side and it contains a clear liquid");
                            Console.WriteLine("You can either Store or Use the potion");
                            choice = Console.ReadLine();

                            if (choice == "Store")
                            {
                                Console.WriteLine("You have stored your potion");
                                strength.PAmount = strength.PAmount + 1;
                                done = false;
                                Console.ReadLine();
                            }
                            if (choice == "Use")
                            {
                                Console.WriteLine("One strength point has been added to your stats");
                                UsePotion(user, strength);
                                done = false;
                                Console.ReadLine();
                            }
                            break;

                        }


                    case "go South":
                        {
                            Console.WriteLine("You have gone South and have entered another room");
                            Console.ReadLine();
                            room3(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }


                    case "go West":
                        {
                            Console.WriteLine("You have gone West and found another room");
                            Console.ReadLine();
                            room6(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }

                    case "go North-West":
                        {
                            Console.WriteLine("You cannot go North-West");
                            done = false;
                            Console.ReadLine();
                            break;
                        }

                    case "go East":
                        {
                            Console.WriteLine("You have gone East and headed into a new room");
                            Console.ReadLine();
                            room2(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }
                    case "go North":
                        {
                            Console.WriteLine("You have entered another room");
                            Console.ReadLine();
                            room5(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;

                        }
                    case "go South-East":
                        {
                            Console.WriteLine("You open the door and get sucked out into a vaccume");
                            Console.WriteLine("Due to the lack of pressure in the vaccume, you instantly explode, and as such you're kinda dead.");
                            Console.WriteLine("Could have been worse, if the lack of pressure hadn't have killed you, you would have slowly suffocated due to the lack of oxygen");
                            Console.ReadLine();
                            Console.WriteLine("Your adventure and any clue you even existed ends here.");
                            Environment.Exit(0);
                            break;
                        }
                    case "go South-West":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go North-East":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                }
            }
            while (done == false);
        }
        public static void room5(Player user, Monster dragon, Monster drake, Potions health, Potions strength, Potions wisdom,
            Potions food, Weapons Fiery, Weapons Silver, Weapons Wooden)
        {
            user.Hunger = user.Hunger + 10;
            Console.WriteLine("Your hunger is now " + user.Hunger);
            if (user.Hunger >= 100)
            {
                Console.WriteLine("You forgot to eat didn't you?");
                Console.WriteLine("You fall to your knees at the brink of death.");
                Console.WriteLine("Soon enough you will be food for the rats, they know you need to eat to live.");
                Console.WriteLine("Thus ends your adventure.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("This room has 4 doors, South-West, West, South or South-East");
            Console.WriteLine("The room may also have potions and weapons for you to discover so be sure to search carefully.");
            Console.WriteLine("Oh and monsters may still be lurking around this maze....");
            Console.ReadLine();


            string choice;
            bool done = false;
            do
            {
                Console.WriteLine("You can move around the room (go: forward, backward, left or right) or just go into another room (go: South-West, West, South or South-East)");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "go backward":
                        {
                            Console.WriteLine("There's nothing behind you");
                            done = false;
                            break;
                        }
                    case "go forward":
                        {
                            Console.WriteLine("You find a hat box placed in the corner of the room");
                            Console.WriteLine("What do you choose to do. You can either Open or Leave?");
                            choice = Console.ReadLine();

                            if (choice == "Open")
                            {
                                Console.WriteLine("You open the box to find a ceramic container with a sticker on the side saying 'Wisdom Potion'");
                                Console.WriteLine("You can either Use or Store the potion");
                                choice = Console.ReadLine();

                                if (choice == "Use")
                                {
                                    Console.WriteLine("You drink the potion and you feel slightly smarter");
                                    Console.WriteLine("One Wisdom point has been added to your stats");
                                    UsePotion(user, wisdom);
                                    done = false;
                                }
                                if (choice == "Store")
                                {
                                    Console.WriteLine("Your potion has been stored in your inventory");
                                    wisdom.PAmount = wisdom.PAmount + 1;
                                    done = false;
                                }
                            }
                            if (choice == "Leave")
                            {
                                done = false;
                            }
                            break;
                        }
                    case "go right":
                        {
                            Console.WriteLine("You discover...............");
                            Console.ReadLine();
                            Console.WriteLine("Absolutely nothing!!");
                            done = false;
                            break;
                        }
                    case "go left":
                        {
                            Console.WriteLine("There's nothing here, sorry");
                            Console.WriteLine("Seems this room is actually relatively plain");
                            done = false;
                            break;

                        }


                    case "go South":
                        {
                            Console.WriteLine("You have gone South and have entered another room");
                            Console.ReadLine();
                            room4(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }


                    case "go West":
                        {
                            Console.WriteLine("You have gone West and found another room");
                            Console.ReadLine();
                            room8(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }

                    case "go North-West":
                        {
                            Console.WriteLine("You cannot go North-West");
                            done = false;
                            Console.ReadLine();
                            break;
                        }

                    case "go East":
                        {
                            Console.WriteLine("You cannot go East");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go North":
                        {
                            Console.WriteLine("Have you not learned yet?");
                            Console.WriteLine("You open the door and a heavy flow of water comes pounding through the door, quickly filling the room");
                            Console.WriteLine("You manage to heave the door shut and save yourself from drowning, but you are still slightly injured, lose 2 health points");
                            user.Health = user.Health - 2;
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go South-East":
                        {
                            Console.WriteLine("You head to another room");
                            room2(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            Console.ReadLine();
                            break;

                        }
                    case "go South-West":
                        {
                            Console.WriteLine("You walk through to another room");
                            room6(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }
                    case "go North-East":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                }
            }
            while (done == false);
        }
        public static void room6(Player user, Monster dragon, Monster drake, Potions health, Potions strength, Potions wisdom,
            Potions food, Weapons Fiery, Weapons Silver, Weapons Wooden)
        {
            user.Hunger = user.Hunger + 10;
            Console.WriteLine("Your hunger is now " + user.Hunger);
            if (user.Hunger >= 100)
            {
                Console.WriteLine("You forgot to eat didn't you?");
                Console.WriteLine("You fall to your knees at the brink of death.");
                Console.WriteLine("Soon enough you will be food for the rats, they know you need to eat to live.");
                Console.WriteLine("Thus ends your adventure.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("This room has 4 doors, North, East, South or North-East");
            Console.WriteLine("The room may also have potions and weapons for you to discover so be sure to search carefully.");
            Console.WriteLine("Oh and monsters may still be lurking around this maze....");
            Console.ReadLine();


            string choice;
            bool done = false;
            do
            {
                Console.WriteLine("You can move around the room (go: forward, backward, left or right) or just go into another room (go: North, East, South or North-East)");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "go forward":
                        {
                            Console.WriteLine("You find some scratchings on the wooden floor that read 'To anyone reading this, there is no way out, I'm sorry but you're doomed");
                            done = false;
                            break;
                        }
                    case "go backward":
                        {
                            Console.WriteLine("You find a pile of newspapers");
                            Console.WriteLine("What do you choose to do. You can either Search or Leave?");
                            choice = Console.ReadLine();

                            if (choice == "Search")
                            {
                                Console.WriteLine("You clear the newspapers away to discover a powerful fiery greatsword!'");
                                Console.WriteLine("Enter use to equip this weapon");
                                choice = Console.ReadLine();

                                if (choice == "Use")
                                {
                                    Console.WriteLine("You are now equipped with the fiery greatsword");
                                    Fiery.Got = true;
                                    done = false;
                                }
                               
                            }
                            if (choice == "Leave")
                            {
                                done = false;
                            }
                            break;
                        }
                    case "go right":
                        {
                            Console.WriteLine("You discover a plate of fish and chips");
                            Console.WriteLine("You can either Eat or Store the discovered food");
                            choice = Console.ReadLine();

                            if (choice == "Eat")
                            {
                                Console.WriteLine("You choose to eat this delicious meal and your hunger decreases.");
                                UsePotion(user, food);
                                done = false;
                            }
                            if (choice == "Store")
                            {
                                Console.WriteLine("Your food is stored in your inventory, but be careful to check your hunger status");
                                food.PAmount = food.PAmount + 1;
                                done = false;
                            }
                            break;
                        }
                    case "go left":
                        {
                            Console.WriteLine("You open a cupboard only to have a pile of dusty books fall onto you");
                            Console.WriteLine("Lose 1 health point");
                            user.Health = user.Health - 1;
                            done = false;
                            break;

                        }


                    case "go South":
                        {
                            Console.WriteLine("You have gone South and have entered another room");
                            Console.ReadLine();
                            room7(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }


                    case "go West":
                        {
                            Console.WriteLine("A honey badger jumps out of the door and viciously starts biting you");
                            Console.WriteLine("You manage to kick it back through the door and shut it, but it has taken it's toll on you, loose 3 health points");
                            user.Health = user.Health - 3;
                            done = false;
                            Console.ReadLine();
                            break;
                        }

                    case "go North-West":
                        {
                            Console.WriteLine("You cannot go North-West");
                            done = false;
                            Console.ReadLine();
                            break;
                        }

                    case "go East":
                        {
                            Console.WriteLine("You enter another room");
                            Console.ReadLine();
                            room4(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }
                    case "go North":
                        {
                            Console.WriteLine("You enter another room");
                            room7(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            Console.ReadLine();
                            done = false;
                            break;

                        }
                    case "go South-East":
                        {
                            Console.WriteLine("You cannot go this way, why not just behave yourself??");
                            done = false;
                            Console.ReadLine();
                            break;

                        }
                    case "go South-West":
                        {
                            Console.WriteLine("You cannot go South-West");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go North-East":
                        {
                            Console.WriteLine("You enter another room");
                            room5(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            Console.ReadLine();
                            break;
                        }
                }
            }
            while (done == false);
        }
        public static void room7(Player user, Monster dragon, Monster drake, Potions health, Potions strength, Potions wisdom,
            Potions food, Weapons Fiery, Weapons Silver, Weapons Wooden)
        {
            user.Hunger = user.Hunger + 10;
            Console.WriteLine("Your hunger is now " + user.Hunger);
            if (user.Hunger >= 100)
            {
                Console.WriteLine("You forgot to eat didn't you?");
                Console.WriteLine("You fall to your knees at the brink of death.");
                Console.WriteLine("Soon enough you will be food for the rats, they know you need to eat to live.");
                Console.WriteLine("Thus ends your adventure.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("This room only has 2 doors, East and North");
            Console.WriteLine("The room may also have potions and weapons for you to discover so be sure to search carefully.");
            Console.WriteLine("Oh and monsters may still be lurking around this maze, you never know when they might appear....");
            Console.ReadLine();


            string choice;
            bool done = false;
            do
            {
                Console.WriteLine("You can move around the room (go: forward, backward, left or right) or just go into another room (go: East or North)");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "go backward":
                        {
                            Console.WriteLine("There's nothing behind you");
                            done = false;
                            break;
                        }
                    case "go forward":
                        {
                            Console.WriteLine("You find a scorched piece of paper and what looks like a crumpled metal helmet and smashed shield, with a dark mark on the floor whtar looks like an enormous footprint.....");
                            done = false;
                            break;
                        }
                    case "go right":
                        {
                            Console.WriteLine("You discover a bottle leaning in the corner of the room");
                            Console.WriteLine("The label reads 'Double strength, strength potion'. What do you choose to do, Store or Use");
                            choice = Console.ReadLine();

                            if (choice == "Store")
                            {
                                Console.WriteLine("This potion is now stored in your inventory");
                                strength.PAmount = strength.PAmount + 2;
                                done = false;
                            }
                            if (choice == "Use")
                            {
                                Console.WriteLine("You drink the potion and your strength stat increases.");
                                user.Strength = user.Strength + 2;
                                done = false;
                            }
                            break;
                        }
                    case "go left":
                        {
                            Console.WriteLine("This seems to be a pretty plentiful room");
                            Console.WriteLine("You discover a basket with a bottle in it, with a lael on it saying 'Double strength, wisdom potion'. You can either Use or Store the potion");
                            choice = Console.ReadLine();

                            if (choice == "Use")
                            {
                                Console.WriteLine("You drink the potion and your intelligence and strength increases by 2");
                                user.Strength = user.Strength + 2;
                                Console.WriteLine("Your strength is now " + user.Strength);
                                done = false;
                            }
                            if (choice == "Store")
                            {
                                Console.WriteLine("You have stored the potion in your inventory");
                                strength.PAmount = strength.PAmount + 2;
                                wisdom.PAmount = wisdom.PAmount + 2;
                                done = false;
                            }
                            break;

                        }

                    case "go South":
                        {
                            Console.WriteLine("You cannot go South");
                            done = false;
                            Console.ReadLine();
                            break;
                        }


                    case "go West":
                        {
                            Console.WriteLine("You cannot go West, and to punish your stupidity, the maze absorbs some of your health, you loose 2 health points");
                            done = false;
                            Console.ReadLine();
                            break;
                        }

                    case "go North-West":
                        {
                            Console.WriteLine("You cannot go North-West");
                            done = false;
                            Console.ReadLine();
                            break;
                        }

                    case "go East":
                        {
                            Console.WriteLine("You enter another room");
                            Console.ReadLine();
                            room3(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
                            break;
                        }
                    case "go North":
                        {
                            Console.WriteLine("You enter another room");
                            Console.ReadLine();
                            break;

                        }
                    case "go South-East":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;

                        }
                    case "go South-West":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                    case "go North-East":
                        {
                            Console.WriteLine("You cannot go this way");
                            done = false;
                            Console.ReadLine();
                            break;
                        }
                }
            }
            while (done == false);
        }
        public static void room8(Player user, Monster dragon, Monster drake, Potions health, Potions strength, Potions wisdom,
            Potions food, Weapons Fiery, Weapons Silver, Weapons Wooden)
        {
            user.Hunger = user.Hunger + 10;
            Console.WriteLine("Your hunger is now " + user.Hunger);
            if (user.Hunger >= 100)
            {
                Console.WriteLine("You forgot to eat didn't you?");
                Console.WriteLine("You fall to your knees at the brink of death.");
                Console.WriteLine("Soon enough you will be food for the rats, they know you need to eat to live.");
                Console.WriteLine("Thus ends your adventure.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("You enter the room and the only thing you see is the dragon");
            Console.WriteLine("Don't succumb to fear, fight the dragon and claim your prize");
            fighting(user, dragon, health, strength, wisdom, food, Fiery, Silver, Wooden);
            Console.WriteLine("You coward, back to the start with you");
            Console.ReadLine();
            room1(user, dragon, drake, health, strength, wisdom, food, Fiery, Silver, Wooden);
        }

        public static void fighting(Player user, Monster monster, Potions health, Potions strength, Potions wisdom,
            Potions food, Weapons Fiery, Weapons Silver, Weapons Wooden)
        {
            Console.Clear();
            int dmg_mod = 0;

            if (Fiery.Got == true)
            {
                dmg_mod = 3;
            }
            else
            {
                if (Silver.Got == true)
                {
                    dmg_mod = 2;
                }

                else
                {
                    if (Wooden.Got == true)
                    {
                        dmg_mod = 1;
                    }
                }
            }


            string choice;
            bool conclude = false;
            Random die = new Random();
            int roll, tohit, dmg;
            //player chooses action, wrong action results in free attack to monster
            do
            {
                Console.Clear();
                Console.WriteLine(dmg_mod);
                Console.WriteLine("Type attack to attack,potion to use a potion or flee to flee the fight");
                choice = Console.ReadLine();
                switch (choice)
                {

                    case "flee": //can player escape?
                        {
                            Console.WriteLine("You attempt to make your escape");
                            roll = die.Next(1, 21);
                            if (roll > 15)
                            {
                                Console.WriteLine("You manage to run although " + monster.Name + " manages an attack as you flee");
                                conclude = true;
                            }
                            else
                            {
                                Console.WriteLine("You are trapped and must fight");
                            }
                            break;
                        }
                    case "potion":
                        {
                            string Pchoice;
                            Console.WriteLine("Please enter which potion you would like to use");
                            Pchoice = Console.ReadLine();
                            switch (Pchoice) //player chooses which potion to use
                            {
                                case "health":
                                    {
                                        UsePotion(user, health);
                                        break;
                                    }
                                case "strength":
                                    {
                                        UsePotion(user, strength);
                                        break;
                                    }
                                case "wisdom":
                                    {
                                        UsePotion(user, wisdom);
                                        break;
                                    }
                                case "food":
                                    {
                                        UsePotion(user, food);
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("That potion does not exist, I suggest you tell this to your player");
                                        Console.ReadLine();
                                        break;
                                    }
                            }
                            break;
                        }

                    case "attack": //player attacks
                        {
                            Console.WriteLine("You strike the creature with your ");
                            tohit = die.Next(1, 21) + (user.Wisdom / 10);
                            Console.WriteLine("Tohit = " + tohit);

                            if (tohit < 5) //miss
                            {
                                Console.WriteLine(user.Name + " misses");
                                Console.ReadLine();
                            }

                            if ((tohit <= 15) && (tohit >= 5)) //standard attack
                            {
                                dmg = die.Next(1, 7) + dmg_mod + (user.Strength / 10);
                                Console.WriteLine(user.Name + " hits for " + dmg + " damage");
                                monster.Health = monster.Health - dmg;
                                Console.WriteLine(monster.Name + " now has " + monster.Health + " health reamining");
                                user.Score = user.Score + 10;
                                Console.WriteLine("Your score is now " + user.Score);
                                Console.ReadLine();
                            }

                            if ((tohit > 15) && (tohit < 20)) //critical attack
                            {
                                dmg = die.Next(1, 7) + dmg_mod + (user.Strength / 5);
                                Console.WriteLine(user.Name + " hits for " + dmg + " damage");
                                monster.Health = monster.Health - dmg;
                                Console.WriteLine(monster.Name + " now has " + monster.Health + " health reamining");
                                user.Score = user.Score + 20;
                                Console.WriteLine("Your score is now " + user.Score);
                                Console.ReadLine();
                            }

                            if (tohit >= 20) //instant monster death
                            {
                                Console.WriteLine("An arc of lightning bursts fourth from your weapon");
                                Console.WriteLine("It strikes the " + monster.Name + " right at its heart killing it instantly");
                                monster.Health = 0;
                                user.Score = user.Score + 100;
                                Console.WriteLine("Your score is now " + user.Score);
                                Console.ReadLine();
                            }

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("You confuse yourself and allow the creature to attack");
                            break;
                        }
                }
                //check if monster is dead
                if (monster.Health <= 0)
                {
                    conclude = true;
                }
                //monster alive so monster attacks
                else
                {
                    Console.WriteLine(monster.Name + " attacks " + user.Name);
                    tohit = die.Next(1, 21) + (monster.Wisdom / 10);
                    Console.WriteLine("Tohit = " + tohit);
                    if (tohit < 5) //miss
                    {
                        Console.WriteLine(monster.Name + " misses");
                        Console.ReadLine();
                    }

                    if ((tohit <= 15) && (tohit >= 5)) //standard attack
                    {
                        dmg = die.Next(1, 7) + (monster.Strength / 10);
                        Console.WriteLine(monster.Name + " hits for " + dmg + " damage");
                        user.Health = user.Health - dmg;
                        Console.WriteLine(user.Name + " now has " + user.Health + " health reamining");
                        Console.ReadLine();
                    }

                    if (tohit > 15) //critical attack
                    {
                        dmg = die.Next(1, 7) + (monster.Strength / 10);
                        Console.WriteLine(monster.Name + " hits for " + dmg + " damage");
                        user.Health = user.Health - dmg;
                        Console.WriteLine(user.Name + " now has " + user.Health + " health reamining");
                        Console.ReadLine();
                    }

                }
                if (user.Health <= 0) //check to see if player is dead
                {
                    conclude = true;
                }

            }
            while (conclude == false);
            // end game if player or dragon dies, play continues if only the drake is dead
            if ((monster.Health <= 0) && (monster.Name == "Drake"))
            {
                Console.Clear();
                Console.WriteLine("The Drake falls to the ground, you carry on knowing that was an easy battle.");
                user.Score = user.Score + 20;
                Console.WriteLine("Your score is now " + user.Score);
                Console.ReadLine();
            }

            if ((monster.Health <= 0) && (monster.Name == "Dragon"))
            {
                Console.Clear();
                Console.WriteLine("The Dragon lets out a terrible scream as its life slowly drains away.");
                Console.WriteLine("You wipe the sweat from your brow and exit the dungeon proud at your achievement.");
                Console.WriteLine("Your final score was " + user.Score);
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (user.Health <= 0)
            {
                Console.Clear();
                Console.WriteLine("You drop to your knees knowing you can go on no more.");
                Console.WriteLine("The monster senses your weakness and delivers the final blow");
                Console.WriteLine("This is where your adventure ends, as another skull in the pile of the monster's lair");
                Console.WriteLine("Your final score was " + user.Score);
                Console.ReadLine();
                Environment.Exit(0);
            }

        }

        public static void UsePotion(Player user, Potions potion)
        {
            if (potion.PAmount == 0) // Check for 0 potions
            {
                Console.WriteLine("You can't drink what you don't have");
            }
            else
            {
                switch (potion.PName)// add to relevant stat
                {
                    case "health":
                        {
                            user.Health = user.Health + 10;
                            Console.WriteLine("Your new health is " + user.Health);
                            potion.PAmount = potion.PAmount - 1;
                            break;
                        }
                    case "strength":
                        {
                            user.Strength = user.Strength + 2;
                            Console.WriteLine("Your new strength is " + user.Strength);
                            potion.PAmount = potion.PAmount - 1;
                            break;
                        }
                    case "wisdom":
                        {
                            user.Wisdom = user.Wisdom + 2;
                            Console.WriteLine("Your new wisdom is " + user.Wisdom);
                            potion.PAmount = potion.PAmount - 1;
                            break;
                        }
                    case "food":
                        {
                            user.Hunger = user.Hunger - 10;
                            Console.WriteLine("Your new hunger is " + user.Hunger);
                            potion.PAmount = potion.PAmount - 1;
                            break;
                        }
                }
            }
        }
    
    }
}

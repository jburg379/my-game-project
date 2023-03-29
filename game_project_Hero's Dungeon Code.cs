/*********************************************************************************************************
                        The Hero's Dungeon
                         By Joseph Burgos
                            CSC 240-10
                          March 5, 2023
                            Project 2

About the game:
You’re a young adventurer that was out on a quest and stepped on a trap that teleported you to the Hero’s Dungeon. 
You have never been to this dungeon, but you know its legend. 
This is the dungeon which only the Hero of the world can clear. 
The goal is to exit this dungeon without reaching the boss room. 
However, the maze at every level makes it hard for you to find the exit that every level of the dungeon has.

Warning:
The game is an adventure genre game and contains violence (rated: PG-13).
As such, under 13 should not be playing this game without parental consent and oversight!

PURPOSE:
Provide an intro to C# programming using an Interactive Fiction (IF) text-based game format.
*************************************************************************************************************/

using System;

class Hero {
    public static bool legendarySword;                   // Verify if the player has the legendary swrod. 
    public static int swordMaxDamage;                    // Set the maximum damage of the sword for randomize purposes. 
    public static int legendSwordDamage;                 // Set the maximum damage of the legendary sword for randomize purposes.
    public static int playerMaxHealth;                   // Set the maximum health of the player. 
    public static int playerMinHealth;                   // Set the minimum health of the player. 
    public static int playerHealth;                      // Set player's health to be maximum at the start of the game.
    public static int monsterHit;                        // Set the maximum damage of the monster's claws for randomize purposes. Zero being no damage. 
    public static int monsterMaxHealth;                  // Set the maximum health of the monster.  
    public static int monsterMinHealth;                  // Set the minimum health of the monster.
    public static int monsterHealth;                     // Set monster's health to be maximum at the start of the game.
    public static string[] inventory;                    // Set inventory to have 5 items max.
    public static int currentInvCount;                   // How many items the player currently carries in storage. (Not Equiped)

    /////////////////
    //Main Function//
    /////////////////
    public static void Main() {
        stats();                 // This will set/reset the stats of the game 
        intro();                 // This will explaon the the game to the player
        theDungeon();               // This is where the game will take place
    } // End Main function

    static void intro() {
        Console.Clear();
        Console.WriteLine("The Hero's dungeon");
        Console.WriteLine("By Joseph Burgos");
        Console.WriteLine("CSC 240-10");
        Console.WriteLine("Project 2");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Game Introduction");
        Console.WriteLine("You are a young adventurer that was out on a quest ");
        Console.WriteLine("and stepped on a trap that teleported you to the Heros Dungeon.");
        Console.WriteLine("You have never been to this dungeon, but you know its legend.");
        Console.WriteLine("This is the dungeon which only the Hero of the world can clear.");
        Console.WriteLine("TYou need to exit this dungeon without reaching the boss room at the bottom floor.");
        Console.WriteLine("However, the dungeon is like a maze and you need to choose the right path to follow.");
        Console.WriteLine();
        Console.WriteLine("Possible Commands: Directions (left, right, forward), I/inventory");
        Console.WriteLine();
        Console.WriteLine();

        // Game content warning
        Console.WriteLine("WARNING!!");
        Console.WriteLine("The game is an adventure genre game and contains violence (rated: PG-13).");
        Console.WriteLine("As such, under 13 should not be playing this game without parental consent and oversight!");

        // Get character names
        Console.Write("Please inout your character's name: ");
        string name = Console.ReadLine();

        // BEgin character's story
        Console.Write($"\n{name}, ");
        Console.WriteLine("you live in a world of magic, swords, monsters, and dungeons.");
        Console.WriteLine("In this world you are just an adventurer who takes requests from people in exchange for payment.");
        Console.WriteLine("The usual requests are to defeat monsters that might be attacking people in some way.");
        Console.WriteLine("During one of your adventures to defeat a monster that has taken shelter in the forest");
        Console.WriteLine(" you stepped into a trap that teleported you to a dungeon.");
        Console.WriteLine("Unprepared to take on a dungeon your priority is to find the exit of the level you have been teleported to. ");
        Console.WriteLine("Having lit a fire you can finally see the dungeon and realize that you have been transported to the legendary");
        Console.WriteLine(" Hero's Dungeon.");
        Console.WriteLine("\n You try not to freak out because you know that making a wrong turn could lead you to the boss room, ");
        Console.WriteLine("which would mean your end.");
        Console.WriteLine();
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
    } // end intro function


    ///////////////////////
    //Upper Dungeon Level//
    ///////////////////////
    static void theDungeon() {
        Console.WriteLine();
        Console.WriteLine("The dungeon's upper level");
        Console.WriteLine("Your fire lights up the dungeon. It looks like a cave stone walls all around.");
        Console.WriteLine("There are two paths in front of you one will lead to the exit and the other leads to the middle level");
        Console.WriteLine();

        while(true){
            Console.WriteLine("\n Which way would you like to go? Left or Right?");
            string flevel = Console.ReadLine();
            switch(flevel){
                case "L": case "l": case "left": case "Left":
                    Console.WriteLine("\nYou have found the exit room of the upper level");
                    exitRoom();
                    break;
                case "R": case "r": case "right": case "Right":
                    Console.WriteLine("\nYou found the stairs to the next level and the way back closes.");
                    Console.WriteLine("You continue down to the next level");
                    theMiddleLevel();
                    break;
                default:
                    Console.WriteLine($"\n Sorry, but i do not understant ''{flevel}''.");
                    break;
            } // Ends switch
        } // Ends While
    } // Ends theDungeon


    ////////////////////////
    //Middle Dungeon Level//
    ////////////////////////
    static void theMiddleLevel() {
        Console.WriteLine();
        Console.WriteLine("\n You reached the middle level of the dungeon");
        Console.WriteLine("The middle level looks bigger and it has an extra path straight forward");
        Console.WriteLine("In this level you fell a strong pressure, like the one of a strong monster.");
        Console.WriteLine("You know that monsters tend to enter the dungeon to challenge the boss at the bottom");
        Console.WriteLine(" level to try to become the new boss which will give them the title of monster king.");
        Console.WriteLine("You feel that this is a monster that you might be able to meet but decide it would be ");
        Console.WriteLine("best to avoid it and try to find the exit");

        while(true){
             Console.WriteLine("\nWhich way would you like to go?");
             Console.WriteLine("Forward, left or right?");
             string slevel = Console.ReadLine();
             switch(slevel){
                case "L": case "l": case "left": case "Left":
                    Console.WriteLine("\nYou found the stairs to the next level and the way back closes.");
                    Console.WriteLine("You continue down to the next level");
                    Console.WriteLine("However, you know this is the end. Because in the next level is the boss.");
                    theLowerLevel();
                    break;
                case "R": case "r": case "right": case "Right":
                    Console.WriteLine("\nYou have found the exit room of the middle level");
                    exitRoom();
                    break;
                case "F": case "f": case "Forward": case "forward":
                    stats();
                    mysteryRoom();
                    break;
                case "I": case "inventory": case "i":
                    inv();
                    break;
                default:
                    Console.WriteLine($"\n Sorry, but i do not understant ''{slevel}''.");
                    break;
            } // Ends switch
        } // Ends while
    } // Ends theMiddleLevel


    ////////////////
    //Monster Room//
    ////////////////
    static void mysteryRoom(){
        Console.WriteLine("\n You have found a new room.");
        Console.WriteLine("In it you find the source of the strong pressure.");
        Console.WriteLine("It's a monster that has come to challenge the boss on the lower level.");
        Console.WriteLine("Behind the monster there is an item. It looks like the legendary sword");
        Console.WriteLine(" that can only be wielded by the hero. If you defeat the monster you");
        Console.WriteLine(" can get the sword and give it to the hero if you ever get out.");

        while(true){
            Console.WriteLine("\nWould you like to fight the monster or retreat?");
            string fight = Console.ReadLine();
            switch(fight){
                case "Fight": case "fight": case "f": case "F":
                    Console.WriteLine($"\nYour Stats: Player's health {playerHealth}\\{playerMaxHealth}");
                    Console.WriteLine($"Monster Stats: Monster's health {monsterHealth}\\{monsterMaxHealth}");
                    fightBegins();
                    break;
                case "Retreat": case "retreat": case "R": case "r":
                    theMiddleLevel();
                    break;
                default:
                    Console.WriteLine($"\n Sorry, but i do not understant ''{fight}''.");
                    break;
            } // Ends switch
        } // Ends while
    } // Ends mysteryRoom


    //////////////////////
    //You Chose to fight//
    //////////////////////
    static void fightBegins() {
        Console.WriteLine("\n You have chosen to fight the monster to get to the legendary sword\n");
        Random ran = new Random();  // Sets a random number
        int mDamage;
        int pDamage;
        string player;
        bool fightOver = false;
        
        while(!fightOver){
            mDamage = ran.Next(0, monsterHit);
            if(mDamage == 0){
                Console.WriteLine("The monster missed you\n");
            }
            else {
                Console.WriteLine($"The monster did {mDamage} damage");
                playerHealth = playerHealth - mDamage;
                Console.WriteLine($"Your health is down to {playerHealth}. \n");
            }
            if(playerHealth < playerMinHealth){
                fightOver = true;
                Console.WriteLine("\n Your are severely injured and retreat. With just enough health you make it back");
                Console.WriteLine("to the middle level where you will have to find the exit. With little health left");
                Console.WriteLine("now you must avoid going back to where the monster is and give up on getting");
                Console.WriteLine("the legendary sword.");
                theMiddleLevel();
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to attack!");

            player = Console.ReadLine();

            pDamage = ran.Next(0, swordMaxDamage);
            if(pDamage == 0){
                Console.Write("\nYou missed the monster");
            }
            else{
                Console.WriteLine($"You hit the monster and did {pDamage} of damage");
                monsterHealth = monsterHealth - pDamage;
                Console.WriteLine($"The monster's health is down to {monsterHealth}.");
            }

            if(monsterHealth < monsterMinHealth){
                fightOver = true;
                Console.WriteLine("\nYou have defeated the monster and walk toward the legendary sword");
                takeSword();
            }
            else{
                Console.WriteLine();
                Console.WriteLine("Press enter for the monster's turn to attack.");
                player = Console.ReadLine();
            } // Ends else
        } // Ends while
    } // Ends fightBegins


    ////////////////////////////
    //Take the legendary Sword//
    ////////////////////////////
    static void takeSword(){
        while(true){
            Console.WriteLine("Take the legendary sword? (yes/no)");
            string resp = Console.ReadLine();
            switch(resp){
                case "yes": case "y": case "Yes": case "Y":
                    legendarySword = true;
                    inventory[currentInvCount] = "legenday sword";
                    currentInvCount++;
                    Console.WriteLine("\nYou take the legendary sword and head back to the middle level to try to find the exit.");
                    Console.WriteLine($"You check the sword and find out it can do up to {legendSwordDamage} points of damage,");
                    Console.WriteLine("but it can only be wielded by the hero.");
                    theMiddleLevel();
                    break;
                case "no": case "No": case "n": case "N":
                    Console.WriteLine("You leave the legendary sword where it is and go back to the middle level");
                    theMiddleLevel();
                    break;
            } // Ends switch
        }
    } // Ends takeSword

    /////////////
    //Exit Room//
    /////////////
    static void exitRoom(){
        Console.WriteLine("\nCongradulations! You found the exit room on this level");
        Console.WriteLine("You can now go home and put this behind you.");
        Console.WriteLine("Press Enter to continue");
        safeEscape();   // Winning Conclusion
    }// Ends exitRoom


    ///////////////////////
    //Dungeon Lower Level//
    ///////////////////////
    static void theLowerLevel(){
        Console.WriteLine("\n You have failed!");
        Console.WriteLine("You reached the lower level of the dungeon. With no other choice but to move forward");
        Console.WriteLine("you try to fight against the boss of the dungeon, the Monster King. However, it is useless");
        Console.WriteLine("only the hero can defeat this monster. You are no match for it and die in the blink of an eye");
        lostGame();  // Losing conclusion
    } // Ends theLowerLevel

    // Set game stats
    static void stats(){
        legendarySword = false;                 // Verify if the player decided to take the legenddary sword. Default false
        swordMaxDamage = 130;                   // Set the maximum damage of the sword for randomize purposes. Zero being no damage.
        legendSwordDamage = 300;                // Set the damage the legendary sword can do. This is for show purposes
        playerMaxHealth = 200;                  // Set the maximum health of the player.
        playerMinHealth = 20;                   // Set the minimum health of the player. Falling below this level, the player will retreat.
        playerHealth = 200;                     // Set player's health to be maximum at the start of the game.
        monsterHit = 80;                        // Set the maximum damage the monster can do for randomize purposes. Zero being no damage. 
        monsterMaxHealth = 300;                 // Set the maximum health of the monster.
        monsterMinHealth = 0;                   // Set the minimum health of the monster. Falling below this level, the monster will die.
        monsterHealth = 300;                     // Set monster's health to be maximum at the start of the game.
        inventory = new string[5];              // Set inventory to have 5 items max.
        currentInvCount = 0;                    // reset inventory number of items to zero.
    } // Ends stats

    //////////////////
    //Open Inventory//
    //////////////////
    static void inv(){
        if (currentInvCount==0){
            Console.WriteLine("\nYou currently don't have any items.");
        }
        else{
        Console.Write("\nThese are the items in your inventory: ");
        for (int item = 0; item < currentInvCount; item++)
            Console.WriteLine(" --> ", inventory[item]);
        }
    } // Ends inv

    //////////////////////
    //Winning Conclusion//
    //////////////////////
    static void safeEscape(){
        string playerRes = Console.ReadLine();
        Console.WriteLine("\n You exit the dungeon and start making your way back home");
        Console.WriteLine("On the way you find the hero's party on their way to the dungeon.");
        Console.WriteLine("They notice you are coming from the direction of the dungeon ask if you had been there");
        Console.WriteLine("You respond by seying you have been there and had just escaped.");
        Console.WriteLine("The hero stands in front of you and asks you if you found the legendary sword");

        if (legendarySword == true){
            Console.WriteLine("\nYou tell the hero you do have the legendary sword and pull it out of your");
            Console.WriteLine("inventory and give it to him. After you continue on your way back home");
        }
        else{
            Console.WriteLine("\nYou tell the hero you did not find the legendary sword.");
            Console.WriteLine("You say goodbye to the hero and continue on your way back home");
        }

        restartGame();
    }

    /////////////////
    //Lost the game//
    /////////////////
    static void lostGame() {
        Console.WriteLine();
        Console.WriteLine("You reached the lower level of the dungeon. With no way back you entered the boss room");
        Console.WriteLine("in hopes of finding a way to escape and get out of the dungeon.");
        Console.WriteLine("You encouraged yoursefl and set your mind on fighting as had as you can to survive.");
        Console.WriteLine("You entered the boss room and stood in front of the monster king ready to fight.");
        Console.WriteLine("With powerful battle cry you lunge forward ready to fight. But in the blink of an eye");
        Console.WriteLine("you hit the floor and drew your last breath.");
        Console.WriteLine("\n----------------------------------------\n");
        Console.WriteLine("YOU HAVE LOST THE GAME!");

        restartGame();
    } // Ends lostGame

    
    ////////////////////
    //Restart the game//
    ////////////////////
    static void restartGame(){
        string res;
        string ready;
        
        Console.Write("\nWould you like to restart this game? ");
        Console.Write("(yes or no) ");
        res = Console.ReadLine(); 
        if ((res == "Y") || (res == "y") || (res == "yes") || (res == "YES")){
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\nPress the Enter key to restart the game!");
            ready = Console.ReadLine();
            
            Main();
        }
        else{
            Console.WriteLine("\nThank you for playing The Hero's Dungeon\n");
            endGame();
        }
    } //Ends restartGame


    ////////////////////
    //End game credits//
    ////////////////////
    static void endGame(){
        Console.WriteLine("\n________________________________________________________________________________");
        Console.WriteLine("          The Hero's Dungeon");
        Console.WriteLine("          Designed and developed by Joseph Burgos");
        Console.WriteLine("          Kutztown University CSIT Major"); 
        Console.WriteLine("          for CSC 240-10, Project #2");  
        Console.WriteLine("          Copyright © 2023");
        Console.WriteLine("__________________________________________________________________________________\n");    
        Environment.Exit(1); // Exit the program
    }
}

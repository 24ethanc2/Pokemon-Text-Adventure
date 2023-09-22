using System;
class Runner
{
    static void Main() 
    {
        Rooms[] roomList = new Rooms[9];
        Pokemon[] inventory = new Pokemon[6];
        roomList[0] = new Rooms("Kanto", 0); roomList[1] = new Rooms("Johto", 1); roomList[2] = new Rooms("Unova", 2);
        roomList[3] = new Rooms("Hoenn", 3); roomList[4] = new Rooms("Sinnoh", 4); roomList[5] = new Rooms("Kalos", 5);
        roomList[6] = new Rooms("Alola", 6); roomList[7] = new Rooms("Galar", 7); roomList[8] = new Rooms("Paldea", 8);
        Console.WriteLine("Welcome to Pokemon Text Adventure");
        Console.WriteLine("In this game, you will be able to explore all 9 regions of Pokemon");
        Console.WriteLine("You will have to catch pokemons in order to beat the final boss: Arceus himself");
        Console.WriteLine("But first, let's get you your first starter pokemon");
        while(true)
        {
            Console.WriteLine("Please Choose your first starter:  \n| 1: Bulbasaur | 2: Charmander | 3: Squirtle | ");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                inventory[0] = new Pokemon("Bulbasaur", "Grass", 100, 20, 20, 1);
                break;
            }
            else if(choice == 2)
            { 
                inventory[0] = new Pokemon("Charmander", "Fire", 100, 20, 20, 1);
                break;
            }
            else if(choice == 3)
            {
                inventory[0] = new Pokemon("Squirtle", "Water", 100, 20, 20, 1);
                break;
            }
            else{
                Console.WriteLine("Invalid Choice, Please type a Number");
            }
        }
    }
}

class Rooms
{
    private string name;
    private Pokemon[,] storage;

    public Rooms(string n, int x)
    {   
        storage = new Pokemon[9,5];
        storage[0,0] = new Pokemon("Pikachu", "Electric", 100, 20, 20, 0.5);
        storage[0,1] = new Pokemon("Eevee", "Normal", 100, 20, 20, 0.5);
        storage[0,2] = new Pokemon("Dratini", "Dragon", 120, 30, 30, 0.25);
        storage[0,3] = new Pokemon("Magikarp", "Water", 100, 20, 20, 0.5);
        storage[0,4] = new Pokemon("Mewtwo", "Psychic", 150, 40, 35, 0.05);
        storage[1,0] = new Pokemon("Wooper", "Water", 100, 20, 20, 0.5);
        storage[1,1] = new Pokemon("Larvitar", "Rock", 120, 30, 30, 0.25);
        storage[1,2] = new Pokemon("Mareep", "Electric", 100, 20, 20, 0.5);    
        storage[1,3] = new Pokemon("Houndour", "Dark", 100, 20, 20, 0.5);
        storage[1,4] = new Pokemon("Ho-oh", "Flying", 150, 40, 35, 0.05);
        storage[2,0] = new Pokemon("Ralts", "Psychic", 100, 20, 20, 0.5);
        storage[2,1] = new Pokemon("Slakoth", "Normal", 100, 20, 20, 0.5);
        storage[2,2] = new Pokemon("Beldum", "Steel", 120, 30, 30, 0.25);
        storage[2,3] = new Pokemon("Wailmer", "Water", 100, 20, 20, 0.5);
        storage[2,4] = new Pokemon("Rayquaza", "Dragon", 150, 40, 35, 0.05);
        storage[3,0] = new Pokemon("Starly", "Flying", 100, 20, 20, 0.5);
        storage[3,1] = new Pokemon("Riolu", "Fighting", 100, 20, 20, 0.5);
        storage[3,2] = new Pokemon("Gabite", "Dragon", 120, 30, 30, 0.25);
        storage[3,3] = new Pokemon("Munchlax", "Normal", 100, 20, 20, 0.5);
        storage[3,4] = new Pokemon("Dialga", "Steel", 150, 40, 35, 0.05);
        storage[4,0] = new Pokemon("Axew", "Dragon", 100, 20, 20, 0.5);
        storage[4,1] = new Pokemon("Litwick", "Ghost", 100, 20, 20, 0.5);
        storage[4,2] = new Pokemon("Zorua", "Dark", 100, 20, 20, 0.5);
        storage[4,3] = new Pokemon("Pawniard", "Dark", 100, 20, 20, 0.5);
        storage[4,4] = new Pokemon("Kyurem", "Dragon", 150, 40, 35, 0.05);
        storage[5,0] = new Pokemon("Honedge", "Steel", 100, 20, 20, 0.5);
        storage[5,1] = new Pokemon("Froakie", "Water", 100, 20, 20, 0.5);
        storage[5,2] = new Pokemon("Fletchling", "Flying", 100, 20, 20, 0.5);
        storage[5,3] = new Pokemon("Gloomy", "Dragon", 120, 30, 30, 0.25);
        storage[5,4] = new Pokemon("Zygarde", "Dragon", 150, 40, 35, 0.05);
        storage[6,0] = new Pokemon("Litten", "Fire", 100, 20, 20, 0.5);
        storage[6,1] = new Pokemon("Rockruff", "Rock", 100, 20, 20, 0.5);
        storage[6,2] = new Pokemon("Mimikyu", "Ghost", 100, 20, 20, 0.5);
        storage[6,3] = new Pokemon("Jangmo-o", "Fighting", 120, 30, 30, 0.25);
        storage[6,4] = new Pokemon("Necrozma", "Psychic", 150, 40, 35, 0.05);
        storage[7,0] = new Pokemon("Yamper", "Electric", 100, 20, 20, 0.5);
        storage[7,1] = new Pokemon("Wooloo", "Normal", 100, 20, 20, 0.5);
        storage[7,2] = new Pokemon("Dreepy", "Ghost", 120, 30, 30, 0.25);
        storage[7,3] = new Pokemon("Dracovish", "Dragon", 100, 20, 20, 0.5);
        storage[7,4] = new Pokemon("Eternatus", "Poison", 150, 40, 35, 0.05);
        storage[8,0] = new Pokemon("Pawmi", "Electric", 100, 20, 20, 0.5);
        storage[8,1] = new Pokemon("Charcadet", "Fire", 100, 20, 20, 0.5);
        storage[8,2] = new Pokemon("Frigibax", "Ice", 120, 30, 30, 0.25);
        storage[8,3] = new Pokemon("Finizen", "Water", 100, 20, 20, 0.5);
        storage[8,4] = new Pokemon("Miraidon", "Electric", 150, 40, 35, 0.05);
        Pokemon[] list = new Pokemon[5];
        for(int i = 0; i < 5; i++)
        {
            list[i] = storage[x,i];
        }
        
    }

    public string getRoomName()
    {
        return name;
    }

    public Pokemon Catch(string name)
    {
        for (int i = 0;i < 9; i++) {
            for (int j = 0;j < 5; j++) {
                if ((storage[i,j].getName()).Equals(name)) {
                    return storage[i,j];
                }
            }
        }
        return null;
        
    }

    public void help()
    {
        Console.WriteLine("Move ____: Move in the in the direction you specify (e.g. Move North)\n");
        Console.WriteLine("Catch ____: Catch the Pokemon you specify (e.g. Catch Pikachu)\n");
        Console.WriteLine("Inspect ____: Inspect a Pokemon in your inventory (e.g. Inspect Pikachu)\n");
        Console.WriteLine("Battle: Start a Battle\n");
    }

    public string inspect(Pokemon[] arlist1, int i)
    {
        Pokemon[] tempInv = new Pokemon[6];
        tempInv = arlist1;
        if(i > 0 && i < tempInv.Length && tempInv[i] != null)
        {
            String stats = "Name: " + tempInv[i].getName() + ",Type:  " + tempInv[i].getType() + ", HP: " + tempInv[i].getHp()
            + ", ATK: " + tempInv[i].getAtk() + ", SPD: " + tempInv[i].getSpd() + ", Status: " + tempInv[i].getStatus();
        }
        else
        {
        return "Position is not Valid";
        }
        return null;
    }



}

class Pokemon
{
    private string name;
    private string type;
    private int hp;
    private int atk; 
    private int spd;
    private bool alive;
    private double rarity;
    public Pokemon(string n, string t, int h, int a, int s, double e){
        name = n; type = t; hp = h; atk = a; spd = s; alive = true; rarity = e;
    }

    public string getName()
    {
        return name;
    }

    public string getType()
    {
        return type;
    }

    public int getHp()
    {
        return hp;
    }

    public int getAtk()
    {
        return atk;
    }

    public int getSpd()
    {
        return spd;
    }

    public bool getStatus()
    {
        return alive;
    }

}

class grass
{





}

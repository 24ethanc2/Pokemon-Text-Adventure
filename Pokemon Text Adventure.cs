Using System;
Class Main
{
    static void Main() 
    {
        Rooms[] roomList = new Room[9];
        var inventory = new ArrayList();
        roomList[0] = new Room("Kanto", 0); roomList[1] = new Room("Johto", 1); roomList[2] = new Room("Unova", 2);
        roomList[3] = new Room("Hoenn", 3); roomList[4] = new Room("Sinnoh", 4); roomList[5] = new Room("Kalos", 5);
        roomList[6] = new Room("Alola", 6); roomList[7] = new Room("Galar", 7); roomList[8] = new Room("Paldea", 8);
        Console.WriteLine("Welcome to Pokemon Text Adventure")
        Console.WriteLine("In this game, you will be able to explore all 9 regions of Pokemon");
        Console.WriteLine("You will have to catch pokemons in order to beat the final boss: Arceus himself");
        Console.WriteLine("But first, let's get you your first starter pokemon");
        while(true)
        {
            Console.WriteLine("Please Choose your first starter:  | 1: Bulbasaur | 2: Charmander | 3: Squirtle | ")
            int choice = Console.ReadLine().ParseInt();
            if(choice == 1)
            {
                inventory.addRange(new Pokemon("Bulbasaur", "Grass", 100, 20, 20, 1));
                break;
            }
            else if(choice == 2)
            { 
                inventory.addRange(new Pokemon("Charmander", "Fire", 100, 20, 20, 1));
                break;
            }
            else if(choice == 3)
            {
                inventory.addRange(new Pokemon("Squirtle", "Water", 100, 20, 20, 1));
                break;
            }
            else{
                Console.WriteLine("Invalid Choice, Please type a Number");
            }
        }
    }
}

Class Rooms
{
    private String name;
    private Pokemon[][] storage;
    private static inventory = new ArrayList();
    storage = new Pokemon[9][5];
        storage[0][0] = new Pokemon("Pikachu", "Electric", 100, 20, 20, 0.5);
        storage[0][1] = new Pokemon("Eevee", "Normal", 100, 20, 20, 0.5);
        storage[0][2] = new Pokemon("Dratini", "Dragon", 120, 30, 30, 0.25);
        storage[0][3] = new Pokemon("Magikarp", "Water", 100, 20, 20, 0.5);
        storage[0][4] = new Pokemon("Mewtwo", "Psychic", 150, 40, 35, 0.05);
        storage[1][0] = new Pokemon("Wooper", "Water", 100, 20, 20, 0.5);
        storage[1][1] = new Pokemon("Larvitar", "Rock", 120, 30, 30, 0.25);
        storage[1][2] = new Pokemon("Mareep", "Electric", 100, 20, 20, 0.5);    
        storage[1][3] = new Pokemon("Houndour", "Dark", 100, 20, 20, 0.5);
        storage[1][4] = new Pokemon("Ho-oh", "Flying", 150, 40, 35, 0.05);
        storage[2][0] = new Pokemon("Ralts", "Psychic", 100, 20, 20, 0.5);
        storage[2][1] = new Pokemon("Slakoth", "Normal", 100, 20, 20, 0.5);
        storage[2][2] = new Pokemon("Beldum", "Steel", 120, 30, 30, 0.25);
        storage[2][3] = new Pokemon("Wailmer", "Water", 100, 20, 20, 0.5);
        storage[2][4] = new Pokemon("Rayquaza", "Dragon", 150, 40, 35, 0.05);
        storage[3][0] = new Pokemon("Starly", "Flying", 100, 20, 20, 0.5);
        storage[3][1] = new Pokemon("Riolu", "Fighting", 100, 20, 20, 0.5);
        storage[3][2] = new Pokemon("Gabite", "Dragon", 120, 30, 30, 0.25);
        storage[3][3] = new Pokemon("Munchlax", "Normal", 100, 20, 20, 0.5);
        storage[3][4] = new Pokemon("Dialga", "Steel", 150, 40, 35, 0.05);
        storage[4][0] = new Pokemon("Axew", "Dragon", 100, 20, 20, 0.5);
        storage[4][1] = new Pokemon("Litwick", "Ghost", 100, 20, 20, 0.5);
        storage[4][2] = new Pokemon("Zorua", "Dark", 100, 20, 20, 0.5);
        storage[4][3] = new Pokemon("Pawniard", "Dark", 100, 20, 20, 0.5);
        storage[4][4] = new Pokemon("Kyurem", "Dragon", 150, 40, 35, 0.05);
        storage[5][0] = new Pokemon("Honedge", "Steel", 100, 20, 20, 0.5);
        storage[5][1] = new Pokemon("Froakie", "Water", 100, 20, 20, 0.5);
        storage[5][2] = new Pokemon("Fletchling", "Flying", 100, 20, 20, 0.5);
        storage[5][3] = new Pokemon("Gloomy", "Dragon", 120, 30, 30, 0.25);
        storage[5][4] = new Pokemon("Zygarde", "Dragon", 150, 40, 35, 0.05);
        storage[6][0] = new Pokemon("Litten", "Fire", 100, 20, 20, 0.5);
        storage[6][1] = new Pokemon("Rockruff", "Rock", 100, 20, 20, 0.5);
        storage[6][2] = new Pokemon("Mimikyu", "Ghost", 100, 20, 20, 0.5);
        storage[6][3] = new Pokemon("Jangmo-o", "Fighting", 120, 30, 30, 0.25);
        storage[6][4] = new Pokemon("Necrozma", "Psychic", 150, 40, 35, 0.05);
        storage[7][0] = new Pokemon("Yamper", "Electric", 100, 20, 20, 0.5);
        storage[7][1] = new Pokemon("Wooloo", "Normal", 100, 20, 20, 0.5);
        storage[7][2] = new Pokemon("Dreepy", "Ghost", 120, 30, 30, 0.25);
        storage[7][3] = new Pokemon("Dracovish", "Dragon", 100, 20, 20, 0.5);
        storage[7][4] = new Pokemon("Eternatus", "Poison", 150, 40, 35, 0.05);
        storage[8][0] = new Pokemon("Pawmi", "Electric", 100, 20, 20, 0.5);
        storage[8][1] = new Pokemon("Charcadet", "Fire", 100, 20, 20, 0.5);
        storage[8][2] = new Pokemon("Frigibax", "Ice", 120, 30, 30, 0.25);
        storage[8][3] = new Pokemon("Finizen", "Water", 100, 20, 20, 0.5);
        storage[8][4] = new Pokemon("Miraidon", "Electric", 150, 40, 35, 0.05);
    
    Public Class Rooms(String n, int x)
    {   

        Pokemon[] PokemonList = storage[x];

    }

    Public String getRoomName()
    {
        return name;
    }
    
    Public void catch(String name)
     {
        for (int i = 0;i < 9; i++) {
            for (int j = 0;j < 5; j++) {
                if ((storage[i][j].getName()).Equals(name)) {
                    return storage[i][j];
                }
            }
        }
     }

    Public void help(){
        Console.WriteLine("Move ____: Move in the in the direction you specify (e.g. Move North)\n")
        Console.WriteLine("Catch ____: Catch the Pokemon you specify (e.g. Catch Pikachu)\n")
        Console.WriteLine("Inspect ____: Inspect a Pokemon in your inventory (e.g. Inspect Pikachu)\n")
        Console.WriteLine("Battle: Start a Battle\n")
    }

    Public String inspect(var arlist1, int i)
    {
        var tempInv = new ArrayList();
        tempInv = arlist1;
        if(i > 0 && i < tempInv.getRange())
        {
            String stats = "Name: " + tempInv[i].getName() + ",Type:  " + tempInv[i].getType() + ", HP: " + tempInv[i].getHp()
            + ", ATK: " + tempInv[i].getAtk() + ", SPD: " + tempInv[i].getSpd() + ", Status: " + tempInv[i].getStatus();
        }
        else
        {
        return "Position is not Valid";
        }
    }




}

Class Pokemon
{
    private string name;
    private string type;
    private int hp;
    private int atk; 
    private int spd;
    private boolean alive;
    private float rarity;
    public Pokemon(String n, String t, int h, int s, float s){
        name = n; type = t; hp = h; atk = h, spd = s; alive = true; rarity = s;
    }

    public String getName()
    {
        return name;
    }

    public String getType()
    {
        return type;
    }

    public int getHp()
    {
        return hp;
    }

    publc int getAtk()
    {
        return atk;
    }

    public int getSpd()
    {
        return spd;
    }

    public boolean getStatus()
    {
        return alive;
    }

}

Class grass
{





}

using System;
class Runner
{
    static void Main() 
    {
        Pokemon[] inventory = new Pokemon[6];
        Rooms[,] roomList = new Rooms[3,3];
        String name;
        String ans;
        String spawnedPoke;
        int invNum = 0;
        player trainer = new player(0,0);
        roomList[0,0] = new Rooms("Kanto", 0); roomList[0,1] = new Rooms("Hoenn", 2); roomList[0,2] = new Rooms("Alola", 6);
        roomList[1,0] = new Rooms("Johto", 1); roomList[1,1] = new Rooms("Sinnoh", 3); roomList[1,2] = new Rooms("Galar", 7);
        roomList[2,0] = new Rooms("Unova", 4); roomList[2,1] = new Rooms("Kalos", 5); roomList[2,2] = new Rooms("Paldea", 8);
        Console.WriteLine("Welcome to Pokemon Text Adventure");
        Console.WriteLine("What is your name? *default name is John");
        name = Console.ReadLine();
        if(name.Equals(""))
        {
            name = "John";
        }
        Console.WriteLine("Welcome, Trainer " + name + ". In this game, you will be able to explore all 9 regions of Pokemon");    
        Console.WriteLine("You will have to catch pokemons in order to beat the final boss: Arceus himself");
        Console.WriteLine("But first, let's get you your first starter pokemon");
        Console.WriteLine("Please Choose your first starter:  \n| 1: Bulbasaur | 2: Charmander | 3: Squirtle | ");
        int choice = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            inventory[0] = new Pokemon("Bulbasaur", "Grass", 100, 20, 20, 1, new string[2] {"Ivysaur", "Venasaur"});
                invNum++;
        }
        else if(choice == 2)
        { 
            inventory[0] = new Pokemon("Charmander", "Fire", 100, 20, 20, 1, new string[2] {"Charmeleon", "Charizard"});
                invNum++;
        }
        else if(choice == 3)
        {
            inventory[0] = new Pokemon("Squirtle", "Water", 100, 20, 20, 1, new string[2] {"Wartortle", "Blastoise"});
                invNum++;
        }
        Console.WriteLine("You've chosen " + inventory[0].getName() + "!");
        Console.WriteLine("Great Choice");
        roomList[0,0].setPlayer(true);
        bool test = true;
        bool finalStage = false;
        while(finalStage == false){
        for (int r = 0 ; r<3; r ++){
            for(int c = 0; c <3 ; c++){
                if (test == true && roomList[r,c].getPlayer() == true){
                    Console.WriteLine("You are in " + roomList[r,c].getRoomName());
                    Console.WriteLine("There is some bushes, type bushes to go in to explore!!");
                    if (Console.ReadLine() == "bushes"){
                        spawnedPoke = roomList[r,c].spawn();
                        if(spawnedPoke.Equals(""))
                        {
                            Console.WriteLine("No Pokemon Spawned! How Unlucky!");
                        }
                        else
                        {
                            Console.WriteLine("You see these pokemons: " + spawnedPoke + "\n");
                            String[] spawnedList = spawnedPoke.Split(" ");
                            Console.WriteLine("Pick one to catch::");
                            ans = Console.ReadLine();
                            
                            for(int i = 0; i < spawnedList.Length; i++){
                                if(ans.Equals(spawnedList[i])){
                                    if(invNum < 6){
                                        Pokemon newPoke = roomList[r,c].Catch(ans.ToLower());
                                        inventory[invNum] = newPoke;
                                        Console.WriteLine("You've caught a " + inventory[invNum].getName() + "!");
                                        invNum++;
                                        break;
                                    }
                                    else{
                                        Console.WriteLine("Your inventory is full");
                                        Console.WriteLine("You are now going to battle Arceus");
                                        finalStage = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if(finalStage == false){
                        
                    
                    Console.WriteLine("Enter direction::");
                    string input = Console.ReadLine().ToLower();
                    test = false;
                    if(input.Equals("north") && r>0){
                        roomList[r,c].setPlayer(false);
                        roomList[r-1, c].setPlayer(true);
                    }
                    else if(input.Equals("south") && r<2){
                        roomList[r, c].setPlayer(false);
                        roomList[r+1, c].setPlayer(true);
                    }
                    else if(input.Equals("east") && c<2){
                        roomList[r, c].setPlayer(false);
                        roomList[r, c+1].setPlayer(true);
                    }
                    else if(input.Equals("west") && c>0){
                        roomList[r, c].setPlayer(false);
                        roomList[r, c-1].setPlayer(true);
                    }
                    }
                }
            }
        }
        
        test = true;
        }
        bool win = false;
        Console.WriteLine("Battle Arceus Begin!!!");
        int arceusHp = 200;
        for (int i = 0; i < inventory.Length; i++){
            while(inventory[i].getHp()>0){
                Console.WriteLine("Your " + inventory[i].getName() + " is chosen to battle!");
                Random random = new Random();
                int randomNumber = random.Next(25, 90);
                Console.WriteLine("Arceus deals " + randomNumber);
                inventory[i].setHp(randomNumber);
                Console.WriteLine(inventory[i].getName() + " has the remaining health of " + inventory[i].getHp());
                if(inventory[i].getHp()<0){
                    Console.WriteLine("Oh no..." + inventory[i].getName() + " died!");
                    break;
                }
                else{
                    Console.WriteLine("Type attack to fight back");
                    string move = Console.ReadLine();
                    if (move.Equals("attack")){
                        arceusHp -= inventory[i].getAtk();
                        Console.WriteLine("Arceus health is now " + arceusHp);
                        if(arceusHp < 0){
                            win = true;
                            break;
                        }
                    }
                }
            }
        }
        if(win){
            Console.WriteLine("You won!!! Congratulation!");
        }
        else{
            Console.WriteLine("All your pokemon died. You lost...Good luck next time!");
        }
    }
}

class Rooms
{
    private string name;
    private Pokemon[,] storage;
    private Pokemon[] list;
    private bool player;
    
    public Rooms(string n, int x)
    {
        player = false;
        name = n;
        storage = new Pokemon[9,5];
        storage[0,0] = new Pokemon("Pikachu", "Electric", 100, 20, 20, 0.5, new string[2] {"Raichu", null});
        storage[0,1] = new Pokemon("Eevee", "Normal", 100, 20, 20, 0.5, new string[2] {"Leafeon", null});
        storage[0,2] = new Pokemon("Dratini", "Dragon", 120, 30, 30, 0.25, new string[2] {"Dragonair", "Dragonite"});
        storage[0,3] = new Pokemon("Magikarp", "Water", 100, 20, 20, 0.5, new string[2] {"Gyarados", null});
        storage[0,4] = new Pokemon("Mewtwo", "Psychic", 150, 40, 35, 0.05, new string[2] {null, null});
        storage[1,0] = new Pokemon("Wooper", "Water", 100, 20, 20, 0.5, new string[2] {"Quagsire", null});
        storage[1,1] = new Pokemon("Larvitar", "Rock", 120, 30, 30, 0.25, new string[2] {"Pupitar", "Tyranitar"});
        storage[1,2] = new Pokemon("Mareep", "Electric", 100, 20, 20, 0.5, new string[2] {"Flaaffy", "Ampharos"});    
        storage[1,3] = new Pokemon("Houndour", "Dark", 100, 20, 20, 0.5, new string[2] {"Houndoom", null});
        storage[1,4] = new Pokemon("Ho-oh", "Flying", 150, 40, 35, 0.05, new string[2] {null, null});
        storage[2,0] = new Pokemon("Ralts", "Psychic", 100, 20, 20, 0.5, new string[2] {"Kirlia", "Gardevoir"});
        storage[2,1] = new Pokemon("Slakoth", "Normal", 100, 20, 20, 0.5, new string[2] {"Vigoroth", "Slaking"});
        storage[2,2] = new Pokemon("Beldum", "Steel", 120, 30, 30, 0.25, new string[2] {"Metang", "Metagross"});
        storage[2,3] = new Pokemon("Wailmer", "Water", 100, 20, 20, 0.5, new string[2] {"Wailord", null});
        storage[2,4] = new Pokemon("Rayquaza", "Dragon", 150, 40, 35, 0.05, new string[2] {null, null});
        storage[3,0] = new Pokemon("Starly", "Flying", 100, 20, 20, 0.5, new string[2] {"Staravia", "Staraptor"});
        storage[3,1] = new Pokemon("Riolu", "Fighting", 100, 20, 20, 0.5, new string[2] {"Lucario", null});
        storage[3,2] = new Pokemon("Gible", "Dragon", 120, 30, 30, 0.25, new string[2] {"Gabite", "Garchomp"});
        storage[3,3] = new Pokemon("Munchlax", "Normal", 100, 20, 20, 0.5, new string[2] {"Snorlax", null});
        storage[3,4] = new Pokemon("Dialga", "Steel", 150, 40, 35, 0.05, new string[2] {null, null});
        storage[4,0] = new Pokemon("Axew", "Dragon", 100, 20, 20, 0.5, new string[2] {"Fraxure", "Haxorus"});
        storage[4,1] = new Pokemon("Litwick", "Ghost", 100, 20, 20, 0.5, new string[2] {"Lampent", "Chandelure"});
        storage[4,2] = new Pokemon("Zorua", "Dark", 100, 20, 20, 0.5, new string[2] {"Zoroark", null});
        storage[4,3] = new Pokemon("Pawniard", "Dark", 100, 20, 20, 0.5, new string[2] {"Bisharp", "Kingambit"});
        storage[4,4] = new Pokemon("Kyurem", "Dragon", 150, 40, 35, 0.05, new string[2] {null, null});
        storage[5,0] = new Pokemon("Honedge", "Steel", 100, 20, 20, 0.5, new string[2] {"Doublade", "Aegislash"});
        storage[5,1] = new Pokemon("Froakie", "Water", 100, 20, 20, 0.5, new string[2] {"Frogadier", "Greninja"});
        storage[5,2] = new Pokemon("Fletchling", "Flying", 100, 20, 20, 0.5, new string[2] {"Fletchinder", "Talonflame"});
        storage[5,3] = new Pokemon("Goomy", "Dragon", 120, 30, 30, 0.25, new string[2] {"Sliggoo", "Goodra"});
        storage[5,4] = new Pokemon("Zygarde", "Dragon", 150, 40, 35, 0.05, new string[2] {null, null});
        storage[6,0] = new Pokemon("Litten", "Fire", 100, 20, 20, 0.5, new string[2] {"Torracat", "Incineroar"});
        storage[6,1] = new Pokemon("Rockruff", "Rock", 100, 20, 20, 0.5, new string[2] {"Lycanroc", null});
        storage[6,2] = new Pokemon("Mimikyu", "Ghost", 100, 20, 20, 0.5, new string[2] {null, null});
        storage[6,3] = new Pokemon("Jangmo-o", "Fighting", 120, 30, 30, 0.25, new string[2] {"Hakamo-o", "Kommo-o"});
        storage[6,4] = new Pokemon("Necrozma", "Psychic", 150, 40, 35, 0.05, new string[2] {null, null});
        storage[7,0] = new Pokemon("Yamper", "Electric", 100, 20, 20, 0.5, new string[2] {"Boltund", null});
        storage[7,1] = new Pokemon("Wooloo", "Normal", 100, 20, 20, 0.5, new string[2] {"Dubwool", null});
        storage[7,2] = new Pokemon("Dreepy", "Ghost", 120, 30, 30, 0.25, new string[2] {"Drakloak", "Dragapult"});
        storage[7,3] = new Pokemon("Dracovish", "Dragon", 100, 20, 20, 0.5, new string[2] {null, null});
        storage[7,4] = new Pokemon("Eternatus", "Poison", 150, 40, 35, 0.05, new string[2] {null, null});
        storage[8,0] = new Pokemon("Pawmi", "Electric", 100, 20, 20, 0.5, new string[2] {"Pawmo", "Pawmot"});
        storage[8,1] = new Pokemon("Charcadet", "Fire", 100, 20, 20, 0.5, new string[2] {"Armarouge", null});
        storage[8,2] = new Pokemon("Frigibax", "Ice", 120, 30, 30, 0.25, new string[2] {"Arctibax", "Baxcalibur"});
        storage[8,3] = new Pokemon("Finizen", "Water", 100, 20, 20, 0.5, new string[2] {"Palafin", null});
        storage[8,4] = new Pokemon("Miraidon", "Electric", 150, 40, 35, 0.05, new string[2] {null, null});
        list = new Pokemon[5];
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
                if ((storage[i,j].getName().ToLower()).Equals(name)) {
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
            string stats = "Name: " + tempInv[i].getName() + ",Type:  " + tempInv[i].getType() + ", HP: " + tempInv[i].getHp()
            + ", ATK: " + tempInv[i].getAtk() + ", SPD: " + tempInv[i].getSpd() + ", Status: " + tempInv[i].getStatus();
        }
        else
        {
        return "Position is not Valid";
        }
        return null;
    }

    public void description(string n, String name)
    {
        Console.WriteLine("Welcome to " + n + " region, Trainer " + name + ". Please feel free to explore around and catch Pokemons");
    }
    
    public string spawn() {
        Random rnd = new Random();
        string spawns = "";
        for (int i=0;i<list.Length;i++) {
            double spawning = rnd.NextDouble();
            if (spawning < list[i].getRarity())
            {
                spawns += list[i].getName() + " ";
            }
        }
        return spawns;
    }
    
    public void setPlayer(bool x){
        player = x;
    }
    
    public bool getPlayer(){
        return player;
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
    private string[] evo;
    private bool evol1;
    private bool evol2;
    private bool evolved1;
    private bool evolved2;
    public Pokemon(string n, string t, int h, int a, int s, double e, string[] p){
        name = n; type = t; hp = h; atk = a; spd = s; alive = true; rarity = e;evo = p; evol1 = false; evol2 = false; evolved1 = false; evolved2 = false;
        if(evo[0]!= null)
        {
            evol1 = true;
        }
        if(evo[1]!= null)
        {
            evol2 = true;
        }
        
    }

    public void setHp(int dmg){
        hp -= dmg;
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

    public double getRarity() 
    {
        return rarity;
    }

    public string[] getEvolutions() 
    {
        return evo;
    }

    public void firstEvo()
    {
        evolved1 = true;
        name = evo[0];
    }

    public void secondEvo()
    {
        evolved2 = true;
        name = evo[1];
    }
}

public class player{
  private Rooms[,] map = new Rooms[3,3];
  private int xLoc;
  private int yLoc;
  public player(int x, int y){
    map[0,0] = new Rooms("Kanto", 0); map[0,1] = new Rooms("Hoenn", 2); map[0,2] = new Rooms("Alola", 6);
        map[1,0] = new Rooms("Johto", 1); map[1,1] = new Rooms("Sinnoh", 3); map[1,2] = new Rooms("Galar", 7);
        map[2,0] = new Rooms("Unova", 4); map[2,1] = new Rooms("Kalos", 5); map[2,2] = new Rooms("Paldea", 8);
    map[x,y].setPlayer(true);
    xLoc = x;
    yLoc = y;
  }
  public void move(){
    for (int r = 0; r < 3; r++){
      for(int c = 0; c<4; c++){
        if(map[r, c].getPlayer() == true){
          //ask user north south east west
          Console.WriteLine("Enter direction::");
          string input = Console.ReadLine().ToLower();
          if(input.Equals("north") && r>0){
            map[r,c].setPlayer(false);
            map[r-1, c].setPlayer(true);
            xLoc = r-1;
            return;
          }
          else if(input.Equals("south") && r<2){
            map[r, c].setPlayer(false);
            map[r+1, c].setPlayer(true);
            xLoc = r+1;
            return;
          }
          else if(input.Equals("east") && c<2){
            map[r, c].setPlayer(false);
            map[r, c+1].setPlayer(true);
            yLoc = c+1;
            return;
          }
          else if(input.Equals("west") && c>0){
            map[r, c].setPlayer(false);
            map[r, c-1].setPlayer(true);
            yLoc = c-1;
            return;
          }
         else{
            Console.WriteLine("Direction is not valid");
            move();
            return;
         }
        }
      }
    }
  }
public string roomName()
{
    return map[xLoc,yLoc].getRoomName();
}
}

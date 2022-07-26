using System;
public class  SuperPowerGenerator
{
    private readonly Random _random = new Random();
    
    public int RandomNumber(int min = 5, int max = 10)
    {
        return _random.Next(min, max);
    }
    static void Main(string[] args)
    {
        SuperPowerGenerator myObj = new SuperPowerGenerator();
        int NewmyObj = myObj.RandomNumber();
        Warrior warrior = null;
        Warrior enemy = null;

        Console.WriteLine("Choose 1-generate super power; 2- choose hero and enemy; 3 - choose super power");
        Console.WriteLine("Choose 1-generate super power; 2- choose hero and enemy; 3 - choose super power");
        while (true)
        {   
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("generate super power");
                    Console.WriteLine(myObj.RandomNumber());
                    continue;
                case "2":
                    Console.WriteLine("choose your hero 1-bowman; 2-barbarian; 3-golem; 4-witch.");
                    switch (Console.ReadLine())
                    {
                      case "1":
                          Console.WriteLine("Your hero is Bowman");
                          warrior = new Bowman();
                          break;
                      case "2":
                          Console.WriteLine("Your hero is Barbarian");
                          warrior = new Barbarian();
                          break;
                      case "3":
                          Console.WriteLine("Your hero is Golem");
                          warrior = new Golem();
                          break;
                      case "4":
                          Console.WriteLine("Your hero is Witch");
                          warrior = new Witch();
                          break;
                    }
                    Console.WriteLine("choose the enemy");
                    Console.WriteLine("1-bowman; 2-barbarian; 3-golem; 4-witch.");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Your enemy is Bowman");
                            warrior = new Bowman();
                            break;
                        case "2":
                            Console.WriteLine("Your enemy is Barbarian");
                            warrior = new Barbarian();
                            break;
                        case "3":
                            Console.WriteLine("Your enemy is Golem");
                            warrior = new Golem();
                            break;
                        case "4":
                            Console.WriteLine("Your enemy is Witch");
                            warrior = new Witch();
                            break;
                    }
                    continue;
                 case "3":
                    Console.WriteLine("choose super power 1-health 2-armor 3-damage");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            warrior.AddSuperPower(new HP(),NewmyObj);
                            break;
                        case "2":
                            warrior.AddSuperPower(new Armor(),NewmyObj);
                            break;
                        case "3":
                            warrior.AddSuperPower(new Brunt(),NewmyObj);
                            break;
                            
                    }
                     continue;
                 case "0":
                     break;


            }
            break;
     
        }
        Console.WriteLine(warrior);




    }
}
public abstract class Warrior 
{
    
    protected int life;
    protected int armor;
    protected int brunt;

    public virtual void AddSuperPower(SuperPower superPower,int myObj)
    {
        superPower.AddSuperPower(this,myObj);
    }

    public abstract int life1
    {
        get;
        set;
    }
    public abstract int brunt1
    {
        get;
        set;
    }
    public abstract int armor1
    {
        get;
        set;
    }
}

public class Bowman : Warrior
{
    public override int life1
    {
        get { return life; }
        set { life = 100; }

    }

    public override int brunt1
    {
        get
        {
            return brunt;
        }
        set
        {
            brunt = 15;
        }
    }

    public override int armor1
    {
        get
        {
            return armor;
        }
        set
        {
            armor = 5;
        }
}
}

class Barbarian : Warrior
{
    public override int life1
    {
        get { return life; }
        set { life = 100; }

    }

    public override int brunt1
    {
        get
        {
            return brunt;
        }
        set
        {
            brunt = 10;
        }
    }

    public override int armor1
    {
        get
        {
            return armor;
        }
        set
        {
            armor = 10;
        }
    }
}

class Golem : Warrior
{
    public override int life1
    {
        get { return life; }
        set { life = 100; }

    }

    public override int brunt1
    {
        get
        {
            return brunt;
        }
        set
        {
            brunt = 7;
        }
    }

    public override int armor1
    {
        get
        {
            return armor;
        }
        set
        {
            armor = 13;
        }
    }
}

class Witch : Warrior
{
    public override int life1
    {
        get { return life; }
        set { life = 100; }

    }

    public override int brunt1
    {
        get
        {
            return brunt;
        }
        set
        {
            brunt = 12;
        }
    }

    public override int armor1
    {
        get
        {
            return armor;
        }
        set
        {
            armor = 8;
        }
    }
}

public interface SuperPower
{ 
    void AddSuperPower (Warrior warrior, int power);

}
public class HP : SuperPower
{
    public void AddSuperPower(Warrior warrior, int power)
    {
        warrior.life1 += power;
    }
    
}

public class Armor : SuperPower {
    public void AddSuperPower(Warrior warrior, int power)
    {
        warrior.armor1 += power;
    }
}

public class Brunt : SuperPower {
    public void AddSuperPower(Warrior warrior, int power)
    {
        warrior.brunt1 += power;
    }
}

static class FightField
{
    public static void Fight(Warrior warrior1, Warrior warrior2)
    {
        bool life;
        if (warrior1.life1 > 0)
        {
            life = true;
        }
        else
        {
            life = false;
        }
    }

    private static void Defend(Warrior warrior, int damage)
    {
        if (warrior.armor1 >0)
        {
            warrior.life1 -= damage / 2;
            warrior.armor1 -= damage / 2;
        }
        else
        {
            warrior.life1 -= damage;
        }
    }

    private static void Attack(Warrior DefendWarrior, Warrior AttackWarrior)
    {
       
        if (AttackWarrior.armor1 > 0)
        {
            AttackWarrior.brunt1 = AttackWarrior.brunt1;
        }
        else
        {
            AttackWarrior.brunt1 -= 1;
        }

        if (AttackWarrior.brunt1 == 1)
        {
            AttackWarrior.brunt1 = 1;
        }
    }

}
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> damageCoefitiens = new Dictionary<string, double>()
        {
            {string.Concat(AttackType.Magic.ToString(), ArmorType.Heavy.ToString()), 1.25 }
        };

        string attack = AttackType.Magic.ToString();
        string armor = ArmorType.Heavy.ToString();

        string attackArmorCombo = string.Concat(attack, armor);
        int damage = 30;
        double coefficient = damageCoefitiens[attackArmorCombo];
        int attackPoints = (int)Math.Floor(damage * coefficient);


        Console.WriteLine(attackPoints);



    }


    public enum AttackType
    {
        Ranged,
        Melee,
        Magic
    }

    public enum ArmorType
    {
        Light,
        Medium,
        Heavy
    }
}

/*
You should be able to use Linq here:

var matchingvalues = myList
    .Where(stringToCheck => stringToCheck.Contains(myString));
If you simply wish to return the first matching item:

var match = myList
    .FirstOrDefault(stringToCheck => stringToCheck.Contains(myString));

if(match != null)
*/





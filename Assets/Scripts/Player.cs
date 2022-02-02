using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character  // INHERITANCE
{
    public override void Attack()  // POLYMORPHISM
    {
        Debug.Log($"{CharacterName} smashes the enemy with his greataxe!");
    }

    public override void Defend()  // POLYMORPHISM
    {
        Debug.Log($"{CharacterName} raises his shield just in time!");
    }
}


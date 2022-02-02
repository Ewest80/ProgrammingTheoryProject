using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character  // INHERITANCE
{
    public override void Attack()  // POLYMORPHISM
    {
        Debug.Log($"{CharacterName} slices the player with his claws");
    }

    public override void Defend()  // POLYMORPHISM
    {
        Debug.Log($"{CharacterName} leaps out of the player's reach");
    }
}

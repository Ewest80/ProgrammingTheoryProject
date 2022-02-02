using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public override void Attack()
    {
        Debug.Log($"{CharacterName} swings his sword at the enemy!");
    }

    public override void Defend()
    {
        Debug.Log($"{CharacterName} raises his shield just in time!");
    }
}


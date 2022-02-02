using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public override void Attack()
    {
        Debug.Log($"{CharacterName} slices the player with his claws");
    }

    public override void Defend()
    {
        Debug.Log($"{CharacterName} leaps out of the player's reach");
    }
}

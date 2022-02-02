using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected string characterName;

    public string CharacterName
    {
        get => characterName;
        set => characterName = value;
    }
    protected float health;

    public float Health
    {
        get { return health; }
        set
        {
            if (value > 100f)
            {
                value = 100f;
            }
            else if (value < 0f)
            {
                value = 0f;
            }

            health = value;
        }
    }
    private int armorClass;

    public int ArmorClass
    {
        get { return armorClass; }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            else if (value > 10)
            {
                value = 10;
            }

            armorClass = value;
        }
    }

    public virtual void Attack()
    {
        Debug.Log($"{characterName} swings wildly");
    }

    public virtual void Defend()
    {
        Debug.Log($"{characterName} somehow avoids the wild attack");
    }
}

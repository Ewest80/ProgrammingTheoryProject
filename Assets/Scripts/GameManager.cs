using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerCharacter;
    public GameObject enemyCharacter;
    
    private Player player;
    private Enemy enemy;
    private void Start()
    {
        player = playerCharacter.GetComponent<Player>();
        enemy = enemyCharacter.GetComponent<Enemy>();

        player.CharacterName = "Bunder";
        player.Health = 100;
        player.ArmorClass = 4;

        enemy.CharacterName = "Snorty";
        enemy.Health = 50;
        enemy.ArmorClass = 2;
    }
}

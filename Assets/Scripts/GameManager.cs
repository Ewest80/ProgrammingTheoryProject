using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    public GameObject playerCharacter;
    public GameObject enemyCharacter;
    
    private Player player;
    private Enemy enemy;

    private int combatRound = 1;
    
    private void Start()
    {
        player = playerCharacter.GetComponent<Player>();
        enemy = enemyCharacter.GetComponent<Enemy>();

        player.CharacterName = "Blunder";
        player.Health = 100;
        player.ArmorClass = 4;

        enemy.CharacterName = "Snorty";
        enemy.Health = 50;
        enemy.ArmorClass = 2;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartAttackRound();
        }
    }

    private void StartAttackRound()
    {
        int playerAttack = Random.Range(0, 11);
        int enemyAttack = Random.Range(0, 11);

        Debug.Log("Combat Round #" + combatRound);
        combatRound++;
        
        if (playerAttack > enemy.ArmorClass)
        {
            Debug.Log("Attack Hits! Roll: " + playerAttack);
            player.Attack();
        }
        else
        {
            Debug.Log("Attack Misses! Roll: " + playerAttack);
            enemy.Defend();
        }

        if (enemyAttack > player.ArmorClass)
        {
            Debug.Log("Attack Hits! Roll: " + enemyAttack);
            enemy.Attack();
        }
        else
        {
            Debug.Log("Attack Misses! Roll: " + enemyAttack);
            player.Defend();
        }
        Debug.Log("----------------------------");
    }
}

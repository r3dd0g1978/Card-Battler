using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{


    public static BattleController instance;

    public int startingMana = 4, maxMana = 12;
    public int playerMana;


    void Awake()
    {
        instance = this;    
    }


    void Start()
    {
        playerMana = startingMana;
        UIController.instance.SetPlayerManaText(playerMana);
    }


    void Update()
    {
        
    }

    public void SpendPlayerMana(int amountToSpend)
    {
        playerMana = playerMana - amountToSpend;

        if (playerMana < 0)
        {
            playerMana = 0;
        }

        UIController.instance.SetPlayerManaText(playerMana);
    }
}

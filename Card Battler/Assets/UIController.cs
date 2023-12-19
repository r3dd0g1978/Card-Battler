using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{

    public static UIController instance;
    public TMP_Text playerManaText;

    
    
    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetPlayerManaText(int manaAmount)
    {
        playerManaText.text = "Mana: " + manaAmount;
    }
}

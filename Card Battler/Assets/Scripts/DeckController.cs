using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour
{

    public static DeckController instance;

    public List<ScriptableObject> deckToUse = new List<ScriptableObject>();
    private List<ScriptableObject> activeCards = new List<ScriptableObject>();

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SetupDeck();
    }

    void Update()
    {
        
    }

    public void SetupDeck()
    {
        activeCards.Clear();

        List<ScriptableObject> tempDeck = new List<ScriptableObject>();
        tempDeck.AddRange(deckToUse);

        while (tempDeck.Count > 0)
        {
            int selected = Random.Range(0, tempDeck.Count);
            activeCards.Add(tempDeck[selected]);
            tempDeck.RemoveAt(selected);
        }
    }
}

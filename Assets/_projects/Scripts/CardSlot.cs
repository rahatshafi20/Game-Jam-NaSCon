using System.Collections.Generic;
using UnityEngine;
using static RuleSystem;
public class CardSlot : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();

    public void HideAll()
    {
        foreach (var card in cards)
            card.GetComponent<CardScript>().Hide(); 

    }

    public void ShowRandomCard()
    {
        HideAll(); // optional, in case any is visible
        int randomIndex = Random.Range(0, cards.Count);
        cards[randomIndex].GetComponent<CardScript>().Show();
    }

    public bool IsEmpty()
    {
        foreach (var card in cards)
        {
            if (card.activeSelf)
                return false;
        }
        return true;
    }

    public void ActivateRandomCard()
    {
        List<GameObject> inactiveCards = cards.FindAll(card => !card.activeSelf);

        if (inactiveCards.Count == 0)
            return;

        GameObject randomCard = inactiveCards[Random.Range(0, inactiveCards.Count)];
        randomCard.SetActive(true);
    }
}



using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeleteOnClick : MonoBehaviour
{
    public TMP_Text Card_counter;
    private void OnMouseDown()
    {
        TrySpawn();
    }
    public List<CardSlot> slots = new List<CardSlot>();

    public void TrySpawn()
    {
        foreach (CardSlot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.ActivateRandomCard();
                Debug.Log("spawn");
                removeCards();
                break; // Spawn in one empty slot only
            }
        }
    }
    public void removeCards()
    {
        //decrementing counter
        int num = int.Parse(Card_counter.text);
        num--;
        string num_str = num.ToString();
        if (num > 0)
            Card_counter.SetText(num_str);
        else
            Card_counter.SetText("Cards Finished");
        Destroy(gameObject);
    }
    private void Update()
    {
        // Just for demo: Press Space to try spawning
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TrySpawn();
        }
    }
}


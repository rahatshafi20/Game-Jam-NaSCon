using UnityEngine;

public class CardScript : MonoBehaviour
{
    private void Awake()
    {
        Hide(); // Start hidden
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked card with MouseDown");
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        Debug.Log("Hiding card");
        // Use this if you want to hide visuals but still receive clicks
        // GetComponent<SpriteRenderer>().enabled = false;
        // Or move it offscreen
        gameObject.SetActive(false); // but don't call this from OnMouseDown if you want reliable clicks
    }
}

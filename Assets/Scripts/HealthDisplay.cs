using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    TMP_Text healthText;

    void Awake()
    {
        healthText = GetComponent<TMP_Text> ();
    }

    public void UpdateHealthDisplay(int health)
    {
        healthText.text = $"Health: {health}";
    }
}

using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    TMP_Text scoreText;

    int currentScore;

    void Awake()
    {
        scoreText = GetComponent<TMP_Text> ();
        UpdateScore();
    }

    void OnEnable() => Collectible.OnAnyCollected += AddScore;
    void OnDisable() => Collectible.OnAnyCollected -= AddScore;

    void AddScore(int points)
    {
        currentScore += points;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = $"Score: {currentScore}";
    }
}

using UnityEngine;
using TMPro; // Import TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText; // Reference to TextMeshPro UI
    private int score = 0;

    void Start()
    {
        UpdateScoreUI();
    }

    public void UpdateScore(int amount)
    {
        score += amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
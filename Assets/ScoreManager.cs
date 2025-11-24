using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Link to the UI text
    private int score = 0; // Starting score

    void Start()
    {
        UpdateScoreText(); // Show initial score
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText(); // Update when score changes
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
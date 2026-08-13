using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;

    private bool gameOver = false;

    void Start()
    {
        playerScore = 0;
        scoreText.text = playerScore.ToString();

        gameOverScreen.SetActive(false);
    }

    public void AddScore(int scoreToAdd)
    {
        if (gameOver)
            return;

        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void GameOver()
    {
        if (gameOver)
            return;

        gameOver = true;
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
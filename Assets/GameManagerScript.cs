using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int health = 3;
    public int score = 0;

    public HealthUI healthUI;
    public GameObject gameOverScreen;
    public GameObject homeScreen;

    public Text scoreText;       // In-Game Score
    public Text GameOverscoreText;       // GameOver Score
    public Text highscoreText;   // GameOver Highscore
    public Text homeHighscore;   // Home Screen Highscore


    void Awake()
    {
        instance = this; // global verfügbar
    }

    void Start()
    {
        Time.timeScale = 0f; // Homescreen pausiert
        healthUI.UpdateHearts(health);
        homeScreen.SetActive(true);
        gameOverScreen.SetActive(false);
        UpdateHighscoreUI();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    // ▶️ Spiel starten
    public void StartGame()
    {
        Time.timeScale = 1f;

        homeScreen.SetActive(false);
        scoreText.text = "0";
        ResetGame();
    }

    // ❤️ Schaden
    public void TakeDamage(int amount)
    {
        health -= amount;
        healthUI.UpdateHearts(health);

        if (health <= 0)
        {
            GameOver();
        }
    }

    // ⭐ Score
    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }

    // 💀 Game Over
    void GameOver()
    {
        
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
        scoreText.text = "0";
        GameOverscoreText.text = "Score: " + score;
        int highscore = PlayerPrefs.GetInt("Highscore", 0);
        if (score > highscore)
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
        UpdateHighscoreUI();
    }

    // 🔄 Restart
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        Time.timeScale = 0f;
        gameOverScreen.SetActive(false);
        homeScreen.SetActive(true);
        RestartGame();
    }

    void ResetGame()
    {
        health = 3;
        score = 0;
        scoreText.text = "0";
        healthUI.UpdateHearts(health);
    }

    void UpdateHighscoreUI()
    {
        int highscore = PlayerPrefs.GetInt("Highscore", 0);

        highscoreText.text = "Highscore: " + highscore;
        homeHighscore.text = "Highscore: " + highscore;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
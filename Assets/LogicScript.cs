using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text lebenText;
    public int lives = 3;

    public void addScore(int ScoreToAdd)
    {
        playerScore += ScoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    
}

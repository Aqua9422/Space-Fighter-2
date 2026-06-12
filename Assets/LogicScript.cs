using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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
    public void leben()
    {
        lives -= 1;
        lebenText.text = lives.ToString();
    }

}

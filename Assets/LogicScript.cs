using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Add Score")]
    public void addScore()
    {
        playerScore += 100;
        scoreText.text = playerScore.ToString();
    }



}

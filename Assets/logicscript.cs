using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerScore;
    public Text scoretext;
    public GameObject gameoverscreen;
    [ContextMenu("Increase Score")]
    public void addScore(int scoretoadd)
    {
        playerScore += scoretoadd;
        scoretext.text = playerScore.ToString();
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
}

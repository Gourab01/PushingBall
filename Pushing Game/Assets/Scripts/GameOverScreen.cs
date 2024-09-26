using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text coinTexts;
    public void Setup(int Score)
    {
        gameObject.SetActive(true);
        coinTexts.text = Score.ToString() + " COINS";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ExitMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

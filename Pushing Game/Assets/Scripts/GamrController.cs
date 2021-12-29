using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamrController : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    int MaxPlatform = 0;
    public void GameOver()
    {
        GameOverScreen.Setup(MaxPlatform);
    }
}

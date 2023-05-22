using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using Cinemachine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;

    int coin = 100;
    public void GameOver()
    {
        finishedText.text = "Coba Lagi";
        finishedCanvas.SetActive(true);
        Debug.Log("GameOver");
    }
    public void Playerwin()
    {
        finishedText.text = "kamu berhasi \nScore " + GetScore();
        finishedCanvas.SetActive(true);
        Debug.Log("PlayerWin");
    }

    private int GetScore()
    {
        return coin * 10;
    }
}

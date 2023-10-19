using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static private Text uiText;
    static private int score= 1000;

    private Text txtCom;
    private void Awake()
    {
        uiText = GetComponent<Text>();
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }
        PlayerPrefs.SetInt("HighScore", score);
    }
    static public int Score
    {
        get
        {
            return score;
        }
        private set
        {
            score = value;
            PlayerPrefs.SetInt("HighScore", value);
            if (uiText != null)
            {
                uiText.text = "" + value.ToString("#,0");
            }
        }
    }
    static public void Set_HighScore(int scoreToTry)
    {
        if (scoreToTry < -score) return;
        score = scoreToTry;
    }
    public bool reset = false;
    private void OnDrawGizmos()
    {
        if (reset)
        {
            reset = false;
            PlayerPrefs.SetInt("HighScore", 1000);
        }
    }
}

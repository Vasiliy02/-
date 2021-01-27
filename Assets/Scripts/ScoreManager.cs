using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int appleAmmount;
    public static int score;
    public static int stage;
    public static int whatStage;
    public static int bestScore;

    public Text appleText;
    public Text scoreText;
    public Text scoreTextEnd;
    public Text bestText;
    public Text stageText;

    private void Start()
    {
        appleAmmount = PlayerPrefs.GetInt("AppleAmmount", appleAmmount);
        bestScore = PlayerPrefs.GetInt("BestScore", bestScore);
        stage = PlayerPrefs.GetInt("Stages", stage);
        score = 0;
    }

    private void Update()
    {
        PlayerPrefs.SetInt("AppleAmmount", appleAmmount);
        appleText.text = "" + appleAmmount;
        PlayerPrefs.SetInt("Stages", stage);
        stageText.text = "" + stage;
        if(whatStage > stage)
        {
            stage = whatStage;
            PlayerPrefs.Save();
        }
        bestText.text = "" + bestScore;
        PlayerPrefs.SetInt("BestScore", bestScore);
        if(score >= bestScore)
        {
            bestScore = score;
            PlayerPrefs.Save();
        }
        scoreText.text = "" + score;
        scoreTextEnd.text = "" + score;
    }
}

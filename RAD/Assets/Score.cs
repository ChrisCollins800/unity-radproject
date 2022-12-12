using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class Score : MonoBehaviour
{
    public float score;
    private int scoreInt;
    float highScore;
    public GameObject highScoreUI;
    public GameObject Player;
    playerMovement pm;

    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        pm = Player.GetComponent<playerMovement>();
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        if (!pm.lost)
        {
            score += 1 * Time.deltaTime;
            scoreInt = (int)score;
            text.text = "Score:" + scoreInt.ToString();
            highScoreUI.SetActive(false);
        }
        if(score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", scoreInt);
            if (pm.lost)
            {
                highScoreUI.SetActive(true);
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Transform endTrig;
    public Text scoreText;
    public Text FinalPercent;
    float position1;
    float position2;
    //public float [] highScoresValues = new float [] { };
    public Text[] highScoresText = new Text[] { };
    public float scoreEnd;
    //public PlayerMovement movement;


    //public Rigidbody rb;

    void Start()
    {

        //highScore.text = PlayerPrefs.GetFloat ("HighScore", 0).ToString ("0") + "%";

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.y);

        position1 = player.position.z;
        position2 = endTrig.position.z;
        scoreEnd = (position1 / position2) * 100;
        scoreText.text = ((position1 / position2) * 100).ToString("0") + "%";
        //Debug.Log (scoreEnd);

        //PlayerPrefs.SetFloat ("HighScore", scoreEnd);

        if (scoreEnd > 100)
        {
            //Debug.Log ("HAPPY");
            //movement.enabled = false;
            scoreEnd = 100;
            scoreText.text = 100.ToString("0") + "%";
            //FindObjectOfType<GameManagerr>().EndGame();

        }


        if (scoreEnd > PlayerPrefs.GetFloat("HighScore"))
        {

            PlayerPrefs.SetFloat("HighScore", scoreEnd);
            //highScore.text = scoreEnd.ToString("0") + "%";
        }

        FinalPercent.text = scoreText.text;


        //scoreEnd = (position1 / position2) * 100;


    }
    public void HighScoreLevel()
    {
        Debug.Log(Manager.Instance.currentLevel);
        int i = Manager.Instance.currentLevel;

        if (Manager.Instance.currentLevel == i)
        {
            if (scoreEnd > SaveManager.Instance.state.highScore[i])
            {
                SaveManager.Instance.state.highScore[i] = scoreEnd;
                Debug.Log("New high score has been made");
                //highScoresValues[0] = scoreEnd;
                highScoresText[0].text = scoreEnd.ToString("0") + "%";
            }

            else
            {
                highScoresText[0].text = SaveManager.Instance.state.highScore[i].ToString("0") + "%";
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    /*
    //public Transform player;
    //public Transform endTrig;
    public Text scoreText;
    //public float [] highScoresValues = new float [] { };
    public Text [] highScoresText = new Text[] { };
    public Transform player;
    public Transform endTrig;
    float position1;
    float position2;
    public float scoreEnd;

    //public Text highScore2;
    //public Text highScore3;
    //public Text highScore4;
    //public PlayerMovement movement;
    //float scoreEnd;
    //public Rigidbody rb;
    //score GM;

    //public PlayerMovement movement;

  
    void Start () {
        //highScore.text = "HighScore : " + (PlayerPrefs.GetFloat ("HighScore")).ToString ("0") + "%"; 
        //DontDestroyOnLoad(gameObject);
        //Instance = this;


    }

    void Update()
    {
       

        
        if (Manager.Instance.currentLevel == 1)
        {
            if (scoreEnd > SaveManager.Instance.state.highScore[1])
            {
                SaveManager.Instance.state.highScore[1] = scoreEnd;
                Debug.Log("New high score has been made");
                //highScoresValues[0] = scoreEnd;
                highScoresText[0].text = scoreEnd.ToString("0") + "%";
            }

            else
            {
                highScoresText[0].text = SaveManager.Instance.state.highScore[1].ToString("0");
            }
        }

    }


        public void HighScoreLevel ()
    {
        position1 = player.position.z;
        position2 = endTrig.position.z;
        scoreEnd = (position1 / position2) * 100;
        scoreText.text = ((position1 / position2) * 100).ToString("0") + "%";

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
        /*
        index = 0;

       
        for (int i = 0; i <= 10; i++)
        {
            if (scoreEnd > SaveManager.Instance.state.highScore[i])
            {
                SaveManager.Instance.state.highScore[i] = scoreEnd;
                Debug.Log("New high score has been made");
                highScores[i].text = scoreEnd.ToString("0") + "%";
            }
        }
        */

        /*
        if (scoreEnd > SaveManager.Instance.state.highScore[2])
        {
            SaveManager.Instance.state.highScore[2] = scoreEnd;
            Debug.Log("New high score has been made");
            highScores[1].text = scoreEnd.ToString("0") + "%";
        }*/

        //FinalPercent.text = scoreText.text;




    //}
}





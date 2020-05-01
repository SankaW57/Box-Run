using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; //Used when you need to change to a different scene or reload the scene
using UnityEngine;
using UnityEngine.UI;
public class GameManagerr : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
   
    public GameObject completeLevelUI;
	public GameObject scoreUIPercent;
	public GameObject pauseUI;
	public GameObject endedUI;
	public GameObject coinScoreUISP;
	public Image coinsImageSP;
	//public Text score;
	public Canvas moJay;
	public PlayerMovement _scriptMovement;
    public Score highScoreFull;


	void start (){


		coinsImageSP = GetComponent<Image> ();
	}
    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
        pauseUI.SetActive(false);
        scoreUIPercent.SetActive (false);
		coinScoreUISP.SetActive (false);
        moJay.enabled = false;
        coinsImageSP.enabled = false;
        Debug.Log("LEVEL WON");
        _scriptMovement.NoForcing();

    }
    
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            _scriptMovement.NoMovementSide();
			moJay.enabled = false;
            Debug.Log("GAME OVER");
			pauseUI.SetActive (false);
			scoreUIPercent.SetActive (false);
			coinScoreUISP.SetActive (false);
			coinsImageSP.enabled = false;
            highScoreFull.HighScoreLevel();
            Debug.Log("GAME OVER2");
            //coinsImage.SetActive (false);
            //endedUI.SetActive (true);
            Invoke("RetryFor", restartDelay);
            //Invoke("Restart", restartDelay);    //Two parameters, first name of function, second delay time
            //Restart();    //Calling function Restart,
            //everyting in Restart () will then execute
            
        }
    }

	void RetryFor (){
	
		endedUI.SetActive (true);
		//scoreUI.SetActive (false);
		//pauseUI.SetActive (false);
		//mJoybre.SetActive (true);

	}

        void Restart ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           
        }
     
	public void DisableJoy ()
	{
		moJay.enabled = false;

	}

	public void EnableJoy ()
	{
		moJay.enabled = true;

	}

}

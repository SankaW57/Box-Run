using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuPanel : MonoBehaviour {

	public GameObject menuPanelUI;//
	public GameObject menuPanelUIPause;//
    //public GameObject menuPanelUIComplete;
	//public GameObject menuButtonUI;
	public GameObject menuButtonUIEnd;//
	//public GameObject cubesLeftUIEnd;
	//public GameObject fianlPercentUI;
	//public GameObject taptoRestartUI;
	public GameObject taptoContinueUI;//
	public Image coinsImageSP;//
	public Image coinsImageCP;//
	//public GameObject coinsScoreUICP;
	//public GameObject highScoreUI;

    public GameObject panelMaster;//


	void start (){


		coinsImageSP = GetComponent<Image> ();
	}

	// Update is called once per frame
	public void MenuStartupEP () { //EndPanel

        //True
		menuPanelUI.SetActive (true);
        panelMaster.SetActive(false);
        coinsImageSP.enabled = false;
        /*
        menuButtonUI.SetActive (false);
		cubesLeftUIEnd.SetActive (false);
		fianlPercentUI.SetActive (false);
		taptoRestartUI.SetActive (false);
		
		coinsImageCP.enabled = false;
		coinsScoreUICP.SetActive (false);
		highScoreUI.SetActive (false);*/

        
        
    }

    public void MenuStartupLC()
    { 
        menuPanelUI.SetActive(true);
        panelMaster.SetActive(false);
        coinsImageSP.enabled = false;
    }

    public void BackButtonEP () { //EndPanel
        menuPanelUI.SetActive(false);
        panelMaster.SetActive(true);
        coinsImageSP.enabled = false;


        /*
		menuButtonUI.SetActive (true);
		cubesLeftUIEnd.SetActive (true);
		fianlPercentUI.SetActive (true);
		taptoRestartUI.SetActive (true);
		//coinsImageSP.enabled = true;
		coinsScoreUICP.SetActive (true);
		coinsImageCP.enabled = true;
		highScoreUI.SetActive (true);*/
    }

    public void MenuStartupPP () {//Pause Panel

		menuPanelUIPause.SetActive (true);
		menuButtonUIEnd.SetActive (false);
		taptoContinueUI.SetActive (false);
		coinsImageSP.enabled = false;
		//coinsImageCP.enabled = false;
		//CubesLeftUI.SetActive (false);
		//FianlPercentUI.SetActive (false);
		//TaptoRestartUI.SetActive (false);
	}

	public void BackButtonPP () { //Pause Panel

		menuPanelUIPause.SetActive (false);
		menuButtonUIEnd.SetActive (true);
		taptoContinueUI.SetActive (true);
		//coinsImageSP.enabled = true;
		coinsImageCP.enabled = true;
		//CubesLeftUI.SetActive (true);
		//FianlPercentUI.SetActive (true);
		//TaptoRestartUI.SetActive (true);
	}


}


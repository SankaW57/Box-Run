using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstCollision : MonoBehaviour {

    public PlayerMovement movement;
	private int count; //Coins picked up
	public int countTotal; //Total coins
	public Text scoreTextSP;
	public Text scoreTextTwoCP;
	private GameObject[] getCount;
    //public static SaveManager Instance { set; get; }

    void Start (){

		count = 0;
		SettingCount();

		getCount = GameObject.FindGameObjectsWithTag ("Coins");
		countTotal = getCount.Length;
		Debug.Log (countTotal + "Coins");
		scoreTextTwoCP.text = "0/" + countTotal.ToString("0");
	}

	void Update (){
	    

	}
    
    void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Obstacle") {
			movement.enabled = false;
			FindObjectOfType<GameManagerr>().EndGame ();

		}
	}


		public void OnTriggerEnter (Collider other) //Score System
	{

		if (other.gameObject.CompareTag ("Coins")) {

			other.gameObject.SetActive (false);
            SaveManager.Instance.state.gold++;
            SaveManager.Instance.Save();
			count++;
			SettingCount ();

		}
	}

		void SettingCount (){

			
		scoreTextSP.text = count.ToString ("0");
		scoreTextTwoCP.text = count.ToString ("0") + "/" + countTotal.ToString("0");

		}
       
   

    
}

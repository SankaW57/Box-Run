using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchControl : MonoBehaviour {
	Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
		public void MoveLeft ()
		{
		if (Input.GetTouch (0).phase == TouchPhase.Began) {
			//rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			Debug.Log ("Touch Began");
		}


		}

		public void MoveRight ()

		{



		}

	}


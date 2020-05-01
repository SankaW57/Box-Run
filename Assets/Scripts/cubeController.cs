using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class cubeController : MonoBehaviour {

	public float speed;
	Rigidbody rb;

	void Awake (){

		rb = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	void FixedUpdate (){
	
		float hInput = CrossPlatformInputManager.GetAxis ("Horizontal")*speed;

		rb.AddForce (hInput, 0, 0);
	}


}

using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[DisallowMultipleComponent]
	[RequireComponent(typeof(SpriteRenderer))]

public class SCR : MonoBehaviour {
		
	[SerializeField]MeshRenderer target;
	SpriteRenderer srend;


	void Awake ()
	{
		srend = GetComponent<SpriteRenderer> ();

	}

	void OnMouseDown(){


		Debug.Log (gameObject.name);
		target.material.color = srend.color;

	}

	}
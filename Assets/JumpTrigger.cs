using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour {

    //private CharacterController jumpControl;
    //private float verticalVelocity;
    //private float gravity = 14.0f;
    //private float jumpForce = 10.0f;
    private GameManagerr gameManager;
    public GameObject player;
    public Rigidbody rb;

    private void Start()
    {
        //jumpControl = GetComponent<CharacterController>();
    }
    void OnTriggerEnter()
    {
        //jumpControl = GetComponent<CharacterController>();
        Debug.Log("force has been added");
        rb.AddForce(0, 1000*Time.deltaTime, 0, ForceMode.VelocityChange);
        rb.drag = 2;

    }

    void Update()
    {
     

    }

}

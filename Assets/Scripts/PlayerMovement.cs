using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
	public PlayerMovement movement;
    GameManagerr gameManagedd;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float backwardsForce;
    public GameObject particlSystemLiftUp;

    void Awake()
    {
        particlSystemLiftUp.SetActive(false);
    }
    void Start()
    {
        //ParticleSystem ps = GetComponent<ParticleSystem>();
        //var em = ps.emission;
        //em.enabled = false;
        particlSystemLiftUp.SetActive(false);
        Debug.Log("is false");
        //ps = GetComponent<ParticleSystem>();
        //PlayThrusters();
    }

    //FixedUpdate when doing anything physics wise
    void FixedUpdate () 
	{

		//Adding a constant force to move
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey ("d")) {
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		}

		if (Input.GetKey ("a")) {
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
           
		}

		if (rb.position.y < 0.8f) {
            
			FindObjectOfType<GameManagerr> ().EndGame ();
			movement.enabled = false;
			forwardForce = -40000f;
			NoMovementSide ();

		}

        if (rb.position.y > 1f)
        {

            particlSystemLiftUp.SetActive(true);

        }
    }

  

    public void NoMovementSide (){

			sidewaysForce = 0f;
		}

    public void NoForcing()
    {
        movement.enabled = false;
        //backwardsForce = -70000f;
        //sidewaysForce = 0f;
        //forwardForce = 0f;
        //rb.angularDrag = 30;
        //rb.drag = 30;
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //rb.AddForce(0, 0, backwardsForce * Time.deltaTime);

    }

    /*
    public static void EnableEmission(this ParticleSystem particleSystem, bool enabled)
    {
        var emission = particleSystem.emission;
        emission.enabled = enabled;
    }

    public static float GetEmissionRate(this ParticleSystem particleSystem)
    {
        return particleSystem.emission.rateOverTime.constantMax;
        //return particleSystem.emissionRate.constantMax;
    }

    public static void SetEmissionRate(this ParticleSystem particleSystem, float emissionRate)
    {
        var emission = particleSystem.emission;
        var rate = emission.rateOverTime;
        rate.constantMax = emissionRate;
        emission.rateOverTime = rate;
    }*/
}

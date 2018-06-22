using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour {


	public Rigidbody rb;
	public	KeyCode vkey;
	void Start(){
		AudioSource sonido = GetComponent<AudioSource>();

		rb = GetComponent<Rigidbody>();
		sonido.Play();
	}

	void FixedUpdate(){
					Debug.Log(vkey);

		if(Input.GetKey("space")){
			rb.AddForce(0,0.2f,0,ForceMode.Impulse);
			
		}
		if(Input.GetKey("a")){
			//rb.AddTorque(0.4f,0.4f,0,ForceMode.Force);
			float turn = Input.GetAxis("Horizontal");
        	rb.AddTorque(transform.up * turn*2);
    }
		
	}
}

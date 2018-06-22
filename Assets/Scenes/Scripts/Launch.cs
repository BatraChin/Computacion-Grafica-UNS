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
	}
}

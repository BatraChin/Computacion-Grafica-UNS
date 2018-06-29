using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSound : MonoBehaviour {
	public AudioSource sonido;
	// Use this for initialization
	void Start () {
	sonido = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if(Input.GetKey("space")==false){
					sonido.Stop();

		}
		if(Input.GetKey("space")){
			
			sonido.Play();
			
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSound : MonoBehaviour {
	public AudioSource sonido;
	// Use this for initialization
	void Start () {
	sonido = GetComponent<AudioSource>();
	sonido.Stop();
	}


	// Update is called once per frame
	void FixedUpdate () {

		if (!sonido.isPlaying){
			if(Input.GetKey("space")){
				sonido.Play();
			}
		}
			
		
		if (sonido.isPlaying){
			if(Input.GetKey("space")==false){
				sonido.Stop();
			}
		}
			
	
	}
}
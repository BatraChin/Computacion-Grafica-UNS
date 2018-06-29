using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour {


	public Rigidbody rb;
	public	KeyCode vkey;
	public GameObject fueguito;
	void Start(){
		//AudioSource sonido = GetComponent<AudioSource>();
		fueguito=GameObject.FindWithTag("Fire");

		rb = GetComponent<Rigidbody>();
		//sonido.Play();
	}

	void FixedUpdate(){

		
		if(Input.GetKey("space")==false){
					fueguito.SetActive(false);

		}
		if(Input.GetKey("space")){
			fueguito.SetActive(true);

			rb.AddForce(transform.up*0.3f,ForceMode.Impulse);
			float turn = Input.GetAxis("Horizontal");
        	rb.AddTorque(transform.up * turn*2);
			
		}
		if(Input.GetKey("a")){
			transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime *10f , Space.World);
		}
		if(Input.GetKey("d")){
			transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime*10f , Space.World);
		}
		if(Input.GetKey("w")){
			transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime*10f , Space.World);
		}
		if(Input.GetKey("s")){
			transform.Rotate(new Vector3(-1, 0, 0) * Time.deltaTime*10f , Space.World);
		}
			//rb.AddTorque(0.4f,0.4f,0,ForceMode.Force);
			
    }
		
	
}

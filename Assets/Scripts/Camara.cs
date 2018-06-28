using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

	public Camera MainCamera;
	public Camera CameraDisplay2;
	public Camera CameraDisplay3;
	public Camera CameraDisplay4;
	public Camera CameraDisplay5;
	// Use this for initialization
	void Start () {


		MainCamera=GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
		CameraDisplay2=GameObject.FindWithTag("CameraDisplay2").GetComponent<Camera>();
		CameraDisplay3=GameObject.FindWithTag("CameraDisplay3").GetComponent<Camera>();
		CameraDisplay4=GameObject.FindWithTag("CameraDisplay4").GetComponent<Camera>();
		CameraDisplay5=GameObject.FindWithTag("CameraDisplay5").GetComponent<Camera>();
		
		
	}
	
	public Transform player;
    
    void Update ()
    {
        transform.LookAt(player);
    }

	void FixedUpdate(){
		if(Input.GetKey("1")){
			MainCamera.enabled=true;
			
			CameraDisplay2.enabled=false;
			CameraDisplay3.enabled=false;
			CameraDisplay4.enabled=false;
			CameraDisplay5.enabled=false;
		}
		if(Input.GetKey("2")){
			
			CameraDisplay3.enabled=false;
			CameraDisplay4.enabled=false;
			MainCamera.enabled=false;	
			CameraDisplay2.enabled=true;
			CameraDisplay5.enabled=false;
		}
		if(Input.GetKey("3")){
			CameraDisplay3.enabled=true;
			CameraDisplay4.enabled=false;
			MainCamera.enabled=false;	
			CameraDisplay2.enabled=false;	
			CameraDisplay5.enabled=false;	
		}
		if(Input.GetKey("4")){
			CameraDisplay3.enabled=false;
			CameraDisplay4.enabled=true;
			MainCamera.enabled=false;	
			CameraDisplay2.enabled=false;
			CameraDisplay5.enabled=false;		
		}
		if(Input.GetKey("5")){
			CameraDisplay5.enabled=true;

			
			MainCamera.enabled=false;
			CameraDisplay2.enabled=false;
			CameraDisplay3.enabled=false;
			CameraDisplay4.enabled=false;
		}
	}
}

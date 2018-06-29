using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

	public GameObject MainCamera;
	public GameObject CameraDisplay2;
	public GameObject CameraDisplay3;
	public GameObject CameraDisplay4;
	public GameObject CameraDisplay5;
	// Use this for initialization
	void Start () {


		MainCamera=GameObject.FindWithTag("MainCamera");
		CameraDisplay2=GameObject.FindWithTag("CameraDisplay2");
		CameraDisplay3=GameObject.FindWithTag("CameraDisplay3");
		CameraDisplay4=GameObject.FindWithTag("CameraDisplay4");
		CameraDisplay5=GameObject.FindWithTag("CameraDisplay5");
		
		
	}
	
	public Transform player;
    public AudioListener audio;
    void Update ()
    {
        transform.LookAt(player);
    }
	void disableCamera(GameObject cam){
		Camera camara= cam.GetComponent<Camera>();
		camara.enabled=false;
		audio = cam.GetComponent<AudioListener>();
		audio.enabled=false;
	}
	void enableCamera(GameObject cam){
		Camera camara= cam.GetComponent<Camera>();
		camara.enabled=true;
		audio = cam.GetComponent<AudioListener>();
		audio.enabled=true;
	}
	void FixedUpdate(){
		if(Input.GetKey("1")){
			
			enableCamera(MainCamera);
			disableCamera(CameraDisplay2);
			disableCamera(CameraDisplay3);
			disableCamera(CameraDisplay4);
			disableCamera(CameraDisplay5);
			
			/* 
			MainCamera.enabled=true;
			
			CameraDisplay2.enabled=false;
			CameraDisplay3.enabled=false;
			CameraDisplay4.enabled=false;
			CameraDisplay5.enabled=false;
*/
		}
		if(Input.GetKey("2")){


			
			enableCamera(CameraDisplay2);
			disableCamera(MainCamera);
			disableCamera(CameraDisplay3);
			disableCamera(CameraDisplay4);
			disableCamera(CameraDisplay5);
			/* 
			CameraDisplay3.enabled=false;
			CameraDisplay4.enabled=false;
			MainCamera.enabled=false;	
			CameraDisplay2.enabled=true;
			CameraDisplay5.enabled=false;*/
		}
		if(Input.GetKey("3")){
			
			
			enableCamera(CameraDisplay3);
			disableCamera(MainCamera);
			disableCamera(CameraDisplay2);
			disableCamera(CameraDisplay4);
			disableCamera(CameraDisplay5);
			/* 
			CameraDisplay3.enabled=true;
			CameraDisplay4.enabled=false;
			MainCamera.enabled=false;	
			CameraDisplay2.enabled=false;	
			CameraDisplay5.enabled=false;	*/
		}
		if(Input.GetKey("4")){

			
			enableCamera(CameraDisplay4);
			disableCamera(MainCamera);
			disableCamera(CameraDisplay2);
			disableCamera(CameraDisplay3);
			disableCamera(CameraDisplay5);
			/*
			CameraDisplay3.enabled=false;
			CameraDisplay4.enabled=true;
			MainCamera.enabled=false;	
			CameraDisplay2.enabled=false;
			CameraDisplay5.enabled=false;		*/
		}
		if(Input.GetKey("5")){
			
			enableCamera(CameraDisplay4);
			disableCamera(MainCamera);
			disableCamera(CameraDisplay2);
			disableCamera(CameraDisplay3);
			disableCamera(CameraDisplay5);
			/*
			CameraDisplay5.enabled=true;

			
			MainCamera.enabled=false;
			CameraDisplay2.enabled=false;
			CameraDisplay3.enabled=false;
			CameraDisplay4.enabled=false;*/
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class skyScript : MonoBehaviour {
	private bool lightOn;
	public Material skyDia;
	public Material skyNoche;
	private GameObject luz;
	void Start ()
	{
		luz=GameObject.FindWithTag("Iluminacion");
		//RenderSettings.skybox=skyDia;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("l"))
		{
			//lightOn = !lightOn;
			if(luz.GetComponent<Light>().intensity==0){
				//GetComponent<Skybox>().material=skyDia;
				RenderSettings.skybox=skyDia;

			}
			else
			{
				//GetComponent<Skybox>().material=skyNoche;
				RenderSettings.skybox=skyNoche;
			}

		}
		if(Input.GetKey("p")){
			AudioSource sonido = GetComponent<AudioSource>();
			sonido.Play();
		}
	}

}


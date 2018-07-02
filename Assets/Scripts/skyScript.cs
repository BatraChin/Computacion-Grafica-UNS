using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class skyScript : MonoBehaviour {
	private bool lightOn;
	public Material skyDia;
	public Material skyNoche;
	private GameObject player;
	private GameObject luz;
	void Start ()
	{
		luz=GameObject.FindWithTag("Iluminacion");
		player= GameObject.FindWithTag("Player");
		//RenderSettings.skybox=skyDia;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(Input.GetKey("l"))
		{
			//lightOn = !lightOn;
			if(luz.GetComponent<Light>().intensity==0){

				RenderSettings.skybox=skyDia;

			}
			else
			{

				RenderSettings.skybox=skyNoche;
			}

		}
	}

}


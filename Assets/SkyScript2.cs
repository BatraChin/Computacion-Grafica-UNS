using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class skyScript2 : MonoBehaviour {
	private bool lightOn;
	public Material skyDia;
	public Material skyNoche;
	void Start ()
	{
		//RenderSettings.skybox=skyDia;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("l"))
		{
			lightOn = !lightOn;
			if(lightOn){
				GetComponent<Skybox>().material=skyDia;
				//RenderSettings.skybox=skyDia;

			}
			else
			{
				GetComponent<Skybox>().material=skyNoche;
				//RenderSettings.skybox=skyNoche;
			}

		}
	}

}


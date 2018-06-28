using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diaNoche : MonoBehaviour {
	private bool lightOn;
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.L))
		{
			lightOn = !lightOn;
			if(lightOn){
				GetComponent<Light>().intensity=0;	
			}
			else
			{
				GetComponent<Light>().intensity=1;
			}
		}
	}

}


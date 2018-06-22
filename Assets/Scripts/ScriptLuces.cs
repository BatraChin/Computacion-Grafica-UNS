using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLuces : MonoBehaviour {

	// Use this for initialization
	//public Light myLight=GetComponent<Light>();

	/*IEnumerator MyCoroutine()
    {
        //This is a coroutine
        
       
         yield return new WaitForSeconds(1);    //Wait one frame
	}*/

	private bool lightOn;

	void Start () {
	
	
		InvokeRepeating("toggleLight",0,1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void toggleLight(){
		lightOn=!lightOn;
		if(lightOn){
			GetComponent<Light>().intensity=0;
		}else{
			GetComponent<Light>().intensity=1;
		}
	}

}

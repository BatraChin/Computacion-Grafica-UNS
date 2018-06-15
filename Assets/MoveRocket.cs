using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRocket : MonoBehaviour {


	
	void OnMouseDown(){
		rigidbody.AddForce(transform.forward*50);
		rigidbody.useGravity=true;
	}
	// Update is called once per frame
	
}

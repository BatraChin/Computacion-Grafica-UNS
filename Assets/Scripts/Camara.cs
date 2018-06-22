using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}

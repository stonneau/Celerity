﻿using UnityEngine;
using System.Collections;
 
public class crashingCopter : MonoBehaviour {
	public GameObject copter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player"){
			copter.rigidbody.useGravity = true;
		}
	}
}

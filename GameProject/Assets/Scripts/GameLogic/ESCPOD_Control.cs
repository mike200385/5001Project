﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCPOD_Control : MonoBehaviour {

	public GameObject wall1, wall2, wall3, wall4;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("Player")) {
			wall1.SetActive (true);
			wall2.SetActive (true);
		}

	}
}



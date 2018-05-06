﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {
	public Transform mirrorCam;
	public Transform playerCam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CalculateRotation ();
	}

	public void CalculateRotation(){
		Vector3 dir = (playerCam.position - transform.position).normalized;
		Quaternion rot = Quaternion.LookRotation (dir);
		rot.eulerAngles = transform.eulerAngles - rot.eulerAngles;

		mirrorCam.localRotation = rot;
	}
}

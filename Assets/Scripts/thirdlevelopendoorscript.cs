using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdlevelopendoorscript : MonoBehaviour {

	private bool doorOpen = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (MissionDisplay.level3passed){
			if (!doorOpen) {
				open ();
			}
		}

	}

	public void open(){
		Animation anim = GetComponent<Animation> ();
		anim.Play ();
		doorOpen = true;
	}
}

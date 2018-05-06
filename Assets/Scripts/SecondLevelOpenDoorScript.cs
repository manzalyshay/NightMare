using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLevelOpenDoorScript : MonoBehaviour {
	private bool doorOpen = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Level2Controller.level2Passed){
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

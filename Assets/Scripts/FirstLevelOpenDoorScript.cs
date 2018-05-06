using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLevelOpenDoorScript : MonoBehaviour {
	private bool doorOpen = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Level1Controller.level1Passed){
			if (!doorOpen) {
				open ();
				MissionDisplay.level2started = true;
			}
		}
		
	}

	public void open(){
		Animation anim = GetComponent<Animation> ();
		anim.Play ();
		doorOpen = true;
	}
}

using System.Collections;
using System.Timers;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3Controller: MonoBehaviour {

	public static bool level3Passed = false;
	public static int zombiesDies = 0;

	// Use this for initialization
	void Start () {
	}



	// Update is called once per frame
	void Update () {
		if (zombiesDies == 17) {
			level3Passed = true;
			MissionDisplay.level3passed = true;
		}
	}



}

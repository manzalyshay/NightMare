using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkipHandler : MonoBehaviour {

	// Use this for initialization
	public void SkipCurrentStage () {
		switch (MissionDisplay.currentStage) {

		case "LEVEL1":
			Level1Controller.level1Passed = true;
			break;
		case "LEVEL2":
			Level2Controller.level2Passed = true;
			break;
		case "LEVEL3":
			MissionDisplay.level3passed = true;
			break;
		
		}
	
}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider other){
		switch (gameObject.name) {
		case "Coin1":
			Level2Controller.lvl2Coin1Collected = true;
			break;
		case "Coin2":
			Level2Controller.lvl2Coin2Collected = true;
			break;
		case "Coin3":
			Level2Controller.lvl2Coin3Collected = true;
			break;
		case "Coin4":
			Level2Controller.lvl2Coin4Collected = true;
			break;
		case "Coin5":
			Level2Controller.lvl2Coin5Collected = true;
			break;
		}
		Destroy (gameObject);
	}
}

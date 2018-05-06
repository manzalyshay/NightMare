using System.Collections;
using System.Timers;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2Controller: MonoBehaviour {
	public static bool lvl2Coin1Collected = false;
	public static bool lvl2Coin2Collected = false;
	public static bool lvl2Coin3Collected = false;
	public static bool lvl2Coin4Collected = false;
	public static bool lvl2Coin5Collected = false;
	public static bool level2Passed = false;

	// Use this for initialization
	void Start () {
	}
		
	// Update is called once per frame
	void Update () {

		if (lvl2Coin1Collected && lvl2Coin2Collected && lvl2Coin3Collected && lvl2Coin4Collected && lvl2Coin5Collected) {
			level2Passed = true;
			MissionDisplay.level3started = true;
		}
	}



}

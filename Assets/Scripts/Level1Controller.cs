using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Level1Controller: MonoBehaviour {
	public static bool lvl1trainCreate1Destroyed = false;
	public static bool lvl1trainCreate2Destroyed = false;
	public static bool lvl1trainCreate3Destroyed = false;
	public static bool lvl1trainCreate4Destroyed = false;
	public static bool lvl1trainCreate5Destroyed = false;
	public static bool level1Passed = false;

	// Use this for initialization
	void Start () {


	}


	// Update is called once per frame
	void Update () {

		if (lvl1trainCreate1Destroyed && lvl1trainCreate2Destroyed && lvl1trainCreate3Destroyed && lvl1trainCreate4Destroyed && lvl1trainCreate5Destroyed) {
			level1Passed = true;
		}
	}



}

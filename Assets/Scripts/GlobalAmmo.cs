using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour {
	public static int CurrentAmmo = 0;
	int InternalAmmo = 0;
	public GameObject AmmoDisplay;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		InternalAmmo = CurrentAmmo;
		AmmoDisplay.GetComponent<Text> ().text = "" + InternalAmmo;

	}
}

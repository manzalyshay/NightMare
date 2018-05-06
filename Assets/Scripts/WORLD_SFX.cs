using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WORLD_SFX : MonoBehaviour {
	public static AudioSource ammoPickup;
	// Use this for initialization
	void Start () {
		AudioSource[] aSources = GetComponents<AudioSource>();
		ammoPickup = aSources [0];
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

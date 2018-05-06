using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			if (GlobalAmmo.CurrentAmmo > 0) {
				AudioSource audio = GetComponent<AudioSource> ();
				audio.Play ();
				Animation anim = GetComponent<Animation> ();
				anim.Play ();
				GlobalAmmo.CurrentAmmo--;
			}
		}
	}
}

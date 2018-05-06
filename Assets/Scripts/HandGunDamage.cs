using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour {

	public float damageAmount = 5;
	float targetDistance;
	public float allowedRange = 15;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetButtonDown ("Fire1")) {
			if (GlobalAmmo.CurrentAmmo > 0) {
				RaycastHit Shot = new RaycastHit ();
				if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Shot)) {
					targetDistance = Shot.distance;
					if (targetDistance < allowedRange) {
						Shot.transform.SendMessage ("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);

					}
				}
			}
		}

	}
}

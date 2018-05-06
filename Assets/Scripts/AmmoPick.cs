using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPick : MonoBehaviour {
	void OnTriggerEnter(Collider other)
	{
		WORLD_SFX.ammoPickup.Play ();
		GlobalAmmo.CurrentAmmo += 10;
		this.gameObject.SetActive (false);
	}
}
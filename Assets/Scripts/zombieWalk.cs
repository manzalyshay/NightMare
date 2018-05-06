using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieWalk : MonoBehaviour {
	protected Animator myAnim;
	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		myAnim.SetFloat ("speed", Input.GetAxis ("Vertical"));
	}
}

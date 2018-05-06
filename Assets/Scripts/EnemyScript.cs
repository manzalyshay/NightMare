using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	public int enemyHealth = 10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth <= 0){
			Debug.Log (gameObject.name);
			switch (gameObject.name) {
			case ("PracticeTarget001"):
				Level1Controller.lvl1trainCreate1Destroyed = true;
				break;
			case ("PracticeTarget002"):
				Level1Controller.lvl1trainCreate2Destroyed = true;
				break;
			case ("PracticeTarget003"):
				Level1Controller.lvl1trainCreate3Destroyed = true;
				break;
			case ("PracticeTarget004"):
				Level1Controller.lvl1trainCreate4Destroyed = true;
				break;
			case ("PracticeTarget005"):
				Level1Controller.lvl1trainCreate5Destroyed = true;
				break;
			}
			Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void DeductPoints (int damageAmount) {
		enemyHealth -= damageAmount;

	}
}

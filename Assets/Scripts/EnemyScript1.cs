using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript1 : MonoBehaviour {
	public int enemyHealth = 5;
	public Transform player;
	public float rotSpeed = 0.4f; //rotation speed 
	private bool playerLost = false;
	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	public void DeductPoints (int damageAmount) {
		enemyHealth -= damageAmount;

	}


	// Update is called once per frame
	void Update () {

		if (enemyHealth <=0){
			Destroy (gameObject);
		}

		if (Vector3.Distance(player.position, this.transform.position) < 8)
		{
			Vector3 direction = player.position - this.transform.position;
			direction.y = 0;

			this.transform.rotation = Quaternion.Slerp(this.transform.rotation , Quaternion.LookRotation(direction), 0.5f);

			if (direction.magnitude > 2)
			{
				this.transform.Translate(0, 0, 0.2f);
			}

			else
			{ 
				playerLost = true;
			}
	
		}
			
		if (playerLost) {
			Application.LoadLevel(0);
		
		}
	}

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenuscript : MonoBehaviour {

	public void PlayGame(){
		Application.LoadLevel (1);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}

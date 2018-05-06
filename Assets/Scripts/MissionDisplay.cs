using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

public class MissionDisplay : MonoBehaviour {
	public Text Label;
	public static bool level2started = false;
	public static bool level3started = false;
	private bool DescTimedPassed = false;
	private bool Desc2TimedPassed = false;
	private bool Desc3TimedPassed = false;
	public static bool level1passed = false;
	public static bool level2passed = false;
	public static bool level3passed = false;
	public static bool currentStagePassed = false;
	public static string currentStage = "";

	// Use this for initialization
	void Start () {
		Label.GetComponent<Text> ().text = "Grab Ammo, Shoot the 5 Cratles in order to advance.";
		System.Timers.Timer aTimer = new System.Timers.Timer();
		aTimer.Elapsed+=new ElapsedEventHandler(OnTimedEvent);
		aTimer.Interval=5000;
		aTimer.Enabled=true;
		currentStage = "LEVEL1";
	}
	
	// Update is called once per frame
	void Update () {
		if (DescTimedPassed) {
			Label.GetComponent<Text> ().text = "";
			DescTimedPassed = false;

		}

		if (Desc2TimedPassed) {
			Label.GetComponent<Text> ().text = "";
			Desc2TimedPassed = false;
		}

		if (Desc3TimedPassed) {
			Label.GetComponent<Text> ().text = "";
			Desc3TimedPassed = false;
		}

		if (level2started) {
			currentStage = "LEVEL2";
			Label.GetComponent<Text> ().text = "DOOR IS OPEN! Find the hidden 5 coins in order to advance";
			System.Timers.Timer bTimer = new System.Timers.Timer ();
			bTimer.Elapsed += new ElapsedEventHandler (OnTimedEvent2);
			bTimer.Interval = 5000;
			bTimer.Enabled = true;
			level2started = false;
		}

		if (level3started) {
			currentStage = "LEVEL3";
			Label.GetComponent<Text> ().text = "DOOR IS OPEN! GRAB SOME AMMO AND KILL THE ZOMBIES!!";
			System.Timers.Timer CTimer = new System.Timers.Timer ();
			CTimer.Elapsed += new ElapsedEventHandler (OnTimedEvent3);
			CTimer.Interval = 5000;
			CTimer.Enabled = true;
			level3started = false;
		}

		if (level3passed) {
			Label.GetComponent<Text> ().text = "YOU WON! CONGRATS!!";
			System.Timers.Timer  dTimer = new System.Timers.Timer ();
			dTimer.Elapsed += new ElapsedEventHandler (OnTimedEvent4);
			dTimer.Interval = 5000;
			dTimer.Enabled = true;
		}
	}

	private void OnTimedEvent(object source, ElapsedEventArgs e)
	{
		DescTimedPassed = true;
	}

	private void OnTimedEvent2(object source, ElapsedEventArgs e)
	{
		Desc2TimedPassed = true;
	}

	private void OnTimedEvent3(object source, ElapsedEventArgs e)
	{
		Desc3TimedPassed = true;
	}

	private void OnTimedEvent4(object source, ElapsedEventArgs e)
	{
		Application.LoadLevel (0);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ShowMainMenu ();
	}

	void ShowMainMenu () {
		var greeting = "Hello Hacker";
		Terminal.ClearScreen();
		Terminal.WriteLine(greeting);
		Terminal.WriteLine("What difficulty would you like?");
		Terminal.WriteLine("Press 1 for easy");
		Terminal.WriteLine("Press 2 for medium");
		Terminal.WriteLine("Press 3 for hard");
	}

	// Update is called once per frame
	void Update () {

	}
}

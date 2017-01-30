using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

    int max = 1000;
    int min = 1;

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard");
        print("Pick a Number in your head, but don't tell me!");

        print("The highest number you can pick is: " + max);
        print("The lowest number you can pick is: " + min);

        print("Is the number higher or lower than 500?");
        print("Up Arrow for higher, Down Arrow for lower, and Return for equals.");


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed.");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed.");
        }

        if (Input.GetKeyDown(KeyCode.Equals))
        {
            print("I won!");
        }
	}
}

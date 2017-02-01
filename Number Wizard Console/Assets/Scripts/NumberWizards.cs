using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500;

	// Use this for initialization
	void Start () {
        StartGame();
	}

	void StartGame()
    {
        print("Welcome to Number Wizard");
        print("Pick a Number in your head, but don't tell me!");

        print("The highest number you can pick is: " + max);
        print("The lowest number you can pick is: " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Up Arrow for higher, Down Arrow for lower, and Return for equals.");

        max += 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
    }
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
        } else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // print("Up arrow pressed.");
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // print("Down arrow pressed.");
            max = guess;
            NextGuess();
        }


    }
}

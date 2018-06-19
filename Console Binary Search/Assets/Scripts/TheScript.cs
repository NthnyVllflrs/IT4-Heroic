using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheScript : MonoBehaviour 
{
	private int Min, Max, GuessedNumber;

	private void Awake() {
		Min = 1;
		Max = 500;
	}

	// Use this for initialization
	void Start ()
	{
		Debug.Log("Welcome Guest!");
		Debug.Log("Please pick a number between 1 and 500.");
		Display(Min, Max);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			Min = GuessedNumber;
			Display(GuessedNumber, Max);
		}

		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			Max = GuessedNumber;
			Display(Min, GuessedNumber);
		}

		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			Debug.Log("Your number is ---> " + GuessedNumber);
		}
	}

	void Display(int min, int max)
	{
		GuessedNumber = (min+max)/2;
		Debug.Log("Is this your number -> " + GuessedNumber);

		Debug.Log("Press Up Arrow if your number is higher.");
		Debug.Log("Press Down Arrow if your number is lower.");
		Debug.Log("Press Right Arrow if guessed your number.");
	}
}

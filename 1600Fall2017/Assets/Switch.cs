using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Switch : MonoBehaviour {

public int intelligence = 5;  

	void Greet ()
	{
		switch(intelligence);
		{
			case 5:
			print ("Hello, find person of which I am aquaninted with.");
			break;

			case 4:
			print("Hello friend.");
			break;

			case 3:
			print("hewwo");
			break;

			case 2:
			print("yiff");
			break;

			case 1:
			print("???");
			break;

			default:
			print("No Intelligence Found");
			break;

		}
	}


public string Gender;  
public string Man;
public string Woman;
public string Agender;
public string Nonbinary;
public string WhateverGenderPeopleWantToBe;

	void AllTheGenders ()
	{
		switch(Gender);
		{
			case Man:
			print ("Hello, I identify as a man, sometimes I use he/him pronouns");
			break;

			case Woman:
			print("Hello, I identify as a woman, sometimes I used she/her pronouns");
			break;

			case Agender:
			print("Hello, I don't have a gender, I may use they/them pronouns");
			break;

			case Nonbinary:
			print("Hello, I have a gender that is not fully, or maybe not partially, alligned with male or female. I may use Ze/Zim pronouns.");
			break;

			case WhateverGenderPeopleWantToBe:
			print("Hello, I don't fall into any of those catagories and you will respect my pronouns.");
			break;

			default:
			print("No Designated Gender Found");
			break;

		}
	}

}
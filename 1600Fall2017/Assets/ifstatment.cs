﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifstatment : MonoBehaviour {

public int num1;
public int num2;
public int value;
public int X;
public bool canPlay = true; 
public string input;
private string password = "ironmansucks";
public string input2;
public string Username = "Batman";
public bool OhNo = true;
public bool grapes;
public bool pain;
	// Use this for initialization
	void Start () {

		if (pain){
			print("undoubtedly");
		}

		if (grapes){
			print("Yas Queen");
		}

		if (X + num1 == 26){
			print("Mathmatics!");
		}

		if (X == 24){
			print("Okay!");
		}

		if (OhNo){
			print("I'm in a lot of pain....");
		}

		if(input == password){
		print("You know the password!");}

		if(input2 == Username){
		print("Good Username!");}

		if (4 + 6 == 10){
			print("Yes.....");
		}

		if (num1 + num2 == value)
		{
			print(value);
		}

if (canPlay){
print ("Play");}
	}

}

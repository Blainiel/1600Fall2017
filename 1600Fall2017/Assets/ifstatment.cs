using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifstatment : MonoBehaviour {

public int num1;
public int num2;
public int value;

public bool canPlay = true; 

public string input;
private string password = "G@m3Pl@y";
	// Use this for initialization
	void Start () {
		if (num1 + num2 == value)
		{
			print(value);
		}
if (input == password){
print("you know the password");}

if (canPlay){
print ("Play");}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

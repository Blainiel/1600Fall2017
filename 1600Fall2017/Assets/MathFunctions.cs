using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		myScore = ReturnNum(health, ammo);
		myPassword = ReturnPassword (myPassword);
		permission = YesNo (permission);
	}
	public bool permission;
	public int myScore;

	public int health;
	public int ammo;

	public string myPassword = "Batman";
	int ReturnNum (int _num, int _num2){
		return _num + _num2;}

	int ReturnZero (){
		return 0; 
	}
	void SendZero (){
		myScore = 0;
	}

	string ReturnPassword (string _login){
		if(_login == "ou812") {
			return "Password Correct";
			} else {

		return "Incorrect";}
	}

	bool YesNo (bool _Yes){
		return true;
	}


}
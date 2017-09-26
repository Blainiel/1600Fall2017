using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

public bool friends = false;
public bool loneliness = true;
public bool A = true;
public bool B = true;
public bool what = false;
public bool why = false;
	void Start () {
		
		if (friends && loneliness){
			print("Haha me? have friends? Nope.");
		}

		if (friends || loneliness){
			print("I like people.");
		}

		if (!(friends && loneliness)){
			print("I HAVE FRIENDS!");
		}
		if (A && B){
		print("This is true.");
	}
		if (A || B){
		print("This statment is also true.");
		}
		if (!(A && B)){
		print("This is FALSE! Liar.... mhm");
		}
		if (!(A || B)){
		print("This could be true.");
		}
		if (what && why){
			print("This is false...");
		}
		if (what || why){
			print("This is also false");
		}
		if (!(what && why)){
			print("this is true!");
		}
	// Update is called once per frame
	void Update () {
		
	}
}

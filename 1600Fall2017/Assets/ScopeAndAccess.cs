using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour {

private int health = 100;

public int score = 100;

void Box () {
	int newScore = 10;
	print(newScore);

	// this box can see everything... but the feild can't see into this.

	void Box2 (){
		int health = 50;
		print(health);
		// this box can also see everything..... but nothing else can see into this.
		// I can also change values.
	}
}

}

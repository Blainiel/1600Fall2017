using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the semi colons will end a line, you must end every line or you will have an error. 

// public means the object will be seen as compared to a private class which would not be seen.
public class ConventionsandSyntax : MonoBehaviour {

	// The colon between the title and monobehavior means ConventionsandSyntax is a subclass or MonoBehaviuor.

	// The curly Braces means this is an object and everything inside of it is part of the object.

	// Use this for initialization
	void Start () {
		
		string mystring = "I'm kinda stressed";
		// here is where you can put things if you want them to begin when the program starts.

		// typing print will add words onto the consol.

		// the parentathese (however you want to spell that) will be what is viewed on the consol.

		// you must add the quotes for a string that's not preset otherwise it will not be recognized as random characters.

		print("Good day! I might be learning, but my gitkraken does not want to work. :)");

		// as you saw at the top of the void start I added a decaration of a string variable.
		//below I will use that variable to print "I'm kinda stressed" on the consol.

		print(mystring);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

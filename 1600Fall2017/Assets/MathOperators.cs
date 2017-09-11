using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

// for the record I have no idea what I'm doing
int A = 10;
	// Use this for initialization
	void Start () {
		// Okay, what what I have down here is a function that will give you an output of 12. I'm adding the numbers together.
System.Console.WriteLine(4 + 8); 
System.Console.ReadLine(); 
// I am now subtracting 4 from 8. I should be left with 4.
System.Console.WriteLine(8 - 4); 
System.Console.ReadLine(); 
	// down here I am multiplying 4 and 8 and therefore should get an output of 32.
System.Console.WriteLine(4 * 8); 
System.Console.ReadLine(); 
// now here I am dividing 8 by 4 and should get an output of two.
System.Console.WriteLine(8 / 4); 
System.Console.ReadLine(); 
// i can even do multiple functions at the same time.
System.Console.WriteLine(4 + 8 * 3); 
System.Console.ReadLine(); 
// apparently this next one divides and calculates a remainder
System.Console.WriteLine(8 % 4); 
System.Console.ReadLine(); 
// The one should add 1 to the number.
System.Console.WriteLine(A ++); 
System.Console.ReadLine(); 
// and this one subtracts 1 from the number.
System.Console.WriteLine(A --); 
System.Console.ReadLine(); 
// this should give me a square root.
System.Console.WriteLine(System.Math.Sqrt(4)); 
System.Console.ReadLine(); 
// the champion of tonight follows by giving me powers of numbers.
System.Console.WriteLine(System.Math.Pow (2,4)); 
System.Console.ReadLine(); 

// this was all solo learning so it may not be what you want.... but it's what I found. Also your link is not working on canvas.

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

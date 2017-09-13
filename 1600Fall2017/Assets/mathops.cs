using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathops : MonoBehaviour {

	// Use this for initialization
	public float num1;
	public float num2;
	public float addResult;
	public float subResult;
	public float multResult;
	public float divResult;
	public float remainderResult;

	// Update is called once per frame
	void Update () {
		addResult = num1 + num2;{
			print(addResult);
		}
		subResult = num1 - num2;{
			print(subResult);
		}
		multResult = num1 * num2;{
			print(multResult);
		}
		if(num1 != 0 && num2 != 0){
			divResult = num1 / num2;{
				print(divResult);
			}
		} else {
			print("Can't divide by Zero");
		}

		remainderResult = num1 % num2;

	}
}

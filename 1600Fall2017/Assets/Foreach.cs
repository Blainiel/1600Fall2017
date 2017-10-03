using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] pets = { "horse", "ferret", "Watson" };

        foreach (string value in pets)
        {
            print(value);
        }
    }


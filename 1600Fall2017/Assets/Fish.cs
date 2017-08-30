using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal {
	// Use this for initialization
	    public override void Start(){
        base.Start();
        Swim();
    }
	 
	// Update is called once per frame
	void Update () {
}

void Swim () {
    print(this.name + " Swims");
}

}
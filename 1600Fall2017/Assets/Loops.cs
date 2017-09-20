using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loops : MonoBehaviour {

public bool canPlay = true;
public bool cantFocus = true;
int Time = 3;
int myAge = 18;
private string firstName = "Blaine";
public Text input;

public string done = "Yes";

void Start (){

while(Time > 1)
{
	print("I've spent time on this.");
}

while(Time < 1){
	print("I've spent almost no time on this!");
}

while(myAge >= 18){
	print("You're a bit old for this game.");
}

while(myAge < 18){
	print("Time to Learn Math!");
}
while(cantFocus){
	print("I'm trying.");
}
while(done == "Yes"){
	print("I'm tired");
}
while(done != "Yes"){
	print("I'm tired");
}


void Update(){
while(input.text == firstName){
	print("Hello Master, Benevolent Creator");
}
while(input.text != firstName){
	print("Liar!!!!! Help!!! Intruder!!!");
}
}



	StartCoroutine(PlayGame());
}

IEnumerator PlayGame () {
while (canPlay)
{
	print("Playing");
	yield return new WaitForSeconds(0.1f);
}
print("End Game");
}

}

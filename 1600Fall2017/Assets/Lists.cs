using UnityEngine;
using System.Collections.Generic;

public class Lists : MonoBehaviour
{
    public List<Homework> myHomework = new List<Homework> ();

    Homework.add( new Homework("essay", 50));
    Homework.add( new Homework("Math", 100));
    Homework.add( new Homework("Coding", 5));

    public Homework(string assignment = newname, int newtime){
        name = newname;
        time = newtime;
    }
    public int CompareTo (Homework other)
    {
        if(other == null){
            return 1;
        }
        {
            return time - other.time;
             
        }
    }
}

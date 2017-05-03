using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public Boat boat;
	public Goat goat; 
	public _Wolf wolf;
	public Cabbage cabbage;



	// Use this for initialization
	void Start () {
		boat.MoveToLeft ();
		goat.TakeSeat ();
		boat.MoveToRight ();
		goat.TakeBank ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

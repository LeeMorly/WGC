using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public Boat boat;
	public Goat goat; 
	public Wolf wolf;
	public Cabbage cabbage;
	public LeftBank Lb;
	public RightBank Rb;


	// Use this for initialization
	void Start () {
			
			boat.MoveToLeft ();
			boat.PickUp (goat);
			boat.MoveToRight ();
			goat.TakeBank (Rb.getPosition(goat));
			boat.LeaveUp (goat);

			boat.MoveToLeft ();
			boat.PickUp (wolf);
			boat.MoveToRight ();
			wolf.TakeBank (Rb.getPosition(wolf));
			boat.LeaveUp (wolf);
			boat.PickUp (goat);

			boat.MoveToLeft ();
			goat.TakeBank (Lb.getPosition(goat));
			boat.LeaveUp (goat);
			boat.PickUp(cabbage);
			boat.MoveToRight();
			cabbage.TakeBank(Rb.getPosition(cabbage));
			boat.LeaveUp (cabbage);

			boat.MoveToLeft ();
			boat.PickUp (goat);
			boat.MoveToRight ();
			goat.TakeBank (Rb.getPosition(goat));
			boat.LeaveUp (goat);





	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

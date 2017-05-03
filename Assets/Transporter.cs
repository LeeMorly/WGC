using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Transporter : MonoBehaviour {
	public float speed; 
	public Transform dzRight;
	public Transform dzLeft;

	public abstract void MoveToLeft (Boat boat );
	public abstract void MoveToRight (Boat boat );
	public abstract void PickUp (_Passangers Pas);
	public abstract void LeaveUp (_Passangers Pas); 

}

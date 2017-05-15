using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goat :_Passangers {
	public float speed;
//	public override void ChooseEat(_Passangers gm)
//	{
//
//		Destroy (gm);
//	}	
//	public override void TakeSeat(_Passangers goat)
//	{
//		goat.transform.SetParent (Boat.transform, false);
//	}
	public override void TakeBank(Transform target)
	{
		
		
		float step = speed;
		this.transform.position = Vector3.MoveTowards (this.transform.position, target.transform.position, step); 
		//this.transform.SetParent (target.transform.position, true);
	}

}

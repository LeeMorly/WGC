using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goat :_Passangers {
	public float speed;
	public override void ChooseEat(_Passangers gm){

		Destroy (gm);
	}	
	public override void TakeSeat(_Passangers goat)
	{
		goat.transform.SetParent (Boat.transform, false);
	}
	public override void TakeBank(_Passangers goat,Vector3 target)
	{
		goat.transform.SetParent (Transporter.dzRight.transform, false);
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.localPosition, target, step); 
	}

}

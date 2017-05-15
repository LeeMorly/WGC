using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabbage : _Passangers {
	public float speed;
//
//	public override void ChooseEat(_Passangers Pas){
//	}
//	public override void TakeSeat(_Passangers cabbage)
//	{
//		cabbage.transform.SetParent (Boat.transform, false);
//	}
//
	public override void TakeBank(Transform target)
		{


			float step = speed;
			this.transform.position = Vector3.MoveTowards (this.transform.position, target.transform.position, step); 

		}
}

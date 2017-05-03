using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabbage : _Passangers {

	public override void ChooseEat(_Passangers Pas){
	}
	public override void TakeSeat(_Passangers cabbage)
	{
		cabbage.transform.SetParent (Boat.transform, false);
	}

}

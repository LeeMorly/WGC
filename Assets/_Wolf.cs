using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Wolf : _Passangers {
	


	public override void ChooseEat(_Passangers Goat)
	{		
		Destroy ( Goat);
	}	
	public override void TakeSeat(_Passangers wolf)
	{
		wolf.transform.SetParent (Boat.transform, false);
	}



}

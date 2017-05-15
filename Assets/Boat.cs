using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boat : Transporter {
	


	public override void  MoveToLeft ()
	{

		float step = speed;
		this.transform.position = Vector3.MoveTowards (this.transform.position, dzLeft.transform.position, step);
		

	}
	public override void  MoveToRight ()

	{
		float step = speed;
		this.transform.position = Vector3.MoveTowards (this.transform.position, dzRight.transform.position, step);
	}

	public override void  PickUp (_Passangers Pas)

	{
			Pas.transform.SetParent (this.transform, true);
			Pas.transform.position = new Vector3( this.transform.position.x, this.transform.position.y, this.transform.position.z);

	}
	public override void  LeaveUp (_Passangers Pas)
	{
					Pas.transform.SetParent (dzLeft.transform);

	} 

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : Transporter {



	public override void  MoveToLeft (Boat boat ){

		float step = speed * Time.deltaTime;
		boat.transform.position = Vector3.MoveTowards (boat.transform.position, dzLeft.transform.position, step);
	}
	public override void  MoveToRight (Boat boat ){
		float step = speed * Time.deltaTime;
		boat.transform.position = Vector3.MoveTowards (boat.transform.position, dzRight.transform.position, step);
	}
	public override void  PickUp (_Passangers Pas){
		Pas.transform.SetParent (this.transform, false);
	}
	public override void  LeaveUp (_Passangers Pas){
		if (transform.position==dzLeft.transform.position) {
			Pas.transform.SetParent (dzLeft.transform);

		}
	} 

}

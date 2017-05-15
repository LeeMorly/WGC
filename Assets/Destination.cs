using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Destination: MonoBehaviour {
	public Transform[] Pos;

	public abstract Transform getPosition(_Passangers Pas);

}

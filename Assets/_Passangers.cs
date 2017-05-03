using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class _Passangers : MonoBehaviour {
	public Enums Banks;
	public bool eat;

	public Transform posLeft, posRight;
	public Transform curBank;

	public abstract void ChooseEat(_Passangers Pas);
	public abstract void TakeSeat(_Passangers Pas);
	public abstract void TakeBank (_Passangers Pas, Vector3 target);


}
	
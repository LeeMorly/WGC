using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enums : MonoBehaviour {
	
	public enum Banks {
		leftBank=1,
		rightBank=2
	}
	public Banks ActiveState = Banks.leftBank; 

	void Start () {
		foreach (var name in Enum.GetNames(typeof(Banks))) {
			Debug.Log (name);
		}
		foreach (Banks name in Enum.GetValues(typeof(Banks))) {
			Debug.Log ((int)name);
		}
	}

		void Update () {
			switch (ActiveState) {
			case Banks.leftBank:
				{
					Debug.Log ("Entered leftBank");
				}
				break;
			case Banks.rightBank:
				{
					Debug.Log ("Entered rightBank");
				}
				break;
			
			}
		}
}

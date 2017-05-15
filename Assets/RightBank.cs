using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBank : Destination
{
	//public Transform[] Pos;

	public override Transform getPosition(_Passangers Pas)
	{
		if (Pas is Goat) 
		{
			return Pos [0]; 

		}
		
		if (Pas is Wolf) 
		{
			return Pos [1]; 

		}
		
		if (Pas is Cabbage) 
		{
			return Pos [2]; 

		}
			return null;
	} 

}

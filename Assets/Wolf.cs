using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : _Passangers {

  public float speed;

  //    public override void ChooseEat(_Passangers Goat)
  //    {       
  //        Destroy ( Goat);
  //    }   
  //    public override void TakeSeat(_Passangers wolf)
  //    {
  //        wolf.transform.SetParent (Boat.transform, false);
  //    }
  public override void TakeBank(Transform target)
    {


      float step = speed;
      this.transform.position = Vector3.MoveTowards (this.transform.position, target.transform.position, step); 

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepairComponent : StepObject
{
   public Sprite image;

   
   void Start()
   {
       image = gameObject.GetComponent<SpriteRenderer>().sprite;
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Machine : StepObject
{
   public float workTime;
   public Sprite turnedOffImage;
   public Sprite turnedOnImage;

   private Sprite currentImage;
   public bool isTurnedOn = false;

   void Start()
   {
       currentImage = turnedOffImage;
   }

   public void FlipSwitch(){
       currentImage = isTurnedOn ? turnedOffImage : turnedOnImage;
       isTurnedOn = !isTurnedOn;
   }

    public override Sprite GetDefaultImage()
    {
        return turnedOffImage;
    }
}

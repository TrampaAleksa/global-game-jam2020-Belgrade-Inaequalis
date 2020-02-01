using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : StepObject
{
   public Sprite brokenImage;
   public Sprite fixedImage;
    public Sprite titleImage;

    public override Sprite GetDefaultImage()
    {
        return brokenImage;
    }
}

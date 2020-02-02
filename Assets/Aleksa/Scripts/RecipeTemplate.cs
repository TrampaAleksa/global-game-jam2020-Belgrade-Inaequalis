using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public struct Title
{
    public Image image;
    public Image text;
}


public class RecipeTemplate : MonoBehaviour
{
    public Title title;
    public Step[] steps;
    public Image[] stepImages;
}

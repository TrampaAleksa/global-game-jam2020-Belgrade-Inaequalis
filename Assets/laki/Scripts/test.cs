using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    Text txt;
    Opponent opponent;
    private void Start()
    {
        opponent = Opponent.Instance;
        txt = GetComponentInChildren<Text>();
    }
    private void Update()
    {
        txt.text = "The opponent completed: "+ opponent.PointsOfEnemy().ToString();
    }


}

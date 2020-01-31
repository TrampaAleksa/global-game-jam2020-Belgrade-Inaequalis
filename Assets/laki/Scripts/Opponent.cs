using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Opponent : MonoBehaviour
{
    public static Opponent Instance;
    public int delay;
    private void Awake()
    {
        Instance = this;
    }
    private int i;
    public bool OpponentMethod() 
    {
        i++;
        return true;
    }
    private void Start()
    {
        i = 0;
        LoopsHandler.LoopDelegate opponentDelegate = OpponentMethod;
        LoopsHandler.Instance.Loop(delay, opponentDelegate);
    }
    public int PointsOfEnemy()
    {
        return i;
    }
}

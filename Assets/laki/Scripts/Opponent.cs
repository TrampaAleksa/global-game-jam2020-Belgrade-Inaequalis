using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Opponent : MonoBehaviour
{
    Timer timer;

    public static Opponent Instance;
    public int delay;
    private void Awake()
    {
        Instance = this;
    }
    private void Update() {
        timer = Timer.Instance;
    }
    private int i;
    public bool OpponentMethod() 
    {
        i++;
        return timer.Check();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedSuccesfully : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "end")
        {
            print("Preso si igricu");
        }
    }
}

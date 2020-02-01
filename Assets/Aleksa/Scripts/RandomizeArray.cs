using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeArray
{
   public static T[] Randomize<T>(T[] objects)
    {
        for(int positionOfArray = 0; positionOfArray < objects.Length; positionOfArray++)
        {
            T obj = objects[positionOfArray];
            int randomizeArray = Random.Range(0, objects.Length);
            objects[positionOfArray] = objects[randomizeArray];
            objects[randomizeArray] = obj;
        }
        return objects;
    }
}

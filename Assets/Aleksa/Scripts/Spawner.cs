using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public static Spawner Instance;

    public GameObject spawner1;
    public GameObject spawner2;


    void Awake()
    {
        Instance = this;
    }


    public GameObject SpawnNewItem(GameObject objectToSpawn, int index)
    {
        if(index == 0 ) Instantiate(objectToSpawn, spawner1.transform.position, spawner1.transform.rotation);

        if (index == 1) Instantiate(objectToSpawn, spawner2.transform.position, spawner2.transform.rotation);

        return objectToSpawn;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlanet : MonoBehaviour
{
    public GameObject[] ranSpawn;

    GameObject SpawnPoint;

    void Start()
    {

        SpawnPoint = ranSpawn[Random.Range(0, ranSpawn.Length)];
        Instantiate(SpawnPoint, this.transform.position, this.transform.rotation);

    }
}
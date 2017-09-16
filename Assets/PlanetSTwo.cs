using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSTwo : MonoBehaviour
{
    public GameObject[] planetT; //??? //getting the other planets

    float distance; // distance

    float mass; // mass

    float gravityConstant = 6.673f; // <<<

    Vector3 velocity = Vector2.zero;

    void Start()
    {
        planetT = GameObject.FindGameObjectsWithTag("planet"); 
    }

    void FixedUpdate()
    {
        for (int i = 0; i < planetT.Length; i++)
        {
            for (int j = i + 1; j < planetT.Length; j++)
            {
                //calculate the gravitational force between planetT[i] and planetT[j]
                distance = Vector2.Distance(planetT[i].transform.position, planetT[j].transform.position);

                float gravityVectorMagnitude = gravityConstant * planetT[i].GetComponent<PlanetSTwo>().mass * planetT[j].GetComponent<PlanetSTwo>().mass / (distance * distance);

                Vector3 gravForceVec = planetT[i].transform.position - planetT[j].transform.position;

                Vector3 gravForceVecb = planetT[i].transform.position - planetT[j].transform.position;

                gravForceVec *= -1;
                //gravForceVecb *= 1;
                //calculate the acceleration caused by the gravitatinoal force for both planets
                //Vector3 acceleration = ;
                //calculate the new velocity for both planets using the above
                velocity = gravForceVec  / Time.fixedDeltaTime;
              
                gravityVectorMagnitude *= Time.fixedDeltaTime;

                transform.position += velocity / distance;

                //transform.position = Vector3.MoveTowards(transform.position, planetT[i].transform.position, gravityVectormagnitude);
            }
        }
    }
}

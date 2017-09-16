using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour {

    SphereCollider me; // getting the collider
    GameObject[] planetT; //??? //getting the other planets

    float distance; // distance
    float mass; // mass
    float gravityConstant = 6.673f; // <<<

    float forMass; // foreign mass

    Vector3 velocity = Vector2.zero; 

    float gravForm; // formula

    float calculatedGrav; // gravity over time

    void Start()
    {
        me = GetComponent<SphereCollider>(); // get collider for mass

        mass = me.GetComponent<SphereCollider>().radius; // get mass

        planetT = GameObject.FindGameObjectsWithTag("planet"); //??? //.GetComponent<GameObject>(); 
    }

    void FixedUpdate()
    {
        for (int i = 0; i < planetT.Length; i++)
        {
            for (int j = i+1; j < planetT.Length; j++)
            {
                //calculate the gravitational force between planetT[i] and planetT[j]
                distance = Vector2.Distance(planetT[i].transform.position, planetT[j].transform.position);

                float gravityVectormagnitude = gravityConstant * planetT[i].GetComponent<planet>().mass * planetT[j].GetComponent<planet>().mass / (distance * distance);

                Vector3 gravForceVec =  planetT[i].transform.position - planetT[j].transform.position;

                Vector3 gravForceVecb = planetT[i].transform.position - planetT[j].transform.position;
                
                //calulate x and y componets

                //gravForceVec *= -1;
                //calculate the acceleration caused by the gravitatinoal force for both planets
                //Vector3 acceleration = ;

                //calculate the new velocity for both planets using the above

                velocity = new Vector3(0, 0, 0);

                transform.position += velocity / distance;

                //transform.position = Vector3.MoveTowards(transform.position, planetT[j].transform.position, calculatedGrav);
            }
        }
    }
}

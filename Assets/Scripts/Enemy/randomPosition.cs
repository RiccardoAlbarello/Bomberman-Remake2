using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class randomPosition : MonoBehaviour
{


    public NavMeshAgent nma = null;
    public GameObject[] RandomPoint;
    private int CurrentRandom;
    public SceneMenu mS;
    

    private void Start()
    {
        
        RandomPoint = GameObject.FindGameObjectsWithTag("RandomPoint");
        
    }

    private void Update()
    {
        if (nma.hasPath == false)
        {
            CurrentRandom = Random.Range(0, RandomPoint.Length + 1);
            nma.SetDestination(RandomPoint[CurrentRandom].transform.position);
            //Debug.Log("Moving to RandomPoint " + CurrentRandom.ToString());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       

        if(other.CompareTag("Esplosione"))
        {

            Debug.Log("BananaSpecchiataNelCEsso");
            mS.Victory();
        }
    }
}

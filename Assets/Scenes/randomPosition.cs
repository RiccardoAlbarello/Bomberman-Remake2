using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class randomPosition : MonoBehaviour
{
    private NavMeshAgent nma = null;
    private GameObject[] RandomPoint;
    private int CurrentRandom;

    private void Start()
    {
        nma = this.GetComponent<NavMeshAgent>();
        RandomPoint = GameObject.FindGameObjectsWithTag("RandomPoint");
        Debug.Log("RandomPoints = " + RandomPoint.Length.ToString());
    }

    private void Update()
    {
        if (nma.hasPath == false)
        {
            CurrentRandom = Random.Range(0, RandomPoint.Length + 1);
            nma.SetDestination(RandomPoint[CurrentRandom].transform.position);
            Debug.Log("Moving to RandomPoint " + CurrentRandom.ToString());
        }
    }
    //private int direction1 = 1;
    //private Vector3 movement;


    ////public GameObject cubePrefab;
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    movement = new Vector3(2 * direction1, 0f, 0f);
    //    transform.position = transform.position + movement *  Time.deltaTime;
    //}

    //private void OnCollisionEnter(Collision collision)
    //{



    //    direction1 = direction1 * -1;
    //}
    //void DirezioneSu()
    //{
    //    movement = new Vector3(0f, 0f, 2 * direction1);
    //}

    //void DirezioneGiu()
    //{
    //    movement = new Vector3(0f, 0f, 2 * -direction1);
    //}
}

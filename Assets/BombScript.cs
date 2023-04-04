using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

    public GameObject colliderCubo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        colliderCubo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
            if(other.CompareTag("Player"))
            {
            colliderCubo.SetActive(true);
            Debug.Log("Diocanespawna");
            }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

    public GameObject colliderCubo;
    public float timerBomb = 3f;

    public MeshRenderer mR;
    
    
    // Start is called before the first frame update
    void Start()
    {
        colliderCubo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy(gameObject, 3);
        timerBomb -= Time.deltaTime;

        if(timerBomb <= 0)
        {
            mR.enabled = false;
            Debug.Log("Esplosione");
            
        }

       
       

        
    }

    private void OnTriggerExit(Collider other)
    {
            if(other.CompareTag("Player"))
            {
            colliderCubo.SetActive(true);
            
            }
    }
}

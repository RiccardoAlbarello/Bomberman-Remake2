using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSopra : MonoBehaviour
{

    public bool explosionSopra = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Wall"))
        {
            explosionSopra = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestra : MonoBehaviour
{

    public bool explosionDestra = true;
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
        if (other.CompareTag("Wall"))
        {
            explosionDestra = false;
            Debug.Log("ToccatoADestra");
        }
    }

    
}

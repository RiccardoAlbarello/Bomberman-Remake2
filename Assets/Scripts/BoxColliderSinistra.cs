using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderSinistra : MonoBehaviour
{
    public bool sinistra = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            sinistra = false;
            Debug.Log("Ciao");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            sinistra = true;
        }
    
    }
}

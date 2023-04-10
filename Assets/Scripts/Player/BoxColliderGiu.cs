using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderGiu : MonoBehaviour
{
    public bool giu = true;
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
            giu = false;
            Debug.Log("Ciao");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            giu = true;
        }
    }
}

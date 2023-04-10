using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderGiu : MonoBehaviour
{
    public bool giu = true;
    public bool giu2 = true;
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
        if(other.CompareTag("BloccoDaDistruggere"))
        {
           giu2 = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            giu = true;
        }

        if(other.CompareTag("BloccoDaDistruggere"))
        {
             giu2 = true;
        }
    }
}

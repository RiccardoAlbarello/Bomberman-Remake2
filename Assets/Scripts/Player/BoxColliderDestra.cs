using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderDestra : MonoBehaviour
{
    public bool destra = true;
    public bool destra2 = true;
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
        if(other.CompareTag("Wall"))
            {
                destra = false;
                //Debug.Log("Ciao");
            }
        if (other.CompareTag("BloccoDaDistruggere"))
        {
            destra2 = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Wall"))
        {
            destra = true;
        }
        if (other.CompareTag("BloccoDaDistruggere"))
        {
            destra2 = true;
        }
    }
}

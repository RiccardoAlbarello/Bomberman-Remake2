using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderSu : MonoBehaviour
{
    public bool su = true;
    public bool su2 = true;
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
            su = false;
            //Debug.Log("Ciao");
        }
        if (other.CompareTag("BloccoDaDistruggere"))
        {
            su2 = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            su = true;
        }
        if (other.CompareTag("BloccoDaDistruggere"))
        {
            su2 = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocchiCentrali : MonoBehaviour
{
    public int sizeX;
    public int sizeZ;

    public GameObject muro;

    public float distanzaX;
    public float distanzaZ;

    
    // Start is called before the first frame update
    void Start()
    {
        Matrix();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void Matrix()
    {
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeZ; j++)
            {
                GameObject tmp = Instantiate(muro);
                tmp.transform.SetParent(this.transform);
                tmp.transform.localPosition = new Vector3(i * distanzaX, 0, j * distanzaZ);
            }
        }

       
    
    }
}

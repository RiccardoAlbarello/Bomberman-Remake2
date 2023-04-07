using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuriVerticali : MonoBehaviour
{

    public int sizeX;
    public int sizeZ;

    public int distanceX;

    public GameObject muro;
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
                tmp.transform.localPosition = new Vector3(i * distanceX, 0, j);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMuri : MonoBehaviour
{
    [Header("SopraeSotto")]
    public int sizeXSopraSotto;
    public int sizeZSopraSotto;
    public float distanzaXSopraSotto;
    public float distanzaZSopraSotto;

    [Header("BlocchiCentrali")]
    public int sizeXCentro;
    public int sizeZCentro;
    public float distanzaXCentro;
    public float distanzaZCentro;

    [Header("SinistraDestra")]
    public int sizeXSinistraDestra;
    public int sizeZSinistraDestra;
    public float distanzaXSinistraDestra;
    public float distanzaZSinistraDestra;

    public GameObject muro;
    public GameObject sopraSotto;
    public GameObject spawnCentrale;
    public GameObject sinistraDestra;
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
        //sopra e sotto
        for (int i = 0; i < sizeXSopraSotto; i++)
        {
            for (int j = 0; j < sizeZSopraSotto; j++)
            {
                GameObject tmp = Instantiate(muro);
                tmp.transform.SetParent(sopraSotto.transform);
                tmp.transform.localPosition = new Vector3(i * distanzaXSopraSotto, 0, j * distanzaZSopraSotto);
            }
        }

        //centrali
        for (int i = 0; i < sizeXCentro; i++)
        {
            for (int j = 0; j < sizeZCentro; j++)
            {
                GameObject tmp = Instantiate(muro);
                tmp.transform.SetParent(spawnCentrale.transform);
                tmp.transform.localPosition = new Vector3(i * distanzaXCentro, 0, j * distanzaZCentro);
            }
        }

        //sinistra e destra

        for (int i = 0; i < sizeXSinistraDestra; i++)
        {
            for (int j = 0; j < sizeZSinistraDestra; j++)
            {
                GameObject tmp = Instantiate(muro);
                tmp.transform.SetParent(sinistraDestra.transform);
                tmp.transform.localPosition = new Vector3(i * distanzaXSinistraDestra, 0, j * distanzaZSinistraDestra);
            }
        }



    }
}







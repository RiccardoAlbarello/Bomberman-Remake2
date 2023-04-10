using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloccoDaDistruggere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Esplosione"))
        {
            Destroy(gameObject);
            Debug.Log("FUSDHFUIKSHFSUKAHFKJSFHJKSDHFKJSKHJDFS");
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.name == "FolderPrefabSotto")
    //    {
    //        Debug.Log("FUSDHFUIKSHFSUKAHFKJSFHJKSDHFKJSKHJDFS");
    //        Destroy(gameObject);
    //    }
    //}


}

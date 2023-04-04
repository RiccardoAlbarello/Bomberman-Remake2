using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelPlayer : MonoBehaviour
{
    public GameObject proiettile;
    public Transform barrel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            var spawnedBullet = Instantiate(proiettile, barrel.position, barrel.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelPlayer : MonoBehaviour
{
    public GameObject proiettile;
    public Transform barrel;

    public PlayerMovement2 pM;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Jump") && pM.isMoving == false)
        {
            var spawnedBullet = Instantiate(proiettile, barrel.position, barrel.rotation);
        }
    }
}

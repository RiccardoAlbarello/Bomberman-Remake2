using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    float h = 0;
    float v = 0;
    public float speed = 5;

    private void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(h * Time.deltaTime * speed, 0, v * Time.deltaTime * speed);
    }
}

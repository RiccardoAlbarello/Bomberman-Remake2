using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    Vector3 PlayerMovementInput;

    public Rigidbody playerBody;

    public float speed;

    private void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * speed;
        playerBody.velocity = new Vector3(MoveVector.x, 0f, MoveVector.z);
    }
}

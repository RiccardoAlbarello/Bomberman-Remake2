using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public enum GamepadButton
    {
        
    }
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        transform.(0, 0, 2f);
    //    }

    //    if (Input.GetKeyDown(KeyCode.S))
    //    {
    //        transform.Translate(0, 0, -2f);
    //    }

    //    if (Input.GetKeyDown(KeyCode.D))
    //    {
    //        transform.Translate(2f, 0, 0);
    //    }

    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        transform.Translate(-2f, 0, 0);
    //    }
    //}

    private bool isMoving;
    private Vector3 origPos, targetPos;
    public float timeToMove = 0.5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.forward * 2));
        }

        if (Input.GetKeyDown(KeyCode.A) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.left * 2));
        }

        if (Input.GetKeyDown(KeyCode.S) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.back * 2));


        }

        if (Input.GetKeyDown(KeyCode.D) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.right * 2));
        }
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;



        isMoving = false;
    }

}

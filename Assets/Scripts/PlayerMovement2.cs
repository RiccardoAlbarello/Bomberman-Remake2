using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

    public BoxColliderDestra bD;
    public BoxColliderGiu bG;
    public BoxColliderSinistra bS;
    public BoxColliderSu bSu;


    //private void Update()
    //{

    //    SuK();
    //    GiuK();
    //    DestraK();
    //    SinistraK();





    //}



    //public void SuK()
    //{
    //    if (Input.GetKeyDown(KeyCode.W) && bSu.su)
    //    {
    //        transform.Translate(0, 0, 2f);
    //    }
    //}

    //public void GiuK()
    //{
    //    if (Input.GetKeyDown(KeyCode.S) && bG.giu)
    //    {
    //        transform.Translate(0, 0, -2f);
    //    }
    //}

    //public void DestraK()
    //{
    //    if (Input.GetKeyDown(KeyCode.D) && bD.destra)
    //    {
    //        transform.Translate(2f, 0, 0);
    //    }

    //}
    //public void SinistraK()
    //{
    //    if (Input.GetKeyDown(KeyCode.A) && bS.sinistra)
    //    {
    //        transform.Translate(-2f, 0, 0);
    //    }
    //}

    private bool isMoving;
    private Vector3 origPos, targetPos;
    public float timeToMove = 0.5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !isMoving && bSu.su)
        {
            StartCoroutine(MovePlayer(Vector3.forward * 2));
        }

        if (Input.GetKeyDown(KeyCode.A) && !isMoving && bS.sinistra)
        {
            StartCoroutine(MovePlayer(Vector3.left * 2));
        }

        if (Input.GetKeyDown(KeyCode.S) && !isMoving && bG.giu)
        {
            StartCoroutine(MovePlayer(Vector3.back * 2));


        }

        if (Input.GetKeyDown(KeyCode.D) && !isMoving && bD.destra)
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

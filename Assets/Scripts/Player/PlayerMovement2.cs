using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

    public BoxColliderDestra bD;
    public BoxColliderGiu bG;
    public BoxColliderSinistra bS;
    public BoxColliderSu bSu;


    

    public bool isMoving;
    private Vector3 origPos, targetPos;
    public float timeToMove = 0.5f;

    public int vita = 3;

    public SceneMenu sM;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !isMoving && bSu.su && bSu.su2 )
        {
            StartCoroutine(MovePlayer(Vector3.forward * 2));
        }

        if (Input.GetKeyDown(KeyCode.A) && !isMoving && bS.sinistra && bS.sinistra2)
        {
            StartCoroutine(MovePlayer(Vector3.left * 2));
        }

        if (Input.GetKeyDown(KeyCode.S) && !isMoving && bG.giu && bG.giu2)
        {
            StartCoroutine(MovePlayer(Vector3.back * 2));


        }

        if (Input.GetKeyDown(KeyCode.D) && !isMoving && bD.destra && bD.destra2)
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {

            Debug.Log("Banana");
            sM.GameOver();

        }

        if(other.CompareTag("Esplosione"))
        {
            vita--;
        }
    }



}

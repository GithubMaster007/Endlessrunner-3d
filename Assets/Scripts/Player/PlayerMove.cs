using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float forwardSpeed = 3f;
    public float sideSpeed = 4f;
    static public bool canMove = false;

    public bool isJumping = false;
    public bool comingDown = false;

    public GameObject playerObject;

    private void Start()
    {
        playerObject.GetComponent<Animator>().Play("Breathing Idle");
    }

    void Update()
    {
        

        if (canMove)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed, Space.World);

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (transform.position.x > LevelBoundaries.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * sideSpeed, Space.World);
                }
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (transform.position.x < LevelBoundaries.rightSide)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * sideSpeed, Space.World);
                }
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if (!isJumping)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    
                    StartCoroutine(JumpSequence());
                }
            }

        }

        if (isJumping)
        {
            if (!comingDown)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            if(comingDown)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);

            }
        }

        
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        comingDown = false;
        isJumping = false;

        if (canMove)
        {
            playerObject.GetComponent<Animator>().Play("Fast Run");
            transform.position = new Vector3(transform.position.x, 1.08f, transform.position.z);
        }

    }

}

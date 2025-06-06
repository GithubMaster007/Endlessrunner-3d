using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject Player;

    void Update()
    {
        if (PlayerMove.canMove)
        {
            transform.Rotate(10f, 0f * Time.deltaTime, 1f, Space.Self);
            transform.position = new Vector3(Player.transform.position.x, 1.58f, Player.transform.position.z - 3f);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{


    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject cam;
    public GameObject levelControll;

    private void Start()
    {
        crashThud = GameObject.Find("CrashThud").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerMove.canMove = false;
        thePlayer.transform.position = new Vector3(thePlayer.transform.position.x, 1.08f, thePlayer.transform.position.z);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Knocked Down");
        levelControll.GetComponent<LevelDistance>().enabled = false;
        crashThud.Play();
        cam.GetComponent<Animator>().enabled = true;
        levelControll.GetComponent<EndRunSequence>().enabled = true;
    }
}

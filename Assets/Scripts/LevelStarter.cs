using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter :MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource goFX;
    public AudioSource readyFX;
    public GameObject playerObject;


    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(2);
        countDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        countDown3.SetActive(false);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        countDown2.SetActive(false);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
        countDown1.SetActive(false);
        goFX.Play();
        PlayerMove.canMove = true;
        playerObject.GetComponent<Animator>().Play("Fast Run");
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(false);


    }
     
}

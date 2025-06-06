using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;

    private void Start()
    {
        coinFX = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollactableControl.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}

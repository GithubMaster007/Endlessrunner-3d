using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollactableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject therealonecoin;
    public GameObject coinEndDisplay;
    void Update()
    {
        therealonecoin.GetComponent<Text>().text = " " + coinCount;
        coinEndDisplay.GetComponent<Text>().text = " " + coinCount;


    }
}

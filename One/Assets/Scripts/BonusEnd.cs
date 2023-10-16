using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusEnd : MonoBehaviour
{
    public GameObject secretEnding;
    public GameObject cake;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cake.SetActive(false);
        secretEnding.SetActive(true);
    }
}

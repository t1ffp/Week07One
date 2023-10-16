using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckEnemy : MonoBehaviour
{
    public Shoot shootScript;
    public GameObject endScreen;


    private void Start()
    {
        endScreen.gameObject.SetActive(false);
    }
    void Update()
    {
        
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length == 0)
        {
            Destroy(shootScript.BulletIns);
            endScreen.gameObject.SetActive(true);
        }
        


    }
}

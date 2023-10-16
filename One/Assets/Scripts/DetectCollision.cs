using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public Animator enemyAnim;
    public GameObject enemy;


    private void Start()
    {
        enemyAnim.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyAnim.SetBool("isHit", true);
        //enemy.gameObject.isStatic = true;
    }

}

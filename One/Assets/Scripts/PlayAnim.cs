using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        playerAnim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            playerAnim.SetBool("isShooting", true);
        }
        else
        {
            playerAnim.SetBool("isShooting", false);
        }
     
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    
    public float launchForce;

    private bool canShoot = true;

    public GameObject BulletIns;

    public Animator playerAnim;


    private void Start()
    {
        playerAnim.GetComponentInParent<Animator>();
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0) && canShoot == true)
        {
            playerAnim.SetBool("isShooting", true);
            ShootBullet();
            canShoot = false;
        }
     

    }

    public void ShootBullet()
    {
      
        BulletIns = Instantiate(bullet, transform.position, transform.rotation);

        BulletIns.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;


    }



}

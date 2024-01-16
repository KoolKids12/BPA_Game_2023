using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    public GameObject pumpkinPrefab;
    public float fireForce = 40f;

    public void Fire(Transform firePoint)
    {
        GameObject pumpkin = Instantiate(pumpkinPrefab, firePoint.position, firePoint.rotation);    //creates the pumpkin projectile and gives it force
        pumpkin.GetComponent<Rigidbody2D>().AddForce(firePoint.up *fireForce, ForceMode2D.Impulse);
    }

    public void OnTriggerEnter2D(Collider2D collision)  // destroys the pumpkin when it hits a troop
    {
        Troop troop = collision.gameObject.GetComponent<Troop>(); 

        if (troop != null)
        { 
            Destroy(pumpkinPrefab); 
            troop.TakeDamage(3f);
        }
    }
}

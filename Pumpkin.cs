using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    public GameObject pumpkinPrefab;
    public Transform firePoint;
    public float fireForce = 40f;

    public void Fire()
    {
        GameObject pumpkin = Instantiate(pumpkinPrefab, firePoint.position, firePoint.rotation);
        pumpkin.GetComponent<Rigidbody2D>().AddForce(firePoint.up *fireForce, ForceMode2D.Impulse);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Troop troop = collision.gameObject.GetComponent<Troop>();

        if (troop != null)
        { 
            Destroy(pumpkinPrefab);
            troop.TakeDamage(3f);
        }
    }
}

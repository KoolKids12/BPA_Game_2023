using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
     public GameObject arrowPrefab;
    public Transform firePoint;
    public float fireForce = 40f;

    public void Fire()
    {
        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        arrow.GetComponent<Rigidbody2D>().AddForce(firePoint.up *fireForce, ForceMode2D.Impulse);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Troop troop = collision.gameObject.GetComponent<Troop>();

        if (troop != null)
        { 
            Destroy(arrowPrefab);
            troop.TakeDamage(1f);
        }
    }
}

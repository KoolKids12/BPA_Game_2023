using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
     public GameObject arrowPrefab;
    public float fireForce = 40f;

    public void Fire(Transform firePoint)
    {
        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation); // summons arrow
        arrow.GetComponent<Rigidbody2D>().AddForce(firePoint.up *fireForce, ForceMode2D.Impulse); // adds force
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Troop troop = collision.gameObject.GetComponent<Troop>();

        if (troop != null)
        { 
            Destroy(arrowPrefab); // destroys the arrow when it hits a troop
            troop.TakeDamage(1f); // makes the troop take damage
        }
    }
}

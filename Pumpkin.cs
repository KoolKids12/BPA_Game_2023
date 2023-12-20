using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    public GameObject pumpkinPrefab;
    public Transform firePoint;
    public float fireForce = 5f;
    public float Attackcooldown = 5.0f;
    private float nextAttackTime;

    public void Fire()
    {
        Debug.Log("CheckTime");
        if (Time.time >= nextAttackTime)
        {
            Debug.Log("Fired");
            GameObject pumpkin = Instantiate(pumpkinPrefab, firePoint.position, firePoint.rotation);
            pumpkin.GetComponent<Rigidbody2D>().AddForce(firePoint.up *fireForce, ForceMode2D.Impulse);
            nextAttackTime = nextAttackTime + Time.time;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Troop troop = collision.gameObject.GetComponent<Troop>();

        if (troop != null)
        {
            troop.TakeDamage(3);
        }
        else
        {

        }
    }
}

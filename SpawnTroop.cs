using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTroop : MonoBehaviour
{
    [SerializeField] public int TroopAmount;
    [SerializeField] public GameObject Troop;
    public Transform placement;
    private bool dragging = false;
    private Vector3 offset;

    void Start()
    {

    }
    public void SpawnTroops()
    {
        

        if (TroopAmount > 0)
        {
            GameObject Square = Instantiate(Troop, placement.position, placement.rotation);
            TroopAmount--;
        }
    }
}
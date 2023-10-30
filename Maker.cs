using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker : MonoBehaviour
{
    public GameObject SquarePrefab;
    public Transform loadpoint;

    public void SpawnBuilding()
    {
        GameObject Square = Instantiate(SquarePrefab, loadpoint.position, loadpoint.rotation);
    }
}

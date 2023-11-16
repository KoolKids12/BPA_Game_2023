using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buybutton : MonoBehaviour
{
    public GameObject SquarePrefab;
    private bool spawningEnabled = false;
    private int clicksRemaining = 0;

    // Update is called once per frame
    void Update()
    {
        if (spawningEnabled && clicksRemaining > 0 && Input.GetMouseButtonDown(0))
        {
            SpawnBuilding();
            clicksRemaining--;

            if (clicksRemaining == 0)
            {
                Debug.Log("No more clicks remaining");
                spawningEnabled = false;
            }
        }
    }

    public void BuyButtonClicked()
    {
        spawningEnabled = true;
        clicksRemaining = 10;
        Debug.Log("Buy button clicked! You have 10 clicks to spawn the block.");
    }

    void SpawnBuilding()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Instantiate(SquarePrefab, spawnPosition, Quaternion.identity);
    }
}
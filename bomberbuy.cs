using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomberbuybutton : MonoBehaviour
{
    public GameObject BomberPrefab; // Reference to the Bomber prefab
    private bool spawningEnabled = false;
    private int clicksRemaining = 0;

    // Update is called once per frame
    void Update()
    {
        if (spawningEnabled && clicksRemaining > 0 && Input.GetMouseButtonDown(0))
        {
            SpawnBomber();
            clicksRemaining--;

            if (clicksRemaining == 0)
            {
                Debug.Log("No more clicks remaining");
                spawningEnabled = false;
            }
        }
    }

    public void BomberButtonClicked()
    {
        spawningEnabled = true;
        clicksRemaining = 10;
        Debug.Log("Buy button clicked! You have 10 clicks to spawn the bomber.");
    }

    void SpawnBomber()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        GameObject bomber = Instantiate(BomberPrefab, spawnPosition, Quaternion.identity);
        bomber.tag = "Square"; // Set the tag to "Square"
    }
}

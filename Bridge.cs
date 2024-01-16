using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    [SerializeField] public BuildingProperties bridge;

    void Awake() // stes health for bridge... we later decided for the bridge to not be destroyable.
    {
        if (gameObject.tag == "Bridge1")
        {
            bridge.maxhealth = 8;
            bridge.currenthealth = bridge.maxhealth;
        }
        else if (gameObject.tag == "Bridge2")
        {
            bridge.maxhealth = 10;
            bridge.currenthealth = bridge.maxhealth;
        }
        else if (gameObject.tag == "Bridge3")
        {
            bridge.maxhealth = 12;
            bridge.currenthealth = bridge.maxhealth;
        }
    }
}

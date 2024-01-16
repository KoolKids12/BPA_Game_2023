using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunt : MonoBehaviour
{
    [SerializeField] public Troop grunt;

    public void SetTroop(Troop grunter) // gets troop
    {
        grunt = grunter;

        if (grunt != null) // checks if troop is null
        {
            grunt.maxhealth = 5; // setss health
            grunt.currenthealth = grunt.maxhealth;
            grunt.dealdamage = 1;// sets damage
        }
    }
}

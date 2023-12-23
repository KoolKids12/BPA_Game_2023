using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunt : MonoBehaviour
{
    [SerializeField] public Troop grunt;

    public void SetTroop(Troop grunter)
    {
        grunt = grunter;

        if (grunt != null)
        {
            grunt.maxhealth = 9;
            grunt.currenthealth = grunt.maxhealth;
            grunt.dealdamage = 1;
        }
    }
}

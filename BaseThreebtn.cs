using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseThreebtn : MonoBehaviour
{
    public void Button_Click()
    {
        SceneManager.LoadScene("AttackBase3");// opens scene to attack
    }
}

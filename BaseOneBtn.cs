using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseOneBtn : MonoBehaviour
{
    public void Button_Click()
    {
        SceneManager.LoadScene("AttackBase1");// opens scene to attack
    }
}

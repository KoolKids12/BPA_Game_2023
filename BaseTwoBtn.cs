using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseTwoBtn : MonoBehaviour
{
    public void Button_Click()
    {
        SceneManager.LoadScene("AttackBase2");// opens scene to attack
    }
}

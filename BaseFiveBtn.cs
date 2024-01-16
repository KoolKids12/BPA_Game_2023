using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseFiveBtn : MonoBehaviour
{
    public void Button_Click()
    {
        SceneManager.LoadScene("AttackBase5"); // opens scene to attack
    }
}
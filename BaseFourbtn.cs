using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseFourbtn : MonoBehaviour
{
    public void Button_Click()
    {
        SceneManager.LoadScene("AttackBase4");// opens scene to attack
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenAttackMenu : MonoBehaviour
{
    public void OnAtackButton_Clicked()
    {
        SceneManager.LoadScene("Campaign"); // opens campaign menu to attack
    }
}

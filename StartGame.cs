using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void ButtonStart_Click()
    {
        SceneManager.LoadScene("HomeBaseLevelTwo"); // opens scene in parenthises 
    }
}
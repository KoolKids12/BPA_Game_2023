using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CampaignButton : MonoBehaviour
{
    public void ButtonClicked()
    {
        SceneManager.LoadScene("Campaign"); // loads the scene to select what to battle
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public GameObject gamePanel;
    
    public void OnToggleButtonPress()
    {
        if(gamePanel.active)
        {
            gamePanel.SetActive(false);
        }
        else
        {
            gamePanel.SetActive(true);
        }
    }
}

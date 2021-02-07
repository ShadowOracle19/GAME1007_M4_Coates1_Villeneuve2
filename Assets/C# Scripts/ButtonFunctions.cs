using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public GameObject gamePanel;
    ResourceButtonManager resourceButtonManager;

    private void Awake()
    {
        resourceButtonManager = GetComponent<ResourceButtonManager>();
    }

    public void OnToggleButtonPress()
    {
        if(gamePanel.active)
        {
            gamePanel.SetActive(false);
        }
        else
        {
            gamePanel.SetActive(true);
            //resourceButtonManager.InitializeGame();

        }
    }
    public void ScannerEnable()
    {
        resourceButtonManager.isInScannerMode = true;
        resourceButtonManager.isInExcavationMode = false;
    }
    public void ExcavatorEnable()
    {
        resourceButtonManager.isInExcavationMode = true;
        resourceButtonManager.isInScannerMode = false;
    }

}

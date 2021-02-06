using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ResourceButtonManager : MonoBehaviour
{
    public GameObject resourceButton;
    public Transform panelParent;   
    public TextMeshProUGUI scanCountText;
    public TextMeshProUGUI modeText;
    public TextMeshProUGUI resourcesCollected;
    public int resources;
    public bool isInScannerMode, isInExcavationMode;
    public int[] ResourceCount = new int[20];
    int tempNum, i = 0, currentIndex = 0;
    public int scansLeft = 5;
    int scans = 5;
    public bool ableToScan = true;

    void Awake()
    {
        InitializeGame();
    }

    void Update()
    {
        scanCountText.SetText("Scans Left: " + scans);
        
        if(isInScannerMode)
        {
            modeText.SetText("Scanner");
        }
        else if(isInExcavationMode)
        {
            modeText.SetText("Excavation");

        }
    }

    public void ScanButton(int resourceAvalible)
    {
        if (isInScannerMode == false)
            return;

        if(scansLeft <= 1)
        {
            ableToScan = false;
            scans -= 1;
        }

        else
        {
            scansLeft -= 1;
            scans -= 1;
        }
        
    }

    public void ExcavateButton(int resourceAvalible)
    {
        //foreach (var text in resourceText)
        //{
        //    ResourceCount[currentIndex] = ResourceCount[currentIndex] / 2;
        //    text.SetText(ResourceCount[currentIndex].ToString());
        //    currentIndex += 1;
        //}
        //currentIndex = 0;
        resources += resourceAvalible;
        resourcesCollected.SetText(resources.ToString());

        
            //_resource.GetComponent<ScanFunction>().resourceAvaliable = _resource.GetComponent<ScanFunction>().resourceAvaliable / 2;
        
    }

    public void InitializeGame()
    {
        for (int i = 0; i <= 1022; i++)
        {
            Instantiate(resourceButton, panelParent);
        }
        
        scansLeft = 5;
        scans = 5;
        ableToScan = true;
        isInExcavationMode = true;
    }
}

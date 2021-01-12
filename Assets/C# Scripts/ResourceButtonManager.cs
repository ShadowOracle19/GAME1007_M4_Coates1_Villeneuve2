using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ResourceButtonManager : MonoBehaviour
{
    public TextMeshProUGUI[] resourceText;
    public TextMeshProUGUI scanCountText;
    public int[] ResourceCount = new int[20];
    int tempNum, i = 0;
    public int scansLeft = 5;
    int scans = 5;
    public bool ableToScan = true;
    // Start is called before the first frame update
    void Awake()
    {
        //Debug.Log(resourceText.Length);
        //for (int i = 0; i < resourceText.Length; i++)
        //{

        //    ResourceCount[i] = (int)Random.Range(1000f, 5000f);
        //    Debug.Log(ResourceCount[i]);
        //    resourceText[i].SetText(ResourceCount[i].ToString());

        //}
        
        foreach (var text in resourceText)
        {
            Debug.Log(i);
            tempNum = Random.Range(1000, 5000);
            text.SetText(tempNum.ToString());
            ResourceCount[i] = tempNum;
            i += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scanCountText.SetText("Scans Left: " + scans);
    }

    public void ScanButton()
    {
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScanFunction : MonoBehaviour
{
    public TextMeshProUGUI numText;
    public ResourceButtonManager RBM;
    public int scanCount;
    public int resourceAvaliable;
    private void OnEnable()
    {
        numText.enabled = false;
        resourceAvaliable = Random.Range(1000, 5000);
        numText.SetText(resourceAvaliable.ToString());
    }

    private void Update()
    {
        numText.SetText(resourceAvaliable.ToString());
    }
    public void onButtonClick()
    {
        if (RBM.isInScannerMode)
        {
            if (RBM.ableToScan)
            {
                numText.enabled = true;
                RBM.ScanButton(resourceAvaliable);

            }
        }

        if(RBM.isInExcavationMode)
        {
            RBM.ExcavateButton(resourceAvaliable);
            resourceAvaliable = 0;
        }
        
    }
}

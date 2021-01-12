using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScanFunction : MonoBehaviour
{
    public TextMeshProUGUI numText;
    public ResourceButtonManager RBM;
    public int scanCount;

    public void onButtonClick()
    {
        if(RBM.ableToScan)
        {
            numText.enabled = true;
            RBM.ScanButton();
        }
        
    }
}

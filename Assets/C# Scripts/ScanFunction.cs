using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ScanFunction : MonoBehaviour
{
    public Image image;
    public GameObject hider;
    public TextMeshProUGUI numText;
    public ResourceButtonManager RBM;
    public int scanCount;
    public int resourceAvaliable;
    private void OnEnable()
    {
        numText.enabled = false;
        hider.SetActive(true);
        resourceAvaliable = Random.Range(1000, 5000);
        numText.SetText(resourceAvaliable.ToString());

        if(resourceAvaliable <= 1500)
        {
            image.color = Color.red;
        }
        else if(resourceAvaliable <= 3000)
        {
            image.color = Color.yellow;
        }
        else
        {
            image.color = Color.green;
        }
    }

    private void Update()
    {
        numText.SetText(resourceAvaliable.ToString());
        if (resourceAvaliable <= 1500)
        {
            image.color = Color.red;
        }
        else if (resourceAvaliable <= 3000)
        {
            image.color = Color.yellow;
        }
        else
        {
            image.color = Color.green;
        }
    }
    public void onButtonClick()
    {
        if (RBM.isInScannerMode)
        {
            if (RBM.ableToScan)
            {
                hider.SetActive(false);
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

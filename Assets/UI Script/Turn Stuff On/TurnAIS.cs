using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAIS : MonoBehaviour
{
    public GameObject AIS;
    
    public void pressButtonToOn()
    {
        if (AIS != null)
        {
            bool isActive = AIS.activeSelf;
            AIS.SetActive(!isActive);
        }


    }
}

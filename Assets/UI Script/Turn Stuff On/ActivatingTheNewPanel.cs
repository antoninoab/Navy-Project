using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingTheNewPanel : MonoBehaviour
{
    public GameObject VMS;
    public GameObject AIS;
    public GameObject Radar;
    public GameObject Start;
    public GameObject EnterSimulationButton;
    public GameObject Fog;
    public GameObject ToggleNight;



    public void OpenPanel()
    {
        if(VMS != null && AIS != null && Radar != null)
        {
            VMS.SetActive(true);
            AIS.SetActive(true);
            Radar.SetActive(true);
            Start.SetActive(false);
            EnterSimulationButton.SetActive(true);
            Fog.SetActive(true);
            ToggleNight.SetActive(true);

        }

    }
   
}

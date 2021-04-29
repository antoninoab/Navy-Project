using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter_Simulation : MonoBehaviour
{
    public GameObject VMS;
    public GameObject AIS;
    public GameObject Radar;
    public GameObject Start;
    public GameObject EnterSimulationButton;
    public GameObject Fog;
    public GameObject ThirdPerson;
    public GameObject ThirdPerson2;
    public GameObject ThirdPerson3;
    public GameObject StudentTextDisplay;
    public GameObject TeacherTextDisplay;
    public GameObject ToggleNight;



    public void ClosePanel()
    {
        if (VMS != null && AIS != null && Radar != null)
        {
            VMS.SetActive(false);
            AIS.SetActive(false);
            Radar.SetActive(false);
            Start.SetActive(false);
            EnterSimulationButton.SetActive(false);
            Fog.SetActive(false);
            ThirdPerson.SetActive(true);
            ThirdPerson2.SetActive(true);
            ThirdPerson3.SetActive(true);
            TeacherTextDisplay.SetActive(false);
            StudentTextDisplay.SetActive(true);
            ToggleNight.SetActive(false);
            
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRadar : MonoBehaviour
{
    public GameObject Radar;
    public GameObject Radar_Map;
    public void pressButtonToOn()
    {
        if (Radar != null)
        {
            bool isActive = Radar.activeSelf;
            bool isActive2 = Radar_Map.activeSelf;

            Radar.SetActive(!isActive);
            Radar_Map.SetActive(!isActive2);

        }


    }
}

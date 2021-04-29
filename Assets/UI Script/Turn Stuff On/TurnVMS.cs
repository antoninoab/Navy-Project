using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnVMS : MonoBehaviour
{

    public GameObject VMS;
    public GameObject VMS_Map;
    public void pressButtonToOn()
    {
        if (VMS != null)
        {
            bool isActive = VMS.activeSelf;
            bool isActive2 = VMS_Map.activeSelf;

            VMS.SetActive(!isActive);
            VMS_Map.SetActive(!isActive2);

        }


    }
}

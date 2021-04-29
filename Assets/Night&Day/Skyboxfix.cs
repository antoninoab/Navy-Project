using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyboxfix : MonoBehaviour
{

    public Material skyboxNight;

    public void Toggle_Changed2(bool newValue)
    {

        RenderSettings.skybox = skyboxNight;
        
    }

}

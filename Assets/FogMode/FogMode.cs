using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FogMode : MonoBehaviour
{
    // Start is called before the first frame update

    
  
    public void Toggle_Changed(bool newValue)
    {
        RenderSettings.fog = newValue;
    }
                
   


}

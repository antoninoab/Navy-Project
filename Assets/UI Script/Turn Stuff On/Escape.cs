//=============================================================================
//=============================================================================
//=============================================================================

/*
 * Created by Antonino Abeshi
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    public GameObject showEscape;
   
    
    public void start()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            showEscape.SetActive(true);
            Debug.Log ("Escape");
            
        }
    }
}

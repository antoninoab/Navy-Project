//=============================================================================
//=============================================================================
//=============================================================================

/*
 * Created by Antonino Abeshi
 * Student UI
*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudentDisplay : MonoBehaviour

{
    // Start is called before the first frame update
    private int StudentDisplay2;
    public Text StudentDisplayText;
    void Start()
    {
        float r = 0.2f, g = 0.3f, b = 0.7f, a = 0.6f;
        StudentDisplayText.color = new Color(r, g, b, a);
    }

    // Update is called once per frame
    void Update()
    {

        // if we do not want the word here we can just do remove the Instrucor View and add instructorDisplay.ToString();
        StudentDisplayText.text = "Navy ROTC Student View: " + StudentDisplay2;


    }
}

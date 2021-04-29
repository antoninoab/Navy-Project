using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructorDIsplay : MonoBehaviour

{
    // Start is called before the first frame update
    private int instructorDisplay;
    public Text instructorDisplayText;
    void Start()
    {
        float r = 0.2f, g = 0.3f, b = 0.7f, a = 0.6f;
        instructorDisplayText.color = new Color(r, g, b, a);
    }

    // Update is called once per frame
    void Update()
    {

        // if we do not want the word here we can just do remove the Instrucor View and add instructorDisplay.ToString();
        instructorDisplayText.text = "Instructor View: " + instructorDisplay;

        
    }
}

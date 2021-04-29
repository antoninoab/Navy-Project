//=============================================================================
//=============================================================================
//=============================================================================

/*
 * Created by Antonino Abeshi
 * Adding the movement of the submarine, it will move along the axis.
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarinescript : MonoBehaviour
{

    [SerializeField] float shipSpeed2 = 15f;

    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * Time.deltaTime * shipSpeed2);
    }


}
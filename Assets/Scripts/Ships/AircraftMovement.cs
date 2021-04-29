//=============================================================================
//=============================================================================
//=============================================================================

/*
 * Created by Antonino Abeshi
 * The fly movement of the aircraft
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftMovement : MonoBehaviour
{

    [SerializeField] float shipSpeed = 15f;

    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * Time.deltaTime * shipSpeed);
    }


}

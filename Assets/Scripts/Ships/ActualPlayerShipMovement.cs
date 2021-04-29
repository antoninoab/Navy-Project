//=============================================================================
//=============================================================================
//=============================================================================

/*
 * Created by Antonino Abeshi
 * This script contains the movement of the main ship
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualPlayerShipMovement : MonoBehaviour
{

    [SerializeField] float shipSpeed2 = 15f;

    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * Time.deltaTime * shipSpeed2);
    }


}

//=============================================================================
//=============================================================================
//=============================================================================

/*
 * Created by Antonino Abeshi
 * Ship movement
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] float shipSpeed = 15f;
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.right * Time.deltaTime * shipSpeed);
    }
}

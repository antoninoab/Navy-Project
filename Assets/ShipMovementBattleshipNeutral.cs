using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementBattleshipNeutral : MonoBehaviour
{
    [SerializeField] float shipSpeed2 = 15f;

    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * Time.deltaTime * shipSpeed2);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarPivotPointRotation : MonoBehaviour
{
    [SerializeField] GameObject radarPivotPoint;

    [SerializeField] float rotationSpeed = 45f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(radarPivotPoint.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{

    [SerializeField] Transform fakeNorthTarget;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(fakeNorthTarget);
    }
}

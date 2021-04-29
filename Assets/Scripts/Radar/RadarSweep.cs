using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarSweep : MonoBehaviour
{
    [SerializeField] private Transform radarPingLocation;
    [SerializeField] float pingPointSize =70f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ship")
        {
            Vector3 hitPoint = other.gameObject.transform.position;
            Quaternion rotation = Quaternion.Euler(90f, 0f, 0f);
            RadarPing radarPing = Instantiate(radarPingLocation, hitPoint, rotation).GetComponent<RadarPing>();
            radarPing.transform.localScale = new Vector3(pingPointSize, pingPointSize, pingPointSize);
            radarPing.SetColor(new Color(0.4f, 1f, 0f));
        }
    }
}

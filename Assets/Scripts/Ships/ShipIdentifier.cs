using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipIdentifier : MonoBehaviour
{
    [SerializeField] WatercraftClass shipType;

    [System.Serializable]
    public class ShipType
    {
        public WatercraftClass watercraftClass;
    }

    public WatercraftClass getShipType()
    {
        return shipType;
    }
}
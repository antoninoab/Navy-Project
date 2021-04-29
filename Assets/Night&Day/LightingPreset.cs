﻿//=============================================================================
//=============================================================================
//=============================================================================

/*
 * Created by Antonino Abeshi
 * Fog
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Lighting Preset", menuName ="Scriptable/Lighting Preset",order= 1)]
public class LightingPreset : ScriptableObject
{
    public Gradient AmbientColor;
    public Gradient DirectionalColor;
    public Gradient FogColor;

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorComponent : VectorLerpComponent
{
    Renderer rend;
    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }
    protected override void ApplyLerp(Vector3 result)
    {
        rend.material.color = new Color(result.x, result.y, result.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleComponent : VectorLerpComponent
{
    protected override void ApplyLerp(Vector3 result)
    {
        this.transform.localScale = _startVector + result;
    }
}

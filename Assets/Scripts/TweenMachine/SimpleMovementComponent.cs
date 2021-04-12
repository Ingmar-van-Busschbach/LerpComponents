using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovementComponent : MasterVectorLerpComponent
{
    private EasingDictionary easingDictionary = new EasingDictionary();
    [SerializeField] private EasingDictionary.LerpType lerpType;

    protected override float CalculateEaseStep(float currentPercent)
    {
        return easingDictionary.CalculateEaseStep(currentPercent, lerpType);
    }
    protected override void ApplyLerp(Vector3 result)
    {
        this.transform.position = _startVector + result;
    }
}

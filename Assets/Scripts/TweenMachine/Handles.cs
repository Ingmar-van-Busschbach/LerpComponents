using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handles : MasterVectorLerpComponent
{
    [SerializeField] private GameObject[] _gameObjects;
    protected override void ApplyLerp(Vector3 result)
    {
        foreach(GameObject _gameObject in _gameObjects)
        {
            _gameObject.transform.position = _startVector + result;
        }
    }
}

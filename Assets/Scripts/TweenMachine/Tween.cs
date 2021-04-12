using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    private GameObject _gameObject;
    private Vector3 _startPosition;
    private Vector3 _targetPosition;
    private Vector3 _direction;

    private float _speed;
    private float _percent;

    public Tween(GameObject objectToMove, Vector3 targetPosition, float speed)
    {
        _gameObject = objectToMove;
        _targetPosition = targetPosition;
        _speed = speed;

        _startPosition = _gameObject.transform.position;
        _direction = _targetPosition - _startPosition;
        _percent = 0;

        Debug.Log("Tween Started");
    }

    public void UpdateTween(float dt)
    {
        if(_percent >= 1)
        {
            return;
        }
        Debug.Log(_gameObject + ": Tween Update");
        // hier berekenen we op basis van tijd (en duratie) wat de volgende waarde van percent is.
        // 0 is het start punt, 1 het eind van de curve
        // percent verloopt dus eigenlijk altijd lineair ;)
        _percent += dt;

        // Vervolgens berekenen we op welke plek we van de curve moet zijn op basis van percent
        float easeStep = _percent * _percent * _percent * _percent * _percent; // EaseInCubic

        // Hier kunnen we die waarde vervolgens toepassen op een parameter naar keuze
        _gameObject.transform.position = _startPosition + (_direction * easeStep);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMotion : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _amplitude = 0.5f;
    [SerializeField] private float _frequency = 1f;

    private Vector3 _startPos;

    void Start()
    {
        _startPos = transform.position;
    }
    void Update ()
    {
        float y = Mathf.Sin(Time.time * _frequency) * _amplitude;
        float x = transform.position.x + _speed * Time.deltaTime;

        transform.position = new Vector3(x, _startPos.y + y, transform.position.z);

        if (transform.position.x > 10f)
        {
            transform.position = new Vector3(-10f, transform.position.y,0);
        }
    }
}

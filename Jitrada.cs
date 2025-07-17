using UnityEngine;
using System.Collections;
using System;

public class Jitrada : MonoBehaviour
{
    public float _Bt;

    public bool _St;

    void Start()
    {
        _Bt = _Bt / 60;
    }

    void Update()
    {
        {
            transform.position -= new Vector3(_Bt * Time.deltaTime, 0f, 0f);
        }
    }
}


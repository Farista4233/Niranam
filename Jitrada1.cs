using UnityEngine;
using System.Collections;
using System;

public class Jitrada1 : MonoBehaviour
{
    private Vector3 startPosition;
    public float Speed = 2f;
    public float Distance = 2f;
    private bool move = true;
    public bool _St;

    void Start()
    {       
        startPosition = transform.position;
    }

    void Update()
    {
        
            Vector3 target = startPosition + (move ? Vector3.left : Vector3.right) * Distance;

            transform.position = Vector3.MoveTowards(transform.position, target, Speed * Time.deltaTime);
        
    }
}


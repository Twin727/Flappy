using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float _speed;


    void Update()
    {
        transform.Translate(-_speed * Time.deltaTime, 0, 0); 
    }
}

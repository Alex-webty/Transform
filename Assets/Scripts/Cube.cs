using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Spin();
    }

    private void Spin()
    {
        transform.RotateAround(transform.position, transform.up, _speed * Time.deltaTime);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    private void Update()
    {
        Increase();
    }

    private void Increase()
    {
        gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, new Vector3(x, y, z),
            _speed * Time.deltaTime);
    }
}

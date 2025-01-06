using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;

    [SerializeField] private float _speed;
    [SerializeField] private float _speedIncrease;
    [SerializeField] private float _speedSpin;
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    private int _currentWaypoint = 0;

    private void Update()
    {
        Spin();
        Move();
        Increase();
    }

    private void Increase()
    {
        gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, new Vector3(x, y, z),
            _speedIncrease * Time.deltaTime);
    }

    private void Move()
    {
        if (transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position,
            _speed * Time.deltaTime);
    }

    private void Spin()
    {
        transform.RotateAround(transform.position, transform.up, _speedSpin * Time.deltaTime);
    }
}

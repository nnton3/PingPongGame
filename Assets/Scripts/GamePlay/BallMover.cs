using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GamePlay
{
    public class BallMover : MonoBehaviour
    {
        [SerializeField] private float _speed = 10f;
        private Vector3 _startPosition;
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            GameEvents.ResetGame += MoveToStartPosition;
            _startPosition = transform.position;
        }

        private void Start()
        {
            MoveToStartPosition();
        }

        private void MoveToStartPosition()
        {
            transform.rotation = new Quaternion();
            _rb.velocity = Vector3.zero;
        
            transform.position = _startPosition;
            var direction = new Vector3(Random.Range(-.5f, .5f), 0f, Random.Range(0, 2) < 1 ? -1f : 1f);
            _rb.AddForce(direction.normalized * _speed, ForceMode.Impulse);
        }

        private void OnDestroy()
        {
            GameEvents.ResetGame -= MoveToStartPosition;
        }
    }
}

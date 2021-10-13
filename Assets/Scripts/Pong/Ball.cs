using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong
{
    public class Ball : MonoBehaviour
    {
        public float Speed = 500f;

        [SerializeField]
        private Vector2 _direction;

        [SerializeField]
        private CircleCollider2D _collider;
        
        [SerializeField]
        private Rigidbody2D _rigidbody;

        private void Start()
        {
            if (_rigidbody == false)
            {
                _rigidbody = GetComponent<Rigidbody2D>();
            }

            if (_collider == false)
            {
                _collider = GetComponent<CircleCollider2D>();
            }

            int x = Random.Range(-1, 1);

            while (x == 0)
            {
                x = Random.Range(-1, 1);
            }

            float y = Random.Range(-0.5f, 0.5f);

            _direction = new Vector2(x, y);
            _rigidbody.AddForce(_direction * Speed);
        }

        public void BallPosition()
        {
            _rigidbody.position = Vector2.zero;
            _rigidbody.velocity = Vector2.zero;
            int x = Random.Range(-1, 1);

            while (x == 0)
            {
                x = Random.Range(-1, 1);
            }

            float y = Random.Range(-0.5f, 0.5f);

            _direction = new Vector2(x, y);
            _rigidbody.AddForce(_direction * Speed);
        }
    }
}

    

using UnityEngine;

namespace Pong
{
    /* TODO
     * Player / Paddles
     * Ball
     * Scores
     */

    public class Paddle : MonoBehaviour
    {
        [HideInInspector]
        public float Speed = 8f;
        
        [SerializeField]
        [HideInInspector]
        private float VerticalDirection;
        
        [SerializeField]
        private Rigidbody2D _rigidbody;

        [SerializeField]
        private Vector2 _initialPosition;

        public BoxCollider2D _collider;

        public KeyCode UpKey;
        public KeyCode DownKey;

        private void Start()
        {
            if (_rigidbody == false)
            {
                _rigidbody = GetComponent<Rigidbody2D>();
            }

            if (_collider == false)
            {
                _collider = GetComponent<BoxCollider2D>();
            }

            _initialPosition = transform.position;
        }

        private void Update()
        {
            if(Input.GetKey(UpKey))
            {
                VerticalDirection = 1;
            }
            else if(Input.GetKey(DownKey))
            {
                VerticalDirection = -1;
            }
            else
            {
                VerticalDirection = 0;
            }
        }

        private void FixedUpdate()
        {
            _rigidbody.position += new Vector2(0, VerticalDirection) * (Speed * Time.fixedDeltaTime);
        }

        public void ResetPosition()
        {
            _rigidbody.position = _initialPosition;
        }
    }
}



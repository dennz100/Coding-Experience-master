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

        public BoxCollider2D _collider;

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
        }

        private void Update()
        {
            VerticalDirection = Input.GetAxis("Vertical");
        }

        private void FixedUpdate()
        {
            _rigidbody.position += new Vector2(0, VerticalDirection) * (Speed * Time.fixedDeltaTime);
        }
    }
}



using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 6f;

    public Vector2 MovemenetDirection;

    [SerializeField]
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        if (_rigidbody == false)
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        MovemenetDirection = new Vector2(horizontal, vertical);

        // Debug info for movement values.
        print($"{horizontal}, {vertical}");
    }

    private void FixedUpdate()
    {
        _rigidbody.position += MovemenetDirection * (Speed * Time.fixedDeltaTime);
    }
}

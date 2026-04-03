using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class playerbehavior : MonoBehaviour
{
    private Vector2 direction = Vector2.zero;

    private Rigidbody2D rb;

    public float speed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()

    {






        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction.x = -1;
        }
        else
        {
            direction.x = 0;
        }

        if (Input.GetKey(KeyCode.W))
        {
            direction.y = 1;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            direction.y = -1;
        }

        else
        {   
            direction.y = 0;
        }
    }
        Direction = Direction.normalized;
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (direction * speed * Time.fixedDeltaTime));
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, (Vector3)direction);
    }
}

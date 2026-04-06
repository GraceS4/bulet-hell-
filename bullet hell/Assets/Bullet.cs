using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 direction;
    public float speed = 8;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        GameObject player = GameObject.Find("player");
        direction = player.transform.position - transform.position;
        direction = direction.normalized;

        rb.AddForce(direction * speed, ForceMode2D.Impulse);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

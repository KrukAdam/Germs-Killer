using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health = 1;
    [SerializeField] private float moveSpeed = 0;
    [SerializeField] private Rigidbody2D rb = null;
    [SerializeField] private Vector3 target = new Vector3(0,0,0);

    private void Start()
    {
        Vector3 directions = target - transform.position;
        float angle = Mathf.Atan2(directions.y, directions.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    private void OnMouseDown()
    {
        Hit();
    }
    public void Hit()
    {
        health--;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

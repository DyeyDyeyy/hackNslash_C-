public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();   

    }

    void Update()   

    {

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
   
    }
}
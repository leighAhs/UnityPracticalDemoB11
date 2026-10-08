using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    Animator anim;
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if(player != null)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, player.transform.position - transform.position);
        }
        else
        {
            transform.Translate(Vector2.up *  Time.deltaTime * speed);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject, 0.2f);
            anim.Play("EnemyDestroyAnim");
        }
    }
}

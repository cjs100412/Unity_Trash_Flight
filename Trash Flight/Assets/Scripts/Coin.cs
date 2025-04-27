using UnityEngine;
using Random=UnityEngine.Random;

public class Coin : MonoBehaviour
{
    private float minY = -7f;
    void Start()
    {
        Jump();
    }

    void Jump() {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();

        float randomJumpForce = Random.Range(4f, 8f);
        Vector2 jumpVelocity = Vector2.up * randomJumpForce;
        jumpVelocity.x = Random.Range(-1.5f, 1.5f);

        rigidBody.AddForce(jumpVelocity, ForceMode2D.Impulse);
    }

    void Update()
    {
        if(transform.position.y < minY){
            Destroy(gameObject);
        }
    }
}

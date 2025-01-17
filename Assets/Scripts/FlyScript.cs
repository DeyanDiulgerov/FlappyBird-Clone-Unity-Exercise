using UnityEngine;
using UnityEngine.UI;

public class FlyScript : MonoBehaviour
{
    private Coin coin;
    private BirdSkinManager birdSkinAnimation;
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // Jump
            rb.linearVelocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Layers 6 == Coin Layer
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("Hit a coin");
        }
        else
            gameManager.GameOver();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public int scoreValue = 1;
    // possibly add second gold coin for more score

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // layer 8 == player
        if (collision.gameObject.layer == 8)
        {
            Destroy(gameObject); // Destroy the coin
            Score.score++;
            Debug.Log("Coin collided with player");
        }
    }
}

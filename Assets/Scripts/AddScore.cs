using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Layer 8 == Player
        if (collision.gameObject.layer == 8)
        {
            Score.score++;
        }
    }
}

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3[] positions = { new Vector3(-8.52f, 1, 0), new Vector3(0, 1, 0), new Vector3(8.52f, 1, 0) };
    private int currentPosition = 1; // Start in the middle

    public ScoreManager scoreManager; // Reference to ScoreManager

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentPosition > 0)
        {
            currentPosition--;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && currentPosition < 2)
        {
            currentPosition++;
        }

        transform.position = positions[currentPosition];
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            scoreManager.UpdateScore(10); // Add +10 for Coin
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            scoreManager.UpdateScore(-5); // Subtract -5 for Enemy
            Destroy(other.gameObject);
        }
    }
}
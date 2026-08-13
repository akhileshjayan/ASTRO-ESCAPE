using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    private LogicScript logic; // Stores the LogicScript reference
    private bool scored = false; // Prevents the same pipe from giving multiple points

    private void Start()
    {
        // Automatically finds the LogicScript in the scene
        logic = FindFirstObjectByType<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bird entered the middle trigger
        if (collision.CompareTag("Player") && !scored)
        {
            scored = true; // Marks this pipe as already scored

            logic.AddScore(1); // Adds 1 point using your LogicScript
        }
    }
}
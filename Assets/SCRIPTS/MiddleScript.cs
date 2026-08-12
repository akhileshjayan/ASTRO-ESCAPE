using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logic;

    private void Start()
    {
        logic = FindFirstObjectByType<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            logic.AddScore(1);
        }
    }
    
}

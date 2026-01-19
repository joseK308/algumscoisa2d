using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Moeda coletada!");
            GameManager.coins += value;
            Destroy(gameObject);
        }
    }
}   
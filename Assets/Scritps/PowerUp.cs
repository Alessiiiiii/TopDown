using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float boostAmount = 2f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().speed *= boostAmount;
            Destroy(gameObject);
        }
    }
}
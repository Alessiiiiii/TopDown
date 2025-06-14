using UnityEngine;

public class BaseEnemigo : MonoBehaviour
{
    public float velocidad = 2f;

    void Update()
    {
        Mover();
    }

    protected virtual void Mover()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
    }
}

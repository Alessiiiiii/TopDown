using UnityEngine;

public class Recolectable : MonoBehaviour
{
    public int puntos = 10;
    

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<Puntuacion>().SumarPuntos(puntos);
            Destroy(gameObject);
        }
    }
}
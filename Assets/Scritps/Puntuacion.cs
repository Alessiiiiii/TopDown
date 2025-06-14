using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public int puntosTotales = 0;
    public TMPro.TextMeshProUGUI scoreText;

    void Start()
    {
        ActualizarTexto();
    }

    public void SumarPuntos(int puntos)
    {
        puntosTotales += puntos;
        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        scoreText.text = "ScoreCoin:" + puntosTotales;
    }
}

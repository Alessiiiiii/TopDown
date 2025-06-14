public class EnemigoCaracol : BaseEnemigo
{
    protected override void Mover()
    {
        transform.Translate(Vector2.left * (velocidad / 2) * Time.deltaTime); // Se mueve más lento
    }
}


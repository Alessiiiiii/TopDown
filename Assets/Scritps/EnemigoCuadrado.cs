public class EnemigoCuadrado : BaseEnemigo
{
    protected override void Mover()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Sin(Time.time * velocidad) * 2);
    }
}

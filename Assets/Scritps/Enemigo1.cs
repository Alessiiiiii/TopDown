using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    private bool movingRight = true;
    public Transform groundDetection;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 1f);

        if (!groundInfo.collider)
        {
            movingRight = !movingRight;
            transform.eulerAngles = new Vector3(0, movingRight ? 0 : 180, 0);
        }
    }
}
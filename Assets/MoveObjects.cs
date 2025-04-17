using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        if (transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }
}
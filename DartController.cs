using UnityEngine;

public class DartController : MonoBehaviour
{
    public float speed = 5f; // Speed of horizontal movement

    void Update()
    {
        // Horizontal Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0, 0) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}

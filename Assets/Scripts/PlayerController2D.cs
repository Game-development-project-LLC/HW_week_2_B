using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    void Update()
    {
        // Old Input Manager axes: Horizontal (A/D or Left/Right), Vertical (W/S or Up/Down)
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 delta = new Vector3(x, y, 0f).normalized * speed * Time.deltaTime;
        transform.position += delta;
    }
}

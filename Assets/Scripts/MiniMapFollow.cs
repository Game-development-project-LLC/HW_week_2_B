using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset = new Vector3(0, 0, -10);
    [SerializeField] bool lockRotation = true;

    void LateUpdate()
    {
        if (!target) return;
        transform.position = target.position + offset;
        if (lockRotation) transform.rotation = Quaternion.identity;
    }
}

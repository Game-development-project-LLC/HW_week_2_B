using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraAutoSize : MonoBehaviour
{
    [SerializeField] float referenceOrthographicSize = 5f; // the size you tuned for
    [SerializeField] float referenceAspect = 16f / 9f;     // your design aspect (landscape)

    Camera cam;
    float lastAspect = -1f;

    void Awake() { cam = GetComponent<Camera>(); Apply(); }
    void Update() { Apply(); } // simple & robust for this assignment

    void Apply()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        if (Mathf.Approximately(currentAspect, lastAspect)) return;
        lastAspect = currentAspect;

        // Keep perceived scale similar across orientations by scaling vertical size
        cam.orthographicSize = referenceOrthographicSize * (referenceAspect / currentAspect);
    }
}

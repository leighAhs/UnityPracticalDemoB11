using Unity.Cinemachine;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField] CinemachineCamera camera;
    [SerializeField] GameObject CameraTracker;
    [SerializeField] GameObject canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 11.09)
        {
            camera.Follow = null;
            canvas.SetActive(false);
        } else if(transform.position.y < -11.09)
        {
            camera.Follow = null;
            canvas.SetActive(true);
        } else if(transform.position.x > 16.74)
        {
            camera.Follow = null;
            canvas.SetActive(false);
        } else if(transform.position.x < -16.74)
        {
            camera.Follow = null;
            canvas.SetActive(false);
        }
        else
        {
            camera.Follow = gameObject.transform;
            canvas.SetActive(true);
        }
    }
}

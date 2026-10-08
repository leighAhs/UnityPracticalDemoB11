using UnityEngine;

public class PlayerTurret : MonoBehaviour
{
    [SerializeField] Vector3 mousePosition;
    [SerializeField] GameObject bulletPosition;
    [SerializeField] GameObject bullet;
    [SerializeField] float shootDelay = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePosition - transform.position);


        shootDelay = shootDelay - Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && shootDelay < 0)
        {
            Instantiate(bullet, bulletPosition.transform.position, bulletPosition.transform.rotation);
            shootDelay = 1;
        }
    }
}

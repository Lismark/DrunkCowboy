using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletSpawnPoint;
    [SerializeField] private float fireRate;
    [SerializeField] private float bulletSpeed;
    [SerializeField] Animator animator;
    public Transform borderLeft;
    public Transform borderRight;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shooting", 0, fireRate);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckBorders();
        
    }

    private void Shooting()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, Quaternion.identity);
        animator.SetTrigger("Throw");
        bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * bulletSpeed, ForceMode.Impulse);
    }
    private void Move()
    {
        var mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(mousePos.x, transform.position.y, transform.position.z));
    }
    private void CheckBorders()
    {
        if (transform.position.x <= borderLeft.position.x)
            transform.position = new Vector3(borderLeft.position.x, transform.position.y, transform.position.z);

        if (transform.position.x >= borderRight.position.x)
            transform.position = new Vector3(borderRight.position.x, transform.position.y, transform.position.z);
    }
}           

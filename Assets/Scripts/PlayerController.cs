using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletSpawnPoint;
    [SerializeField] private float fireRate;
    [SerializeField] Animator animator;
    public float speed;
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
        var mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.x <= borderLeft.position.x)
        {
            transform.position = new Vector3(borderLeft.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= borderRight.position.x)
        {
            transform.position = new Vector3(borderRight.position.x, transform.position.y, transform.position.z);
        }
        transform.Translate(new Vector3(mousePos.x, transform.position.y, transform.position.z));
    }

    public void Shooting()
    {
        Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, Quaternion.identity);
        animator.SetTrigger("Throw");
    }
}           

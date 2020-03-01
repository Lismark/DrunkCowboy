using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletSpawnPoint;
    [SerializeField] private float fireRate;
    [SerializeField] Animator animator;
    [SerializeField] int rateModifier;

    public bool shooting = true;
    public Transform borderLeft;
    public Transform borderRight;
    private float _horizontalInput;
    private float nextFire;
    public int shootingType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckBorders();
        switch (shootingType)
        {
            case 0:
                SimpleShot();
                break;
            case 1:
                TripleShot();
                break;
            case 2:
                BigShot();
                break;
        }
    }

    

    private void SimpleShot()
    {
        if(shooting && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, Quaternion.identity);
        animator.SetTrigger("Throw");
        }
    }

    private void TripleShot()
    {
        if (shooting && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, Quaternion.identity);
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, Quaternion.Euler(0,10,0));
            Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, Quaternion.Euler(0, -10, 0));
            animator.SetTrigger("Throw");
        }
    }

    private void BigShot()
    {
        if (shooting && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, Quaternion.identity);
            bullet.transform.localScale = Vector3.one * rateModifier;
            animator.SetTrigger("Throw");
        }
    }
    private void Move()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = new Vector3(ray.origin.x, transform.position.y, transform.position.z);
        Debug.Log(ray.origin.x);
    }
    private void CheckBorders()
    {
        if (transform.position.x <= borderLeft.position.x)
            transform.position = new Vector3(borderLeft.position.x, transform.position.y, transform.position.z);

        if (transform.position.x >= borderRight.position.x)
            transform.position = new Vector3(borderRight.position.x, transform.position.y, transform.position.z);
    }
}    

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
    public enum ShootingTypes
    {
        single, tripple, bigShot
    }
    public ShootingTypes shootingTypes;

    public bool shooting = true;
    public Transform borderLeft;
    public Transform borderRight;
    private float _horizontalInput;
    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckBorders();
        switch (shootingTypes)
        {
            case ShootingTypes.single:
                SimpleShot();
                break;
            case ShootingTypes.tripple:
                TripleShot();
                break;
            case ShootingTypes.bigShot:
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
        Vector2 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = mousePos;
    }
    private void CheckBorders()
    {
        if (transform.position.x <= borderLeft.position.x)
            transform.position = new Vector3(borderLeft.position.x, transform.position.y, transform.position.z);

        if (transform.position.x >= borderRight.position.x)
            transform.position = new Vector3(borderRight.position.x, transform.position.y, transform.position.z);
    }
}           

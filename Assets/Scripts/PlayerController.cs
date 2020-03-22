using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject[] bulletPrefabs;
    [SerializeField] private GameObject bulletSpawnPoint;
    [SerializeField] Animator animator;
    [SerializeField] Player playerType;
    [SerializeField] GameObject healthBarSlider;
    [SerializeField] private int penaltyMultiplyer = 2;
    [SerializeField] Borders borders;

    public int currentBulletType = 0;
    public bool shooting = true;
    public int shootingType;
    private float _horizontalInput;
    private float nextFire;
    private float hpSliderValue;
    private float maxHealth;

    private void Start()
    {
        hpSliderValue = healthBarSlider.GetComponent<Slider>().value;
        maxHealth = playerType.maxHealth;
    }

    void FixedUpdate()
    {
        Move();
        CheckBorders();
  
    }
    private void Update()
    {
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
            nextFire = Time.time + playerType.fireRate;
        var bullet = Instantiate(bulletPrefabs[currentBulletType], bulletSpawnPoint.transform.position, Quaternion.identity);
        animator.SetTrigger("Throw");
        }
    }

    private void TripleShot()
    {
        if (shooting && Time.time > nextFire)
        {
            nextFire = Time.time + playerType.fireRate;
            Instantiate(bulletPrefabs[currentBulletType], bulletSpawnPoint.transform.position, Quaternion.identity);
            Instantiate(bulletPrefabs[currentBulletType], bulletSpawnPoint.transform.position, Quaternion.Euler(0,10,0));
            Instantiate(bulletPrefabs[currentBulletType], bulletSpawnPoint.transform.position, Quaternion.Euler(0, -10, 0));
            animator.SetTrigger("Throw");
        }
    }

    private void BigShot()
    {
        if (shooting && Time.time > nextFire)
        {
            nextFire = Time.time + playerType.fireRate;
            var bullet = Instantiate(bulletPrefabs[currentBulletType], bulletSpawnPoint.transform.position, Quaternion.identity);
            bullet.transform.localScale = new Vector3(4,4,4);
            animator.SetTrigger("Throw");
        }
    }
    private void Move()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = new Vector3(ray.origin.x, transform.position.y, transform.position.z);
    }
    private void CheckBorders()
    {
        if (transform.position.x <= borders.leftBorder)
            transform.position = new Vector3(borders.leftBorder, transform.position.y, transform.position.z);

        if (transform.position.x >= borders.rightBorder)
            transform.position = new Vector3(borders.rightBorder, transform.position.y, transform.position.z);
    }
}    

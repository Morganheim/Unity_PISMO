using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Gun : MonoBehaviour
{
    [Header("Ammo:")]
    public int maxAmmo;
    int currentAmmo;
    public Text ammoText;

    [Header("About Weapon:")]
    public float fireRate;
    float fireRateReset;
    public float accuracy;
    public float reloadTime;
    float reloadTimeReset;
    public float recoil;
    public Camera mainCamera;
    public Camera scopeCamera;

    [Header("Bullet Info:")]
    public Rigidbody bulletPrefab;
    public Transform bulletSpawnPosition;
    AudioSource bulletSoundSource;
    Bullet bulletScript;

    [Header("Fire Mode: *Single Fire is default*")]
    public bool singleFire = true; //0
    public bool automaticFire; //1
    public bool burstFire; //2
    int fireMode = 0;

    private void Start()
    {
        currentAmmo = maxAmmo;
        ShowAmmo();
        fireRateReset = fireRate;
        reloadTimeReset = reloadTime;
        bulletSoundSource = GetComponent<AudioSource>();
        bulletScript = bulletPrefab.gameObject.GetComponent<Bullet>();

        if (singleFire)
        {
            fireMode = 0;
        }
        else if (automaticFire)
        {
            fireMode = 1;
        }
        else if (burstFire)
        {
            fireMode = 2;
        }
        else
        {
            fireMode = 0;
        }

    }

    private void Update()
    {
        fireRate -= Time.deltaTime;
        reloadTime -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && fireMode == 0 && currentAmmo > 0 && fireRate <= 0)
        {
            Shoot();
            fireRate = fireRateReset;
        }

        if (Input.GetMouseButton(0) && fireMode == 1 && currentAmmo > 0 && fireRate <= 0)
        {
            Shoot();
            fireRate = fireRateReset;
        }

        if (Input.GetKeyDown(KeyCode.R) && reloadTime <= 0)
        {
            currentAmmo = maxAmmo;
            ShowAmmo();
            reloadTime = reloadTimeReset;
        }

        if (Input.GetMouseButton(1))
        {
            mainCamera.enabled = false;
            scopeCamera.enabled = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            mainCamera.enabled = true;
            scopeCamera.enabled = false;
        }
    }

    void Shoot()
    {
        float xScreen = Screen.width / 2;
        float yScreen = Screen.height / 2;

        float xAccuracy = Random.Range(xScreen - accuracy, xScreen + accuracy);
        float yAccuracy = Random.Range(yScreen - accuracy, yScreen + accuracy);

        var ray = Camera.main.ScreenPointToRay(new Vector3(xAccuracy, yAccuracy, 0));

        currentAmmo--;
        ShowAmmo();
        bulletSoundSource.Play();

        Rigidbody cloneBullet;
        cloneBullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);
        cloneBullet.velocity = bulletScript.speed * ray.direction;
    }

    public void ShowAmmo()
    {
        ammoText.text = currentAmmo + "/" + maxAmmo;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    public enum ShootStyle { MachineGun, Pistol, Ak47, ShotGun }
    public ShootStyle ShootRate;

    [Header("Weapon")]
    public int MaxMagazine;
    public int CurrentMagazine;
    public int MaxAmmo;
    public int CurrentAmmo;
    public float TimerShootRate;
    public float CDShootRate;
    public float TimerReload;
    public float CDReload;
    public GameObject InstancePoint;
    string GunName;
    // Start is called before the first frame update
    void Start()
    {
        GunName = ShootRate.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(InstancePoint.transform.position, InstancePoint.transform.forward * 10);
        Shoot();
        Reload();
    }

    void Reload()
    {

    }

    void Shoot()
    {
        switch(GunName)
        {
            case "MachineGun":
                if(Input.GetMouseButton(0))
                {
                    if (TimerReload <= 0 && TimerShootRate <= 0 && CurrentAmmo >= 0)
                    {
                        //Ray Projectileray = new Ray(InstancePoint.transform.position, InstancePoint.transform.forward);

                    }

                    //else
                    

                }
                return;
            case "Pistol":
                if (Input.GetMouseButtonDown(0))
                {
                    //    //if(TimerReload <= 0 && CurrentAmmo >= 0)
                    //    //{

                    //    //}
                Ray Projectileray = new Ray(InstancePoint.transform.position, InstancePoint.transform.forward);
                    if (Physics.Raycast(Projectileray, out RaycastHit hit, 10))
                    {
                        if (hit.rigidbody)
                        {
                            Debug.Log(hit.rigidbody.gameObject.name);
                            CurrentAmmo--;
                        }

                        else
                        {
                            Debug.Log("No ha impactado");
                        }
    
                    }
                }
                return;
            case "Ak47":
                if (Input.GetMouseButton(0))
                {
                    if (TimerReload <= 0 && TimerShootRate <= 0 && CurrentAmmo >= 0)
                    {

                    }

                    //else


                }
                return;
            case "ShotGun":
                if (Input.GetKeyDown(0))
                {
                    if (TimerReload <= 0 && CurrentAmmo >= 0)
                    {

                    }
                }
                return;

        }
    }
}

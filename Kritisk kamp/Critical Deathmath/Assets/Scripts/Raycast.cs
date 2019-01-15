using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {


    public int gunDamage;
    public float fireRate;
    public float weaponRange;
    public float hitForce;
    public float delay;
    public int Health = 100;
//---------------------------------------------
    public Transform gunEnd;
    public ParticleSystem muzzleFlash;
//-------------------------------------------
    public AudioClip gunShot;
    public AudioClip BulletShell;
 //------------------------------------------------------
    private Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);
    private float nextFire;
//--------------------------------------------------------------------

    void Start()
    {
         fpsCam = GetComponentInParent<Camera>();
         gameObject.AddComponent<AudioSource>();
         GetComponent<AudioSource>().clip = gunShot;
    }


    void Update()
    {
        if(Health <= 0)
        {
            Debug.Log("Dead");
        }
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            //---------------------- vis muzzleflash-------------------------------
            muzzleFlash.Play();
            //--------------- Skyd---------------------------------------------------
            nextFire = Time.time + fireRate;
            StartCoroutine(ShotEffect());
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.0f, 0.0f, 0.0f));
            RaycastHit hit;

            //---------------------banglyd når man skyder-------------------------------------

            AudioSource audio1 = GetComponent<AudioSource>();
            audio1.PlayOneShot(gunShot);
            Invoke("playShell", delay);


                //_________________________logik med Fjende liv og skade på Fjende____________________________________

                if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
                {

                    ShootableBox health = hit.collider.GetComponent<ShootableBox>();

                    if (health != null)
                    {
                    health.Damage(gunDamage);
                    }

                        if (hit.rigidbody != null)
                        {
                            
                            hit.rigidbody.AddForce(Camera.main.transform.forward * hitForce);
                            hit.collider.gameObject.GetComponent<ShootableBox>();
                        }
                }
            //_______________________________________________________________________________________________
        }
        else if (Input.GetButtonUp("Fire1"))
        {

            muzzleFlash.Stop();
            muzzleFlash.Clear();
        }
    }

    //-------------firerate delay--------------------
    private IEnumerator ShotEffect()
    {
      yield return shotDuration;
      yield return delay;

    }
    //----------------spiller shell lyd---dingdingding------------------

    void playShell()
    {
      AudioSource audio2 = GetComponent<AudioSource>();
      audio2.PlayOneShot(BulletShell);
    }
    //----------------------------------------------
    void OnTriggerStay(Collider other)
    {
        Debug.Log("HIT");
        Health = Health - Health;
    }
}

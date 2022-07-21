using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGlock : MonoBehaviour
{
    public GameObject glock;
    public GameObject muzzleFlash;
    public AudioSource gunShot;
    public bool isFiring = false;
    public int DamageAmount = 5;
    public float targetDistance;

    private void Awake()
    {
        //damageAmount = Random.Range(3, 7);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FiringGlock());
            }
        }
    }
    IEnumerator FiringGlock()
    {
        RaycastHit shot;
        isFiring = true;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            print(shot.transform.name);
            targetDistance = shot.distance;
            shot.transform.SendMessage("DamageEnemy",DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        glock.GetComponent<Animation>().Play("FullGlockShot");
        muzzleFlash.SetActive(true);
        gunShot.Play();
        yield return new WaitForSeconds(0.8f);
        muzzleFlash.SetActive(false);
        isFiring = false;
    }
}

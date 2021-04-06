using System.Collections;
using UnityEngine;

public class Gun_Logic: MonoBehaviour
{
    // Public damage, so the amount we will discount of lif of an object
    public float damage = 10f;
    // The range of shooting and reacting, so we won't count things milon miles away
    public float range = 100f;

    // The Camera where we shooting rays
    public Camera fpsCam;
    //The particle system to give a person a feeling that he made a shot
    public ParticleSystem muzzleFlash;

    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // each update we want to make a shot when the person is pressing space
        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Play small particle animation when we make a shot
        muzzleFlash.Play();

        // Raycast mechanism, it shots a line forward and understand if something wew hitten
        RaycastHit hit;
        //if something is hitten, do next: 
        //      *Check if it can deal damage
        //      *Deal Damage if it's possible
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
                target.TakeDamage(damage);

            GameObject impactGameObject = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGameObject, 0.2f);
        }
    }
}

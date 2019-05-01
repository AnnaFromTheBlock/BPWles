using UnityEngine;

public class Orb : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    private AudioSource mAudioSrc;

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        mAudioSrc = GetComponent<AudioSource>();
    }

    void Shoot ()
    {
        muzzleFlash.Play();
        mAudioSrc.Play();
   

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            GameObject impactGO =  Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
}

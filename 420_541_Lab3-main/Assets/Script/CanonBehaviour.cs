using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBehaviour : MonoBehaviour
{
    public float FirButtonPressedTime = 0.0f;
    public float maxTime = 3.0f;

    public GameObject bulletToSpawn;
    public GameObject bulletSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //As long as fire 1 is pressed add to the timer
        //if (Input.GetButtonDown("Fire1"))
        if (Input.GetMouseButton(0))
        {
            //Instantiate(bulletToSpawn, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            FirButtonPressedTime += Time.deltaTime;
        }

        //
        if (Input.GetButtonUp("Fire1"))
        {
            float ratio = FirButtonPressedTime / maxTime;
            ratio = Mathf.Clamp(ratio, 0.0f, 1.0f);
            GameObject bullet = Instantiate(bulletToSpawn, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);

            Destroy(bullet,5.0f);    
            BulletComponent BulletComponent = bullet.GetComponent<BulletComponent>();

            if (BulletComponent != null)
            {
                BulletComponent.strength *= ratio;
            }
            FirButtonPressedTime = 0.0f;
        }
        
    }
}

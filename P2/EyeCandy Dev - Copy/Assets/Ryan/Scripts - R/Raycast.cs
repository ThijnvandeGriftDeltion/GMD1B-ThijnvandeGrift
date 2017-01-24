using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Raycast : MonoBehaviour
{
    public AudioClip headshot;
    public GameObject register1;
    public GameObject register2;
    public GameObject register3;
    private RaycastHit hit;
    AudioSource audio;
    public Vector3 weaponSway;

    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            {
                
                if (hit.transform.gameObject == register1)
                {
                    audio.PlayOneShot(headshot);
                    
                }
                if (hit.transform.gameObject == register2)
                {
                    audio.PlayOneShot(headshot);

                }
                if (hit.transform.gameObject == register3)
                {
                    audio.PlayOneShot(headshot);

                }
            }

        }
    }
}
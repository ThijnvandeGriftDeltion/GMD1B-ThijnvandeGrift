using UnityEngine;
using System.Collections;

public class FireSpread : MonoBehaviour {
    public ParticleSystem water1;
    public ParticleSystem water2;
    public GameObject barrel1;
    public GameObject barrel2;
    public Vector3 draai1;
    public Vector3 draai2;
    public Vector3 draaiBack;
    

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            water1.Play();
            water2.Play();
        }
        else
        {
            water1.Stop();
            water2.Stop();
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            barrel1.transform.Rotate(draai1 * Time.deltaTime);
            barrel2.transform.Rotate(draai2 * Time.deltaTime);
            
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            barrel1.transform.Rotate(draai2 * Time.deltaTime);
            barrel2.transform.Rotate(draai1 * Time.deltaTime);

        }


    }
}

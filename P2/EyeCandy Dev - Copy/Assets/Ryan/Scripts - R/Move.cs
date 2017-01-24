using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public Vector3 fp;
    public Vector3 pf;
    public Vector3 walk;
    public Vector3 jump;
    public float rotatespeed;
    public float hor;
    public float ver;
    public float speed;
   
    void Update()
    {
        fp.y = rotatespeed * Input.GetAxis("Mouse X");
        GameObject.Find("Main Camera").transform.Rotate(pf);
        pf.x = rotatespeed * -Input.GetAxis("Mouse Y");
        transform.Rotate(fp);
        transform.Translate(walk);

        transform.Translate(walk * Time.deltaTime * speed);
        hor = speed * Input.GetAxis("Horizontal");
        ver = speed * Input.GetAxis("Vertical");

        walk.x = hor;
        walk.z = ver;

        if (Input.GetButtonDown("Jump"))
        {
         
        }

        


    }
   
}

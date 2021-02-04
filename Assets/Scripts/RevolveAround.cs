using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveAround : MonoBehaviour
{

    public Transform target;

    public float radius = 2;
    public float age = 0;
    public float speedRot = 0;

    void Update()
    {
        age += Time.deltaTime;
        float rot = Time.deltaTime * speedRot;

        Vector3 offset = new Vector3();
        offset.x = Mathf.Sin(age) * radius;
        offset.z = Mathf.Cos(age) * radius;

        transform.position = target.position + offset;
        transform.Rotate(new Vector3(rot, rot, rot));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRotation : MonoBehaviour
{
    public GameObject RotParent;

    public bool X;
    public bool Y;
    public bool Z;

    private float rX = 0;
    private float rY = 0;
    private float rZ = 0;

    // Update is called once per frame
    void Update()
    {
        if (X)
        {
            rX = RotParent.transform.eulerAngles.x;
        }

        if (Y)
        {
            rY = RotParent.transform.eulerAngles.y;
        }

        if (Z)
        {
            rZ = RotParent.transform.eulerAngles.z;
        }

        transform.rotation = Quaternion.identity;
        transform.Rotate(new Vector3(rX, rY, rZ));
    }
}

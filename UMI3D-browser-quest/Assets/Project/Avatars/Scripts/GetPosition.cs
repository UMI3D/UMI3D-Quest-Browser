using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPosition : MonoBehaviour
{
    public Transform posParent;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = posParent.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSkeleton : MonoBehaviour
{
    public Transform rightAvatarHand;
    public Transform leftAvatarHand;

    public GameObject rightController;
    public GameObject leftController;

    private Vector3 leftRestPos;
    private Vector3 rightRestPos;

    public float toVel = 12.5f;
    public float maxVel = 20f;
    public float maxForce = 1000f;
    public float gain = 2000f;

    public GameObject rightAvtarUpperArm;
    public GameObject leftAvatarUpperArm;

    // Start is called before the first frame update
    void Start()
    {
        leftRestPos = this.transform.InverseTransformPoint(leftAvatarHand.position);
        rightRestPos = this.transform.InverseTransformPoint(rightAvatarHand.position);
    }

    void UpdateAvatarHandPosition(Transform avatarHand, GameObject vrHand, OVRInput.Controller controller, Vector3 restPosition, Transform upperArm)
    {
        if (OVRInput.IsControllerConnected(controller))
        {
            Vector3 n = vrHand.transform.position - avatarHand.position;
            Vector3 tgtVel = Vector3.ClampMagnitude(toVel * n, maxVel);
            Vector3 error = tgtVel - avatarHand.GetComponent<Rigidbody>().velocity;
            Vector3 force = Vector3.ClampMagnitude(gain * error, maxForce);
            avatarHand.GetComponent<Rigidbody>().AddForce(force);

            if (n.magnitude < 0.1f)
            {
                avatarHand.position = vrHand.transform.position;
            }
        }
        else
        {
            Vector3 m = this.transform.TransformPoint(restPosition) - avatarHand.position;

            if (m.magnitude > 0.1f)
            {
                Vector3 tgtVel = Vector3.ClampMagnitude(toVel * m, maxVel);
                Vector3 error = tgtVel - avatarHand.GetComponent<Rigidbody>().velocity;
                Vector3 force = Vector3.ClampMagnitude(gain * error, maxForce);
                avatarHand.GetComponent<Rigidbody>().AddForce(force);
            }
            else
            {
                avatarHand.GetComponent<Rigidbody>().velocity = Vector3.zero;
                upperArm.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                avatarHand.transform.position = this.transform.TransformPoint(restPosition);
            }
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (rightController != null)
            UpdateAvatarHandPosition(rightAvatarHand, rightController, OVRInput.Controller.RTouch, rightRestPos, rightAvtarUpperArm.transform);
    
        if (leftController != null)
            UpdateAvatarHandPosition(leftAvatarHand, leftController, OVRInput.Controller.LTouch, leftRestPos, leftAvatarUpperArm.transform);

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using umi3dVRBrowsersBase.interactions;
using UnityEngine;

public class OculusInputManager : AbstractControllerInputManager
{
    public Dictionary<ControllerType, bool> isTeleportDown = new Dictionary<ControllerType, bool>();

    protected override void Awake()
    {
        base.Awake();

        foreach (ControllerType ctrl in Enum.GetValues(typeof(ControllerType)))
        {
            isTeleportDown.Add(ctrl, false);
        }
    }

    #region Grab

    public override bool GetGrab(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetGrabDown(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetGrabUp(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    #endregion

    #region Joystick

    public override Vector2 GetJoystickAxis(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.RTouch);
            default:
                return Vector2.zero;
        }
    }

    public override bool GetJoystickButton(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetJoystickButtonDown(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetDown(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetJoystickButtonUp(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetUp(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetUp(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    #endregion

    #region Primary

    public override bool GetPrimaryButton(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetPrimaryButtonDown(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetPrimaryButtonUp(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetUp(OVRInput.Button.One, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetUp(OVRInput.Button.One, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    #endregion

    #region Secondary

    public override bool GetSecondaryButton(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetSecondaryButtonDown(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetSecondaryButtonUp(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetUp(OVRInput.Button.Two, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetUp(OVRInput.Button.Two, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    #endregion

    #region Trigger


    public override bool GetTrigger(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetTriggerDown(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    public override bool GetTriggerUp(ControllerType controller)
    {
        switch (controller)
        {
            case ControllerType.LeftHandController:
                return OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
            case ControllerType.RightHandController:
                return OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
            default:
                return false;
        }
    }

    #endregion

    public override bool GetTeleportDown(ControllerType controller)
    {
        var res = GetJoystickDown(controller);

        if (res)
        {
            float pole = GetJoystickPole(controller);

            if (pole > 20 && pole < 160)
            {
                isTeleportDown[controller] = true;
                return true;
            } else
            {
                return false;
            }            
        }

        return res;
    }

    public override bool GetTeleportUp(ControllerType controller)
    {
        if (GetJoystickUp(controller) && isTeleportDown[controller])
        {
            isTeleportDown[controller] = false;

            return true;
        }

        return false;
    }

    public override bool GetRightSnapTurn(ControllerType controller)
    {
        var res = GetJoystickDown(controller);

        if (res)
        {
            float pole = GetJoystickPole(controller);

            if ((pole >= 0 && pole < 20) || (pole > 340 && pole <= 360))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        return res;
    }

    public override bool GetLeftSnapTurn(ControllerType controller)
    {
        var res = GetJoystickDown(controller);

        if (res)
        {
            float pole = GetJoystickPole(controller);

            if (pole > 160 && pole <= 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        return res;
    }

    public override void VibrateController(ControllerType controller, float vibrationDuration, float vibrationFrequency, float vibrationAmplitude)
    {
        OVRInput.Controller ctrl = OVRInput.Controller.LTouch;

        switch (controller)
        {
            case ControllerType.LeftHandController:
                ctrl = OVRInput.Controller.LTouch;
                break;
            case ControllerType.RightHandController:
                ctrl = OVRInput.Controller.RTouch;
                break;
            default:
                break;
        }

        OVRInput.SetControllerVibration(vibrationFrequency, vibrationAmplitude, ctrl);

        if (vibrationDuration < 2)
        {
            StartCoroutine(StopVibration(vibrationDuration, ctrl));
        }
    }

    IEnumerator StopVibration(float time, OVRInput.Controller controller)
    {
        yield return new WaitForSeconds(time);
        OVRInput.SetControllerVibration(0, 0, controller);
    }

    private float GetJoystickPole(ControllerType controller)
    {
        Vector2 axis = GetJoystickAxis(controller).normalized;
        float pole = 0.0f;

        if (axis.x != 0)
            pole = Mathf.Atan(axis.y / axis.x);
        else
            if (axis.y == 0)
            pole = 0;
        else if (axis.y > 0)
            pole = Mathf.PI / 2;
        else
            pole = -Mathf.PI / 2;

        pole *= Mathf.Rad2Deg;

        if (axis.x < 0)
            if (axis.y >= 0)
                pole = 180 - Mathf.Abs(pole);
            else
                pole = 180 + Mathf.Abs(pole);
        else if (axis.y < 0)
            pole = 360 + pole;

        return pole;
    }
}

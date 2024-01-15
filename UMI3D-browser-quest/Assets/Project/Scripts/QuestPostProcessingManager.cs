
using System.Linq;
using umi3d.common.graphics;
using UnityEngine;

public class QuestPostProcessingManager : umi3d.common.graphics.UMI3DPostProcessing
{
    protected override void Awake()
    {
        base.Awake();

        if (OVRManager.display.displayFrequenciesAvailable.Contains(90f))
        {
            OVRManager.display.displayFrequency = 90f;

            Debug.Log("90 FPS available so enbales it");
        } else
        {
            Debug.Log("90 FPS no available on this device");
        }
    }

    protected override void _ResetBloom()
    {
    }

    protected override void _ResetVignette()
    {

    }

    protected override void _SetBloom(UMI3DGlobalBloom bloom)
    {
    }


    protected override void _SetVignette(UMI3DGlobalVignette vignette)
    {

    }
}

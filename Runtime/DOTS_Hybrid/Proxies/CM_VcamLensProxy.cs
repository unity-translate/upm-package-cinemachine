using Cinemachine.ECS;

namespace Cinemachine.ECS_Hybrid
{
    [UnityEngine.DisallowMultipleComponent]
    [SaveDuringPlay]
    public class CM_VcamLensProxy : CM_ComponentProxyBase<CM_VcamLens>
    {
        private void Reset()
        {
            Value = CM_VcamLens.Default;
        }
    }
}

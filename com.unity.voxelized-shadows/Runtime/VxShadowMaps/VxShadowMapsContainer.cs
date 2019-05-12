using UnityEngine;

namespace UnityEngine.Experimental.VoxelizedShadows
{
    [ExecuteAlways]
    [AddComponentMenu("Rendering/VxShadowMaps/VxShadowMapsContainer", 100)]
    public class VxShadowMapsContainer : MonoBehaviour
    {
        public VxShadowMapsResources Resources = null;

        private void OnEnable()
        {
            VxShadowMapsManager.Instance.RegisterVxShadowMapsContainer(this);
            VxShadowMapsManager.Instance.LoadResources(Resources);
        }

        private void OnDisable()
        {
            VxShadowMapsManager.Instance.UnregisterVxShadowMapsContainer(this);
            VxShadowMapsManager.Instance.UnloadResources();
        }

        public void VerifyResources()
        {
            if (enabled && Resources != null)
                VxShadowMapsManager.Instance.LoadResources(Resources);
            else
                VxShadowMapsManager.Instance.UnloadResources();
        }
    }
}

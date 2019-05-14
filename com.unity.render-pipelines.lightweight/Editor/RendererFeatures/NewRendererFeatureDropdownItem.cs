using UnityEngine.Rendering.LWRP;

namespace UnityEditor.Rendering.LWRP
{
    public static class NewRendererFeatureDropdownItem
    {
        [MenuItem("Assets/Create/Rendering/Lightweight Render Pipeline/Render Pass")]
        public static void CreateNewRendererFeature()
        {
            string templatePath = "/Editor/RendererFeatures/NewRendererFeature.cs.txt";
            string combinedPath = LightweightRenderPipelineAsset.packagePath + templatePath;
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(combinedPath, "CustomRenderPassFeature.cs");
            AssetDatabase.Refresh();
        }
    }
}

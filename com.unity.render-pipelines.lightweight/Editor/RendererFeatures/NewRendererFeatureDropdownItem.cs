using UnityEngine.Rendering.LWRP;

namespace UnityEditor.Rendering.LWRP
{
    public static class NewRendererFeatureDropdownItem
    {
        static readonly string defaultNewClassName = "CustomRenderPassFeature.cs";
        static readonly string templatePath = "/Editor/RendererFeatures/NewRendererFeature.cs.txt";
        
        [MenuItem("Assets/Create/Rendering/Lightweight Render Pipeline/Renderer Feature", priority = EditorUtils.lwrpAssetCreateMenuPriorityGroup2)]
        public static void CreateNewRendererFeature()
        {
            string combinedPath = LightweightRenderPipelineAsset.packagePath + templatePath;
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(combinedPath, defaultNewClassName);
            AssetDatabase.Refresh();
        }
    }
}

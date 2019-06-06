using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNodeEditor;

namespace QAI
{
    public class BlackBoardUtilities
    {
        /// <summary>Creates a new C# Class.</summary>
        [MenuItem("Assets/Create/BlackBoard/Modifier C# Script", false, 89)]
        private static void CreateNode()
        {
            string[] guids = AssetDatabase.FindAssets("BlackBoard_ModifierTemplate.cs");
            if (guids.Length == 0)
            {
                Debug.LogWarning("BlackBoard_ModifierTemplate.cs.txt not found in asset database");
                return;
            }
            string path = AssetDatabase.GUIDToAssetPath(guids[0]);
            NodeEditorUtilities.CreateFromTemplate(
                "NewModifier.cs",
                path
            );
        }

    }
}

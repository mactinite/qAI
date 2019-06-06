using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNodeEditor;

namespace QAI.FSM
{
    public class BTUtilities
    {
        /// <summary>Creates a new C# Class.</summary>
        [MenuItem("Assets/Create/BT/Task C# Script", false, 89)]
        private static void CreateNode()
        {
            string[] guids = AssetDatabase.FindAssets("BT_TaskNode.cs");
            if (guids.Length == 0)
            {
                Debug.LogWarning("BT_TaskNode.cs.txt not found in asset database");
                return;
            }
            string path = AssetDatabase.GUIDToAssetPath(guids[0]);
            NodeEditorUtilities.CreateFromTemplate(
                "NewTaskNode.cs",
                path
            );
        }

        /// <summary>Creates a new C# Class.</summary>
        [MenuItem("Assets/Create/BT/Check C# Script", false, 89)]
        private static void CreateGraph()
        {
            string[] guids = AssetDatabase.FindAssets("BT_CheckNode.cs");
            if (guids.Length == 0)
            {
                Debug.LogWarning("BT_CheckNode.cs.txt not found in asset database");
                return;
            }
            string path = AssetDatabase.GUIDToAssetPath(guids[0]);
            NodeEditorUtilities.CreateFromTemplate(
                "NewBTCheckNode.cs",
                path
            );
        }

    }
}

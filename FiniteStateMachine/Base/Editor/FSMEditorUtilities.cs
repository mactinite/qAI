using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNodeEditor;

namespace QAI.FSM
{
    public class FSMEditorUtilities
    {
        /// <summary>Creates a new C# Class.</summary>
        [MenuItem("Assets/Create/FSM/State C# Script", false, 89)]
        private static void CreateNode()
        {
            string[] guids = AssetDatabase.FindAssets("FSM_FSMStateTemplate.cs");
            if (guids.Length == 0)
            {
                Debug.LogWarning("FSM_FSMStateTemplate.cs.txt not found in asset database");
                return;
            }
            string path = AssetDatabase.GUIDToAssetPath(guids[0]);
            NodeEditorUtilities.CreateFromTemplate(
                "NewStateNode.cs",
                path
            );
        }

        /// <summary>Creates a new C# Class.</summary>
        [MenuItem("Assets/Create/FSM/Check C# Script", false, 89)]
        private static void CreateGraph()
        {
            string[] guids = AssetDatabase.FindAssets("FSM_FSMCheckTemplate.cs");
            if (guids.Length == 0)
            {
                Debug.LogWarning("FSM_FSMCheckTemplate.cs.txt not found in asset database");
                return;
            }
            string path = AssetDatabase.GUIDToAssetPath(guids[0]);
            NodeEditorUtilities.CreateFromTemplate(
                "NewCheckNode.cs",
                path
            );
        }

    }
}

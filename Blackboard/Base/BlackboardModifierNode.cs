using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using XNode;

namespace QAI {

  /// <summary>A generic class for node's of different types in the blackboard.</summary>
  [NodeTint("#dbdbdb")]
  [CreateNodeMenu("")]
  public abstract class BlackboardModifierNode<T> : BlackboardBaseNode {

    /// <summary>Outgoing port with the value</summary>
    [Output] public T _result;

    /// <summary>Return the current value of an output port when requested.</summary>
    public override object GetValue(NodePort port) {
      // Only respond to value requests.
      if (port.fieldName != "_result") { return null; }
      // Get value.
      T value = (graph as AIGraph).GetValue<T>(name);
      // Return the value.
      return value;
    }

    /// <summary>Return the value of the blackboard variable.</summary>
    public override object GetValue() {
      NodePort port = GetOutputPort("_result");
      return GetValue(port);
    }
  }
}
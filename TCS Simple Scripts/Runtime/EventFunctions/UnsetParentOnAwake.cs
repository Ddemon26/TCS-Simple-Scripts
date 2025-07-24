using UnityEngine;
namespace TCS.SimpleScripts.EventFunctions {
    [AddComponentMenu("TCS/SimpleScripts/Event Functions/Unset Parent On Awake")]
    [DefaultExecutionOrder(-1000)]
    public class UnsetParentOnAwake : MonoBehaviour {
        void Awake() => transform.SetParent(null);
    }
}
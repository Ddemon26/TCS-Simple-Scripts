using UnityEngine;
namespace TCS.SimpleScripts.EventFunctions {
    [AddComponentMenu("TCS/SimpleScripts/Event Functions/Enable Or Disable Collider On Awake")]
    public class EnableOrDisableColliderOnAwake : MonoBehaviour {
        [SerializeField]
        Collider m_collider;
        [SerializeField]
        bool m_enableStateOnAwake;
        void Awake() => m_collider.enabled = m_enableStateOnAwake;
    }
}
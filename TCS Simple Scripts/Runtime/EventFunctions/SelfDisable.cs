using UnityEngine;
namespace TCS.SimpleScripts.EventFunctions {
    /// <summary>
    /// Will Disable this game object once active after the delay duration has passed.
    /// </summary>
    [AddComponentMenu("TCS/SimpleScripts/Event Functions/Self Disable")]
    public class SelfDisable : MonoBehaviour {
        [SerializeField] float m_disabledDelay;
        float m_disableTimestamp;

        void Update() {
            if (Time.time >= m_disableTimestamp) {
                gameObject.SetActive(false);
            }
        }

        void OnEnable() => m_disableTimestamp = Time.time + m_disabledDelay;
    }
}
using UnityEngine;
namespace TCS.SimpleScripts.EventFunctions {
    /// <summary>
    /// This class destroys the GameObject it is attached to after a specified delay when the script instance is loaded.
    /// </summary>
    [AddComponentMenu("TCS/SimpleScripts/Event Functions/Destroy On Awake")]
    public class DestroyOnAwake : MonoBehaviour {
        /// <summary>
        /// The delay in seconds before the GameObject is destroyed.
        /// </summary>
        [SerializeField] float m_delay = 0.1f;

        /// <summary>
        /// Called when the script instance is being loaded.
        /// Destroys the GameObject this script is attached to after the specified delay.
        /// </summary>
        void Awake() => Destroy(gameObject, m_delay);
    }
}
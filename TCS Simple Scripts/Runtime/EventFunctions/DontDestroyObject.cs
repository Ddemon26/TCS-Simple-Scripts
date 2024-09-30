using UnityEngine;
namespace TCS.SimpleScripts.EventFunctions {
    [AddComponentMenu("TCS/SimpleScripts/Event Functions/Dont Destroy Object")]
    public class DontDestroyObject : MonoBehaviour {
        public bool m_autoUnparentOnAwake = true;
        static DontDestroyObject sInstance;

        void Awake() {
            if (!sInstance) {
                sInstance = this;
                Initialize();
            } else {
                Destroy(gameObject);
            }
        }

        void Initialize() {
            if (!Application.isPlaying) return;

            if (m_autoUnparentOnAwake) {
                transform.SetParent(null);
            }

            DontDestroyOnLoad(gameObject);
        }
    }
}
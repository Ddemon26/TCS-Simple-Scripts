using UnityEngine;
namespace TCS.SimpleScripts {
    public class DontDestroyObject : MonoBehaviour {
        public bool m_autoUnparentOnAwake = true;
        static DontDestroyObject s_instance;

        void Awake() {
            if (!s_instance) {
                s_instance = this;
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
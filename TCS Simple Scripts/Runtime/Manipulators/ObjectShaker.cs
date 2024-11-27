using UnityEngine;

namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Object Shaker")]
    public class ObjectShaker : MonoBehaviour {
        [SerializeField] float m_shakeDuration = 1f;
        [SerializeField] float m_shakeMagnitude = 0.5f;
        [SerializeField] AnimationCurve m_shakeCurve = AnimationCurve.EaseInOut(0f, 1f, 1f, 0f);
        [SerializeField] bool m_loopShaking;
        [SerializeField] bool m_autoStart; // Automatically start shaking on enable

        Vector3 m_originalPosition;
        float m_elapsedTime;
        bool m_isShaking;

        void Awake() => m_originalPosition = transform.localPosition;

        void OnEnable() {
            if (m_autoStart) {
                StartShake();
            }
        }

        void OnDisable() {
            m_isShaking = false;
            transform.localPosition = m_originalPosition;
        }

        void Update() {
            if (!m_isShaking) return;
            
            if (m_elapsedTime < m_shakeDuration) {
                m_elapsedTime += Time.deltaTime;
                float strength = m_shakeCurve.Evaluate(m_elapsedTime / m_shakeDuration) * m_shakeMagnitude;
                transform.localPosition = m_originalPosition + (Vector3)Random.insideUnitCircle * strength;
            }
            else if (m_loopShaking) {
                m_elapsedTime = 0f;
            }
            else {
                StopShake();
            }
        }

        public void StartShake() {
            m_isShaking = true;
            m_elapsedTime = 0f;
        }

        public void StopShake() {
            m_isShaking = false;
            transform.localPosition = m_originalPosition;
        }
    }
}
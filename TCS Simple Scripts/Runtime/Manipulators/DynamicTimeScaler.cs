using UnityEngine;
namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Dynamic Time Scaler")]
    public class DynamicTimeScaler : MonoBehaviour {
        [SerializeField, Range(0f, 3f)] float m_targetTimeScale = 1f;
        [SerializeField] float m_transitionDuration = 0.5f;
        [SerializeField] AnimationCurve m_transitionCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

        float m_initialTimeScale;
        float m_elapsedTime;
        bool m_isScaling;

        void Update() {
            if (!m_isScaling) return;

            m_elapsedTime += Time.unscaledDeltaTime;
            float t = Mathf.Clamp01(m_elapsedTime / m_transitionDuration);
            Time.timeScale = Mathf.Lerp(m_initialTimeScale, m_targetTimeScale, m_transitionCurve.Evaluate(t));

            if (!(t >= 1f)) return;

            m_isScaling = false;
            Time.timeScale = m_targetTimeScale;
        }

        /// <summary>
        /// Triggers the time scale change with a smooth transition.
        /// </summary>
        public void ScaleTime(float newTimeScale, float duration) {
            m_initialTimeScale = Time.timeScale;
            m_targetTimeScale = newTimeScale;
            m_transitionDuration = duration;
            m_elapsedTime = 0f;
            m_isScaling = true;
        }

        /// <summary>
        /// Instantly sets the time scale without any transition.
        /// </summary>
        public void SetTimeScaleImmediate(float newTimeScale) {
            Time.timeScale = newTimeScale;
            m_isScaling = false;
        }
    }
}
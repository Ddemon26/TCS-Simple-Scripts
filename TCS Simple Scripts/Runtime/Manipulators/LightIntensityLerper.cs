using UnityEngine;

namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Light Intensity Lerper")]
    [RequireComponent(typeof(Light))]
    public class LightIntensityLerper : MonoBehaviour {
        [Tooltip("The minimum light intensity.")]
        [SerializeField] private float m_minIntensity = 0f;

        [Tooltip("The maximum light intensity.")]
        [SerializeField] private float m_maxIntensity = 1f;

        [Tooltip("Duration for one complete lerp cycle.")]
        [SerializeField] private float m_duration = 2f;

        [Tooltip("Animation curve for the lerp.")]
        [SerializeField] private AnimationCurve m_curve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

        [Tooltip("Loop the intensity lerp.")]
        [SerializeField] private bool m_loop = true;

        private Light m_light;
        private float m_elapsedTime;
        private bool m_lerpingToMax;

        private void Awake() {
            m_light = GetComponent<Light>();
            m_light.intensity = m_minIntensity;
        }

        private void OnEnable() {
            m_elapsedTime = 0f;
            m_lerpingToMax = true;
        }

        private void Update() {
            if (!m_loop && m_elapsedTime >= m_duration) return;

            m_elapsedTime += Time.deltaTime;
            if (m_elapsedTime >= m_duration) {
                m_elapsedTime = 0f;
                m_lerpingToMax = !m_lerpingToMax;
            }

            float t = Mathf.Clamp01(m_elapsedTime / m_duration);
            float evaluatedT = m_curve.Evaluate(t);
            m_light.intensity = Mathf.Lerp
            (
                m_lerpingToMax ? m_minIntensity : m_maxIntensity,
                m_lerpingToMax ? m_maxIntensity : m_minIntensity,
                evaluatedT
            );
        }
    }
}
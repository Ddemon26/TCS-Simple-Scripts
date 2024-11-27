using UnityEngine;
namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/Simple Object Cycler")]
    public class SimpleObjectCycler : MonoBehaviour {
        [Tooltip("Objects to cycle through. Only one will be active at a time.")]
        [SerializeField] private GameObject[] m_objects;

        [Tooltip("The key to cycle to the next object.")]
        [SerializeField] private KeyCode m_cycleKey = KeyCode.C;

        private int m_currentIndex = 0;

        private void Awake() {
            if (m_objects == null || m_objects.Length == 0) return;

            // Ensure only the first object is active at start
            for (int i = 0; i < m_objects.Length; i++)
                m_objects[i].SetActive(i == 0);
        }

        private void Update() {
            if (Input.GetKeyDown(m_cycleKey))
                CycleObjects();
        }

        private void CycleObjects() {
            if (m_objects == null || m_objects.Length == 0) return;

            // Deactivate the current object
            m_objects[m_currentIndex].SetActive(false);

            // Move to the next object
            m_currentIndex = (m_currentIndex + 1) % m_objects.Length;

            // Activate the new current object
            m_objects[m_currentIndex].SetActive(true);
        }
    }
}
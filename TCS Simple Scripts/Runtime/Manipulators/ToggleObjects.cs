using UnityEngine;
namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/ToggleObjects")]
    public class ToggleObjects : MonoBehaviour {
        public GameObject[] m_objectsToToggle;
        public bool m_activeAll;
        public bool m_toggleAllOnStart;

        void Start() {
            if (m_toggleAllOnStart) {
                SetActiveAll(true);
            }
        }

        void OnValidate() {
            SetActiveAll(m_activeAll);
        }

        void SetActiveAll(bool active) {
            foreach (var obj in m_objectsToToggle) {
                obj.SetActive(active);
            }
        }

        public void Toggle(int index) => SetActive(index, !m_objectsToToggle[index].activeSelf);
        void SetActive(int active, bool b) => m_objectsToToggle[active].SetActive(b);
    }
}
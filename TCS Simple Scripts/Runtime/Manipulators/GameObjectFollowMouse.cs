using UnityEngine;

namespace TCS.SimpleScripts.Manipulators {
    [AddComponentMenu("TCS/SimpleScripts/Manipulators/GameObjectFollowMouse")]
    public class GameObjectFollowMouse : MonoBehaviour {
        Camera m_camera;
        RectTransform m_rectTransform;

        void Awake() {
            m_camera = Camera.main;
            m_rectTransform = GetComponent<RectTransform>();
        }

        void Update() {
            var mousePosition = Input.mousePosition;
            if (m_rectTransform) {
                // Handle RectTransform (UI element)
                RectTransformUtility.ScreenPointToLocalPointInRectangle
                (
                    m_rectTransform.parent as RectTransform, 
                    mousePosition, 
                    m_camera, 
                    out var localPoint
                );
                m_rectTransform.localPosition = localPoint;
            }
            else {
                // Handle regular GameObject
                mousePosition.z = m_camera.WorldToScreenPoint(transform.position).z;
                transform.position = m_camera.ScreenToWorldPoint(mousePosition);
            }
        }
    }
}
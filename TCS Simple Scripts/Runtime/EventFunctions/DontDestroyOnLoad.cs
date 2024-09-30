using UnityEngine;
namespace TCS.SimpleScripts.EventFunctions {
    [AddComponentMenu("TCS/SimpleScripts/Event Functions/Dont Destroy On Load")]
    public class DontDestroyOnLoad : MonoBehaviour {
        void Awake() => DontDestroyOnLoad(gameObject);
    }
}
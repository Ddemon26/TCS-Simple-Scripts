using UnityEngine;
namespace TCS.SimpleScripts {
    public static class GameApplication {
        public static void QuitGameCompletely() {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }

        public static void LockCursor() {
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
            UnityEngine.Cursor.visible = false;
        }

        public static void UnlockCursor() {
            UnityEngine.Cursor.lockState = CursorLockMode.None;
            UnityEngine.Cursor.visible = true;
        }

        public static void ToggleCursorLock(bool lockCursor) {
            if (lockCursor) {
                LockCursor();
            }
            else {
                UnlockCursor();
            }
        }

        public static void RestartCurrentScene() {
            UnityEngine.SceneManagement.SceneManager.LoadScene
            (
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
            );
        }

        public static void LoadSceneByIndex(int sceneIndex) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
        }

        public static void PauseGame() => Time.timeScale = 0f;
        public static void ResumeGame() => Time.timeScale = 1f;
    }
}
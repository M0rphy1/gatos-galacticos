using System.Collections;
using UnityEngine;

/*
    Script para ir a la escena del Menú después de que se cargue el administrador de carga.
*/
public class GoToMenu : MonoBehaviour
{
    IEnumerator Start()
    {
        // Espera a que comience el gestor de escena de carga
        yield return new WaitUntil(() => LoadingSceneManager.Instance != null);

        // Cargar el menú
        LoadingSceneManager.Instance.LoadScene(SceneName.Menu, false);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{

        public void Endgame()
        {
            Application.Quit();
            // To stop playing in unity editor
            // UnityEditor.EditorApplication.isPlaying = false; 
            
        }
}

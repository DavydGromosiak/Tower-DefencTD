using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class NextLevel : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      LevelConttrollerD.instance.isEndGame();
   }
}

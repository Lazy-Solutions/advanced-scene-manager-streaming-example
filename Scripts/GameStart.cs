using AdvancedSceneManager;
using AdvancedSceneManager.Callbacks;
using AdvancedSceneManager.Models;
using AdvancedSceneManager.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStart : MonoBehaviour, ISceneOpen
{
    public UnityEvent _onGameStart;

    public IEnumerator OnOpen()
    {
        _onGameStart.Invoke();
        yield break;
    }
}

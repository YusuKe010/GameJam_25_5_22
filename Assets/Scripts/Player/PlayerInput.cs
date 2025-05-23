using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action<Vector2> Input;
    public event Action OnInputJump;
    public event Action OnInputRightMouseClick;
    public event Action OnInputS;

    private void Update()
    {
        Vector2 input = new Vector2(UnityEngine.Input.GetAxis("Horizontal"), 0);
        Input?.Invoke(input);

        if (UnityEngine.Input.GetKeyDown(KeyCode.Space) || UnityEngine.Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(aa());
        }
        if (UnityEngine.Input.GetMouseButtonDown(1))
        {
            OnInputRightMouseClick?.Invoke();
        }
        if (UnityEngine.Input.GetKey(KeyCode.S))
        {
            StartCoroutine(bb());
        }
    }

    private IEnumerator aa()
    {
        yield return new WaitForFixedUpdate();
        OnInputJump?.Invoke();
    }

    private IEnumerator bb()
    {
        yield return new WaitForFixedUpdate();
        OnInputS?.Invoke();
    }
}

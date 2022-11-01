using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using static CatInputActions;

[CreateAssetMenu(fileName = "New Input Handler", menuName = "Cat Game/Create New Input Handler",order = 0)]
public class InputHandler : ScriptableObject, IPetCatActions
{
    #region variables
    public event Action OnClickAction;

    private CatInputActions _inputActions;
    public Vector2 TouchPosition { get; private set; }
    #endregion

    private void OnEnable()
    {
        _inputActions = new CatInputActions();
        _inputActions.PetCat.SetCallbacks(this);
        _inputActions.PetCat.Enable();
    }

    private void OnDisable()
    {
        _inputActions.Disable();
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            OnClickAction?.Invoke();
        }
    }

    public void OnClickPosition(InputAction.CallbackContext context)
    {
        TouchPosition = context.ReadValue<Vector2>();
    }
}

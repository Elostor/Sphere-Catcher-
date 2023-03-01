using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchController : MonoBehaviour
{
    // Buttons
    public ButtonBasicController leftButton;
    public ButtonBasicController middleButton;
    public ButtonBasicController rightButton;

    // Game board objects, catching spheres.
    public BoxCollider leftCatcher;
    public BoxCollider middleCatcher;
    public BoxCollider rightCatcher;

    // Indicators, showing if the connected button is pressed or not by and to player.
    public GameObject leftIndicator;
    public GameObject middleIndicator;
    public GameObject rightIndicator;

    // Internal booleans, tracing board activity.
    protected bool _leftActive = false;
    protected bool _middleActive = false;
    protected bool _rightActive = false;

    // Internal premium boolean, checking if a player has bought the game update. Because monetization is fun!
    protected bool _secondHandUpdate = false;

    public void FixedUpdate ()
    {
        if (_secondHandUpdate)
            BoardPremiumAction();
        else
            BoardAction();
    }

    public void BoardPremiumAction ()
    {
        if (leftButton._buttonDown & !middleButton._buttonDown & !rightButton._buttonDown)
        {
            leftIndicator.SetActive(true);
            _leftActive = true;
            middleIndicator.SetActive(false);
            _middleActive = false;
            rightIndicator.SetActive(false);
            _rightActive = false;
        }
        else if (leftButton._buttonDown & middleButton._buttonDown)
        {
            leftIndicator.SetActive(true);
            _leftActive = true;
            middleIndicator.SetActive(true);
            _middleActive = true;
            rightIndicator.SetActive(false);
            _rightActive = false;
            if (rightButton._buttonDown)
               return;
        }
        else if (leftButton._buttonDown & rightButton._buttonDown)
        {
            leftIndicator.SetActive(true);
            _leftActive = true;
            middleIndicator.SetActive(false);
            _middleActive = false;
            rightIndicator.SetActive(true);
            _rightActive = true;
            if (middleButton._buttonDown)
               return;
        }
        else if (!leftButton._buttonDown & middleButton._buttonDown & !rightButton._buttonDown)
        {
            leftIndicator.SetActive(false);
            _leftActive = false;
            middleIndicator.SetActive(true);
            _middleActive = true;
            rightIndicator.SetActive(false);
            _rightActive = false;  
        }
        else if (!leftButton._buttonDown & !middleButton._buttonDown & rightButton._buttonDown)
        {
            leftIndicator.SetActive(false);
            _leftActive = false;
            middleIndicator.SetActive(false);
            _middleActive = false;
            rightIndicator.SetActive(true);
            _rightActive = true;  
        }
        else if (middleButton._buttonDown & rightButton._buttonDown)
        {
            leftIndicator.SetActive(false);
            _leftActive = false;
            middleIndicator.SetActive(true);
            _middleActive = true;
            rightIndicator.SetActive(true);
            _rightActive = true;
            if (leftButton._buttonDown)
               return;
        }
        else if (!leftButton._buttonDown & !middleButton._buttonDown & !rightButton._buttonDown)
        {
            leftIndicator.SetActive(false);
            _leftActive = false;
            middleIndicator.SetActive(false);
            _middleActive = false;
            rightIndicator.SetActive(false);
            _rightActive = false;
        }
    }

    public void BoardAction()
    {
        if (leftButton._buttonDown & !middleButton._buttonDown & !rightButton._buttonDown)
        {
            leftIndicator.SetActive(true);
            _leftActive = true;
            middleIndicator.SetActive(false);
            _middleActive = false;
            rightIndicator.SetActive(false);
            _rightActive = false;
        }
        else if (!leftButton._buttonDown & middleButton._buttonDown & !rightButton._buttonDown)
        {
            leftIndicator.SetActive(false);
            _leftActive = false;
            middleIndicator.SetActive(true);
            _middleActive = true;
            rightIndicator.SetActive(false);
            _rightActive = false;  
        }
        else if (!leftButton._buttonDown & !middleButton._buttonDown & rightButton._buttonDown)
        {
            leftIndicator.SetActive(false);
            _leftActive = false;
            middleIndicator.SetActive(false);
            _middleActive = false;
            rightIndicator.SetActive(true);
            _rightActive = true;  
        }
        else
        {
            leftIndicator.SetActive(false);
            _leftActive = false;
            middleIndicator.SetActive(false);
            _middleActive = false;
            rightIndicator.SetActive(false);
            _rightActive = false;
        }
    }
}

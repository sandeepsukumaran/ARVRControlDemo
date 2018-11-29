using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonControlScript : MonoBehaviour, IVirtualButtonEventHandler {

	#region PRIVATE_MEMBERS
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    #endregion // PRIVATE_MEMBERS

    #region MONOBEHAVIOUR_METHODS
    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; ++i)
        {
            virtualButtonBehaviours[i].RegisterEventHandler(this);
        }
    }

    #endregion // MONOBEHAVIOUR_METHODS
	
	#region PUBLIC_METHODS
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch(vb.VirtualButtonName){
        	case "increaseButton":	SatelliteRotation.RotationSpeed = SatelliteRotation.MaxRotationSpeed;
        							break;
        	case "decreaseButton":	SatelliteRotation.RotationSpeed = SatelliteRotation.MinRotationSpeed;
        							break;
        }
    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        SatelliteRotation.RotationSpeed = SatelliteRotation.NormalRotationSpeed;
    }
    #endregion //PUBLIC_METHODS
}

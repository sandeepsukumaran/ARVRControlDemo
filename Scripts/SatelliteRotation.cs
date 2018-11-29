using UnityEngine;

public class SatelliteRotation: MonoBehaviour{
	public static float RotationSpeed { get; set; }
	public static float MaxRotationSpeed { get; private set; }
	public static float MinRotationSpeed { get; private set; }
	public static float NormalRotationSpeed {get; private set; }

	public SatelliteRotation(){
	    // cannot use initialisation with declaration since Unity does not use C# 6.0
		RotationSpeed = 25.0f;
		MaxRotationSpeed = 250.0f;
		MinRotationSpeed = 1.0f;
		NormalRotationSpeed = 25.0f;
	}
	
	void Update(){
		transform.Rotate(0, RotationSpeed*Time.deltaTime, 0);
	}

}

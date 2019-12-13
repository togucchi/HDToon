using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ToonShaderLightSettings : MonoBehaviour
{

	private Light mainLight;

	void OnEnable()
	{
		mainLight = GetComponent<Light>();
	}
	
	void Update ()
	{
		Shader.SetGlobalVector("_ToonLightDirection", -transform.forward);
		Shader.SetGlobalColor("_ToonLightColor", mainLight.color);
        Shader.SetGlobalFloat("_ToonLightIntensity", mainLight.intensity);
	}
}
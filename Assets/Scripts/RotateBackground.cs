using UnityEngine;

public class RotateBackground : MonoBehaviour
{
    public float rotateSpeed = 1.1f;
    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float positionX = 0.0f;
    private float positionY = 0.0f;
    private float positionZ = 0.0f;

    private float scaleMultiplier = 1.3f;
    private float scaleMin = 1.0f;
    private float scaleMax = 3.0f;
    private float scaleChangeSpeed = 0.005f;

    private float colorIntensityR = 0.5f;
    private float colorIntensityG = 1.0f;
    private float colorIntensityB = 0.3f;
    private float colorIntensityA = 0.4f;

    private float rotationSpeed = 10.0f;

    private bool shrink = false;
    private bool moveLeft = true;
    private bool increaseR = true;

    void Start()
    {
        transform.position = new Vector3(positionX, positionY, positionZ);
        transform.localScale = Vector3.one * scaleMultiplier;

        Material material = Renderer.material;
        material.color = new Color(colorIntensityR, colorIntensityG, colorIntensityB, colorIntensityA);
    }
    
    void Update()
    {
        // Rotate the cube
        transform.Rotate(rotationSpeed * Time.deltaTime, 0.0f, 0.0f);

        // Continuously resize the cube
        if (shrink)
        {
            scaleMultiplier -= scaleChangeSpeed;

            if (scaleMultiplier < scaleMin)
            {
                shrink = false;
            }
        }
        else
        {
            scaleMultiplier += scaleChangeSpeed;

            if (scaleMultiplier > scaleMax)
            {
                shrink = true;
            }
        }

        transform.localScale = Vector3.one * scaleMultiplier;

        // Continuously move the cube
        if (moveLeft)
        {
            positionZ -= 0.05f;

            if (positionZ < -7.0f)
            {
                moveLeft = false;
            }
        }
        else
        {
            positionZ += 0.05f;

            if (positionZ > 7.0f)
            {
                moveLeft = true;
            }
        }

        transform.position = new Vector3(positionX, positionY, positionZ);

        // Continuously change the color of the cube
        if (increaseR)
        {
            colorIntensityR += 0.005f;

            if (colorIntensityR >= 1.0f)
            {
                increaseR = false;
            }
        }
        else
        {
            colorIntensityR -= 0.005f;

            if (colorIntensityR <= 0.3f)
            {
                increaseR = true;
            }
        }

        Material material = Renderer.material;
        material.color = new Color(colorIntensityR, colorIntensityG, colorIntensityB, colorIntensityA);
    }
}

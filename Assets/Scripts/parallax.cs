using UnityEngine;

public class parallax : MonoBehaviour
{
    public float animationSpeed = 1f;
    private MeshRenderer meshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>(); 
    }
    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed *Time.deltaTime, 0);
    }
}

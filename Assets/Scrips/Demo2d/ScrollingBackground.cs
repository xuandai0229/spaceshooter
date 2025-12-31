using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Renderer bgRenderer;
    public float scrollSpeed;

    void Update()
    {
        bgRenderer.material.mainTextureOffset = new Vector2(0, Time.time * scrollSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeColorBehaviour : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    [SerializeField]
    private Text _colorText;

    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        Vector4 color = new Vector4(Random.value, Random.value, Random.value, 1);
        _meshRenderer.material.color = color;
        _colorText.text = "Color: " + color;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDragPanel : MonoBehaviour
{
    [Tooltip("Ссылка на префаб")]
    [SerializeField] private GameObject dragColorPrefab;

    [Tooltip("Ссылка на Content ScrollView")]
    [SerializeField] private Transform scrollViewContent;

    [Tooltip("Материалы для перекраски")]
    [SerializeField] private List<Material> materials;

    private void Start()
    {
        for (int i = 0; i < materials.Count; ++i)
        {
            var dragObject = Instantiate(dragColorPrefab, scrollViewContent);
            var script = dragObject.GetComponent<ColorDragElement>();

            script.DragParentTransform = transform;
            script.MainMaterial = materials[i];
            script.DefaultParentTransform = scrollViewContent;
            script.SiblingIndex = i;
        }
    }
}

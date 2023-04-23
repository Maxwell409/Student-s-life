using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDragPanel : MonoBehaviour
{
    [Tooltip("������ �� ������")]
    [SerializeField] private GameObject dragColorPrefab;

    [Tooltip("������ �� Content ScrollView")]
    [SerializeField] private Transform scrollViewContent;

    [Tooltip("��������� ��� ����������")]
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDragPanel : MonoBehaviour
{
    [Tooltip("������ �� ������ �������")]
    [SerializeField] private GameObject dragObjectPrefab;

    [Tooltip("������ �� Content ScrollView")]
    [SerializeField] private Transform scrollViewContent;

    [Tooltip("��������� ��� ����������")]
    [SerializeField] private List<GameObject> objects;

    [Tooltip("Image ��������")]
    [SerializeField] private List<Sprite> sprites;

    private void Start()
    {
        for (int i = 0; i < objects.Count; ++i)
        {
            var dragObject = Instantiate(dragObjectPrefab, scrollViewContent);
            var script = dragObject.GetComponent<ObjectDragElement>();

            script.DragParentTransform = transform;
            script.SpriteEditor(sprites[i]);
            script.ObjectToSpawn = objects[i];
            script.DefaultParentTransform = scrollViewContent;
            script.SiblingIndex = i;
        }
    }

    private void OnMouseExit()
    {
        
    }
}

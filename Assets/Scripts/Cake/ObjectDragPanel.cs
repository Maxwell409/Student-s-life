using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDragPanel : MonoBehaviour
{
    [Tooltip("Ссылка на префаб объекта")]
    [SerializeField] private GameObject dragObjectPrefab;

    [Tooltip("Ссылка на Content ScrollView")]
    [SerializeField] private Transform scrollViewContent;

    [Tooltip("Объекты для спавна")]
    [SerializeField] private List<GameObject> objects;

    [Tooltip("Image объектов")]
    [SerializeField] private List<Sprite> sprites;

    private void Start()
    {
        for (int i = 0; i < sprites.Count; ++i)
        {
            var dragObject = Instantiate(dragObjectPrefab, scrollViewContent);
            var script = dragObject.GetComponent<ObjectDragElement>();

            script.DragParentTransform = transform;
            script.Sprite = sprites[i];
            script.DefaultParentTransform = scrollViewContent;
            script.SiblingIndex = i;

            if(objects.Count <= sprites.Count)
            {
                script.ObjectToSpawn = objects[i];
            }
        }
    }

    private void OnMouseExit()
    {
        
    }
}

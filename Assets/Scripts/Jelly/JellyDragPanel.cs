using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyDragPanel : MonoBehaviour
{
    [Tooltip("Ссылка на префаб объекта")]
    [SerializeField] private GameObject dragObjectPrefab;

    [Tooltip("Ссылка на Content ScrollView")]
    [SerializeField] private Transform scrollViewContent;

    [Tooltip("Image объектов")]
    [SerializeField] private List<Sprite> sprites;

    private void Start()
    {
        for (int i = 0; i < sprites.Count; ++i)
        {
            var dragObject = Instantiate(dragObjectPrefab, scrollViewContent);
            var script = dragObject.GetComponent<JellyDragElement>();

            script.DragParentTransform = transform;
            script.Sprite = sprites[i];
            script.DefaultParentTransform = scrollViewContent;
            script.SiblingIndex = i;
            script.TagToEnable = sprites[i].name;
        }
    }
}

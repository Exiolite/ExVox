// From: https://gist.github.com/lawrence-laz/39903f3a5c7ace1652db19a2a6c01d29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Attributes;
using UnityEngine;

public class ObjectBase : MonoBehaviour
{
    private void Awake()
    {
        InjectGetComponent();
    }

    private void OnEnable()
    {
        InjectGetComponent();
    }

    private void InjectGetComponent()
    {
        IEnumerable<FieldInfo> fields = GetFieldsWithAttribute(typeof(GetComponentAttribute));
        foreach (FieldInfo field in fields)
        {
            Type type = field.FieldType;
            Component component = GetComponent(type);
            if (component == null)
            {
                Debug.LogWarning("GetComponent typeof(" + type.Name + ") in game object '" + gameObject.name + "' is null");
                continue;
            }

            field.SetValue(this, component);
        }
    }

    private IEnumerable<FieldInfo> GetFieldsWithAttribute(Type attributeType)
    {
        IEnumerable<FieldInfo> fields = GetType()
            .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(field => field.GetCustomAttributes(attributeType, true).FirstOrDefault() != null);

        return fields;
    }
}

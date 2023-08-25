using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryEventData
{
    public List<ProductProperties> ProductProperties;

    public FactoryEventData(List<ProductProperties> productProperties)
    {
        ProductProperties = productProperties;
    }
}
﻿using UnityEngine;
using Exiled.API.Enums;

namespace Better079.Utils
{
    public static class MapUtils
    {
        // Map utils methods (May be I will add more methods in future)
        public static ZoneType GetObjectZone(Transform objectTransform)
        {
            switch (objectTransform.position.y)
            {
                case 1.3f:
                    return ZoneType.LightContainment;
                case -998.7f:
                    if (objectTransform.position.x < 60f)
                        return ZoneType.HeavyContainment;
                    else
                        return ZoneType.Entrance;
                case 998.9f:
                    return ZoneType.Surface;
                default:
                    return ZoneType.Unspecified;
            }
        }

        public static bool HaveSameZone(Transform firstObject, Transform secondObject)
        {
            return GetObjectZone(firstObject) == GetObjectZone(secondObject);
        }
    }
}
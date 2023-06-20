// http://www.sonity.org/ Created by Victor Engstr�m
// Copyright 2023 Sonigon AB - All Rights Reserved

#if UNITY_EDITOR

namespace Sonity.Internal {

    public enum SoundTriggerType {

        OnEnable,
        OnDisable,
        OnStart,
        OnDestroy,

        OnTriggerEnter,
        OnTriggerExit,
        OnTriggerEnter2D,
        OnTriggerExit2D,

        OnCollisionEnter,
        OnCollisionExit,
        OnCollisionEnter2D,
        OnCollisionExit2D,

        OnMouseEnter,
        OnMouseExit,
        OnMouseDown,
        OnMouseUp,
    }
}
#endif
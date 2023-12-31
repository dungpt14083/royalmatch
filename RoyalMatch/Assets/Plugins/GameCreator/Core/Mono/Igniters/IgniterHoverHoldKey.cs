﻿namespace GameCreator.Core
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
    using GameCreator.Variables;

	[AddComponentMenu("")]
	public class IgniterHoverHoldKey : Igniter 
	{
		#if UNITY_EDITOR
		public new static string NAME = "Input/On Hover Hold Key";
		public new static bool REQUIRES_COLLIDER = true;
        #endif

        public enum ReleaseType
        {
            OnKeyUp,
            OnTimeout
        }
        
        public enum TimeMode
        {
	        Game,
	        Unscaled
        }

		public KeyCode keyCode = KeyCode.E;
        public float holdTime = 0.5f;
        public TimeMode timeMode = TimeMode.Game;
        public ReleaseType execute = ReleaseType.OnKeyUp;

        private bool isPressing = false;
		private bool isMouseOver = false;
        private float downTime = -9999.0f;

		private void Update()
		{
			float time = this.timeMode == TimeMode.Game ? Time.time : Time.unscaledTime;
			if (this.isMouseOver)
            {
                if (this.isPressing && time > this.downTime + this.holdTime)
                {
                    switch (this.execute)
                    {
                        case ReleaseType.OnKeyUp:
                            if (Input.GetKeyUp(this.keyCode))
                            {
                                this.isPressing = false;
                                this.ExecuteTrigger(gameObject);
                            }
                            break;

                        case ReleaseType.OnTimeout:
                            if (Input.GetKey(this.keyCode))
                            {
                                this.isPressing = false;
                                this.ExecuteTrigger(gameObject);
                            }
                            break;
                    }
                }

                if (Input.GetKeyDown(this.keyCode))
                {
                    this.isPressing = true;
                    this.downTime = time;
                }

                if (Input.GetKeyUp(this.keyCode))
                {
                    this.isPressing = false;
                }
            }
		}

		private void OnMouseExit()
		{
			this.isMouseOver = false;
            this.isPressing = false;
		}

		private void OnMouseEnter()
		{
			this.isMouseOver = true;
		}
	}
}
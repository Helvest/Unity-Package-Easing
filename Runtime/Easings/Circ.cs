using UnityEngine;

namespace SimpleTweening
{
	internal class Circ : Easing
	{
		public override float EaseIn(float t)
		{
			return 1f - Mathf.Sqrt(1f - t * t);
		}

		public override float EaseOut(float t)
		{
			return Mathf.Sqrt(1f - (--t * t));
		}
	}
}

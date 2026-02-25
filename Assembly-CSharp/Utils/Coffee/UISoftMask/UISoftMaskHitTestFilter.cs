using System;
using Coffee.UISoftMask;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.Coffee.UISoftMask
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public class UISoftMaskHitTestFilter : MonoBehaviour, ICanvasRaycastFilter
	{
		// Token: 0x0600034C RID: 844 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x57AB", Offset = "0x57AB", VA = "0x57AB")]
		public MaskingShapeContainer GetShapeContainer()
		{
			return null;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x57AC", Offset = "0x57AC", VA = "0x57AC", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x57AD", Offset = "0x57AD", VA = "0x57AD")]
		public UISoftMaskHitTestFilter()
		{
		}

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SoftMask _mask;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _threshold;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x18")]
		private MaskingShapeContainer _shapeContainer;
	}
}

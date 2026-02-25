using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.AnimatedElements
{
	// Token: 0x0200024E RID: 590
	[Token(Token = "0x200024E")]
	public class AnimateRotation : MonoBehaviour
	{
		// Token: 0x06000E5E RID: 3678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x60E5", Offset = "0x60E5", VA = "0x60E5")]
		public void Rotate(bool value)
		{
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x60E6", Offset = "0x60E6", VA = "0x60E6")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x60E7", Offset = "0x60E7", VA = "0x60E7")]
		public AnimateRotation()
		{
		}

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _rotationDuration;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Vector3 _enabledRotation;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _disabledRotation;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x2C")]
		private Tween _rotationTween;
	}
}

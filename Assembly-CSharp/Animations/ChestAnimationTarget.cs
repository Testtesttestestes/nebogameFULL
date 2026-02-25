using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Animations
{
	// Token: 0x0200132C RID: 4908
	[Token(Token = "0x200132C")]
	public class ChestAnimationTarget : MonoBehaviour, IAnimationTarget
	{
		// Token: 0x0600744E RID: 29774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600744E")]
		[Address(RVA = "0xBE1A", Offset = "0xBE1A", VA = "0xBE1A")]
		private void OnEnable()
		{
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600744F")]
		[Address(RVA = "0xBE1B", Offset = "0xBE1B", VA = "0xBE1B")]
		private void OnDisable()
		{
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x00014EF8 File Offset: 0x000130F8
		[Token(Token = "0x6007450")]
		[Address(RVA = "0xBE1C", Offset = "0xBE1C", VA = "0xBE1C", Slot = "4")]
		public float StartAnimation(Transform movable)
		{
			return 0f;
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007451")]
		[Address(RVA = "0xBE1D", Offset = "0xBE1D", VA = "0xBE1D")]
		private void OnAnimationEnd()
		{
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007452")]
		[Address(RVA = "0xBE1E", Offset = "0xBE1E", VA = "0xBE1E")]
		private void ModifyPosition(float t)
		{
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007453")]
		[Address(RVA = "0xBE1F", Offset = "0xBE1F", VA = "0xBE1F")]
		private IEnumerator DelayedDestroy(GameObject go)
		{
			return null;
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007454")]
		[Address(RVA = "0xBE20", Offset = "0xBE20", VA = "0xBE20")]
		public ChestAnimationTarget()
		{
		}

		// Token: 0x04003CE3 RID: 15587
		[Token(Token = "0x4003CE3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _image;

		// Token: 0x04003CE4 RID: 15588
		[Token(Token = "0x4003CE4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04003CE5 RID: 15589
		[Token(Token = "0x4003CE5")]
		[FieldOffset(Offset = "0x18")]
		private float _t;

		// Token: 0x04003CE6 RID: 15590
		[Token(Token = "0x4003CE6")]
		[FieldOffset(Offset = "0x1C")]
		private float _curve;

		// Token: 0x04003CE7 RID: 15591
		[Token(Token = "0x4003CE7")]
		[FieldOffset(Offset = "0x20")]
		private float _duration;

		// Token: 0x04003CE8 RID: 15592
		[Token(Token = "0x4003CE8")]
		[FieldOffset(Offset = "0x24")]
		private Ease _ease;

		// Token: 0x04003CE9 RID: 15593
		[Token(Token = "0x4003CE9")]
		[FieldOffset(Offset = "0x28")]
		private Transform _movable;

		// Token: 0x04003CEA RID: 15594
		[Token(Token = "0x4003CEA")]
		[FieldOffset(Offset = "0x2C")]
		private ChestAnimationTarget.BezierCurve _bezierCurve;

		// Token: 0x04003CEB RID: 15595
		[Token(Token = "0x4003CEB")]
		[FieldOffset(Offset = "0x50")]
		private ParticleSystem _ps;

		// Token: 0x0200132D RID: 4909
		[Token(Token = "0x200132D")]
		private readonly struct BezierCurve
		{
			// Token: 0x06007457 RID: 29783 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007457")]
			[Address(RVA = "0xBE23", Offset = "0xBE23", VA = "0xBE23")]
			public BezierCurve(Vector3 a, Vector3 b, Vector3 c)
			{
			}

			// Token: 0x06007458 RID: 29784 RVA: 0x00014F28 File Offset: 0x00013128
			[Token(Token = "0x6007458")]
			[Address(RVA = "0xBE24", Offset = "0xBE24", VA = "0xBE24")]
			public Vector3 GetPosition(float t)
			{
				return default(Vector3);
			}

			// Token: 0x04003CEC RID: 15596
			[Token(Token = "0x4003CEC")]
			[FieldOffset(Offset = "0x0")]
			public readonly Vector3 A;

			// Token: 0x04003CED RID: 15597
			[Token(Token = "0x4003CED")]
			[FieldOffset(Offset = "0xC")]
			public readonly Vector3 B;

			// Token: 0x04003CEE RID: 15598
			[Token(Token = "0x4003CEE")]
			[FieldOffset(Offset = "0x18")]
			public readonly Vector3 C;
		}
	}
}

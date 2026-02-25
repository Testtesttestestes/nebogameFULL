using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Tweens
{
	// Token: 0x02000932 RID: 2354
	[Token(Token = "0x2000932")]
	public class PulsatingTweener : MonoBehaviour
	{
		// Token: 0x0600378A RID: 14218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378A")]
		[Address(RVA = "0x8775", Offset = "0x8775", VA = "0x8775")]
		private void OnEnable()
		{
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378B")]
		[Address(RVA = "0x8776", Offset = "0x8776", VA = "0x8776")]
		private void OnDisable()
		{
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600378C")]
		[Address(RVA = "0x8777", Offset = "0x8777", VA = "0x8777")]
		public PulsatingTweener()
		{
		}

		// Token: 0x04001EA8 RID: 7848
		[Token(Token = "0x4001EA8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 _to;

		// Token: 0x04001EA9 RID: 7849
		[Token(Token = "0x4001EA9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _period;

		// Token: 0x04001EAA RID: 7850
		[Token(Token = "0x4001EAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Ease _ease;

		// Token: 0x04001EAB RID: 7851
		[Token(Token = "0x4001EAB")]
		[FieldOffset(Offset = "0x24")]
		private Tween _scaleTween;
	}
}

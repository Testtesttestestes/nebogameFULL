using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	public class PodiumTweens : MonoBehaviour
	{
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700046B")]
		public Transform LeftPodium
		{
			[Token(Token = "0x6001931")]
			[Address(RVA = "0x6AD0", Offset = "0x6AD0", VA = "0x6AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700046C")]
		public Transform RightPodium
		{
			[Token(Token = "0x6001932")]
			[Address(RVA = "0x6AD1", Offset = "0x6AD1", VA = "0x6AD1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x6AD2", Offset = "0x6AD2", VA = "0x6AD2")]
		public void PlayFirst()
		{
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x6AD3", Offset = "0x6AD3", VA = "0x6AD3")]
		public void PlaySecond()
		{
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x6AD4", Offset = "0x6AD4", VA = "0x6AD4")]
		public void PlayThird()
		{
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x6AD5", Offset = "0x6AD5", VA = "0x6AD5")]
		public PodiumTweens()
		{
		}

		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _leftTransform;

		// Token: 0x04000D55 RID: 3413
		[Token(Token = "0x4000D55")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _rightTransform;

		// Token: 0x04000D56 RID: 3414
		[Token(Token = "0x4000D56")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpriteRenderer _leftSprite;

		// Token: 0x04000D57 RID: 3415
		[Token(Token = "0x4000D57")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SpriteRenderer _rightSprite;
	}
}

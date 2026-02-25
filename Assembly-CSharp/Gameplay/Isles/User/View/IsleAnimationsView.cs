using System;
using System.Collections.Generic;
using AssetContent;
using CloudsFly;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D15 RID: 3349
	[Token(Token = "0x2000D15")]
	public class IsleAnimationsView : BaseWorldObjectRenderer
	{
		// Token: 0x060051C0 RID: 20928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C0")]
		[Address(RVA = "0x9F9A", Offset = "0x9F9A", VA = "0x9F9A")]
		public void ShowAnimation(string assetId)
		{
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C1")]
		[Address(RVA = "0x9F9B", Offset = "0x9F9B", VA = "0x9F9B")]
		private void GameAnimationViewOnAnimationCompleteEvent(GameAnimationView target)
		{
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C2")]
		[Address(RVA = "0x9F9C", Offset = "0x9F9C", VA = "0x9F9C", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C3")]
		[Address(RVA = "0x9F9D", Offset = "0x9F9D", VA = "0x9F9D", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C4")]
		[Address(RVA = "0x9F9E", Offset = "0x9F9E", VA = "0x9F9E")]
		public IsleAnimationsView()
		{
		}

		// Token: 0x04002C75 RID: 11381
		[Token(Token = "0x4002C75")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _assetViewPrefab;

		// Token: 0x04002C76 RID: 11382
		[Token(Token = "0x4002C76")]
		[FieldOffset(Offset = "0x28")]
		private List<GameAssetViewSpriteRenderer> _animations;
	}
}

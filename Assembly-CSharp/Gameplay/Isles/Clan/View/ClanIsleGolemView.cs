using System;
using AssetContent;
using Gameplay.Isles.Clan.Controller;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.Clan.View
{
	// Token: 0x02000CF1 RID: 3313
	[Token(Token = "0x2000CF1")]
	public class ClanIsleGolemView : BaseIsleMonsterView, IToolTipDataProvider
	{
		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x0600509C RID: 20636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700104C")]
		public GameAssetViewSpriteRenderer Bubble
		{
			[Token(Token = "0x600509C")]
			[Address(RVA = "0x9EAB", Offset = "0x9EAB", VA = "0x9EAB")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509D")]
		[Address(RVA = "0x9EAC", Offset = "0x9EAC", VA = "0x9EAC")]
		public void Init(ClanIsle isle)
		{
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509E")]
		[Address(RVA = "0x9EAD", Offset = "0x9EAD", VA = "0x9EAD")]
		public void Deinit()
		{
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600509F")]
		[Address(RVA = "0x9EAE", Offset = "0x9EAE", VA = "0x9EAE", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A0")]
		[Address(RVA = "0x9EAF", Offset = "0x9EAF", VA = "0x9EAF", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050A1")]
		[Address(RVA = "0x9EB0", Offset = "0x9EB0", VA = "0x9EB0", Slot = "12")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A2")]
		[Address(RVA = "0x9EB1", Offset = "0x9EB1", VA = "0x9EB1")]
		public ClanIsleGolemView()
		{
		}

		// Token: 0x04002C0C RID: 11276
		[Token(Token = "0x4002C0C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _bubble;

		// Token: 0x04002C0D RID: 11277
		[Token(Token = "0x4002C0D")]
		[FieldOffset(Offset = "0x30")]
		private ClanIsleGolemViewMediator _mediator;
	}
}

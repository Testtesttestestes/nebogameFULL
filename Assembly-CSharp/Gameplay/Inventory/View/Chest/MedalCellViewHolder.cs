using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Core.Data;
using Gameplay.Medals.View;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000692 RID: 1682
	[Token(Token = "0x2000692")]
	public class MedalCellViewHolder : CellViewsHolder
	{
		// Token: 0x060028A2 RID: 10402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x79C1", Offset = "0x79C1", VA = "0x79C1", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x79C2", Offset = "0x79C2", VA = "0x79C2")]
		public void UpdateViews(MedalData model, UserData user, UserData loggedUser, HashSet<MedalData> separatorItems, HashSet<MedalData> rowCompletionItems, Action<MedalView> clickCallback)
		{
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x79C3", Offset = "0x79C3", VA = "0x79C3")]
		public void UpdateViews(MedalData model, UserData user, UserData loggedUser, HashSet<MedalData> separatorItems, HashSet<MedalData> rowCompletionItems, Action<MedalView> clickCallback, bool hasSale)
		{
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x79C4", Offset = "0x79C4", VA = "0x79C4")]
		private bool HasSale(MedalData model, bool hasSale)
		{
			return default(bool);
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x79C5", Offset = "0x79C5", VA = "0x79C5")]
		private void SetVisible(bool enabled)
		{
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x79C6", Offset = "0x79C6", VA = "0x79C6")]
		public MedalCellViewHolder()
		{
		}

		// Token: 0x0400166E RID: 5742
		[Token(Token = "0x400166E")]
		[FieldOffset(Offset = "0x18")]
		private MedalGroupView _medalView;
	}
}

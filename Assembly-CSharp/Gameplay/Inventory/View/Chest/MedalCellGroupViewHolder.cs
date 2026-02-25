using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000695 RID: 1685
	[Token(Token = "0x2000695")]
	public class MedalCellGroupViewHolder : CellGroupViewsHolder<MedalCellViewHolder>
	{
		// Token: 0x060028B6 RID: 10422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B6")]
		[Address(RVA = "0x79D5", Offset = "0x79D5", VA = "0x79D5", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B7")]
		[Address(RVA = "0x79D6", Offset = "0x79D6", VA = "0x79D6")]
		public void ShowHeader(string text)
		{
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B8")]
		[Address(RVA = "0x79D7", Offset = "0x79D7", VA = "0x79D7")]
		public void ClearHeader()
		{
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B9")]
		[Address(RVA = "0x79D8", Offset = "0x79D8", VA = "0x79D8")]
		public MedalCellGroupViewHolder()
		{
		}

		// Token: 0x0400167A RID: 5754
		[Token(Token = "0x400167A")]
		[FieldOffset(Offset = "0x24")]
		private ContentSizeFitter _contentSizeFitterComponent;

		// Token: 0x0400167B RID: 5755
		[Token(Token = "0x400167B")]
		[FieldOffset(Offset = "0x28")]
		private Transform _headerGroup;

		// Token: 0x0400167C RID: 5756
		[Token(Token = "0x400167C")]
		[FieldOffset(Offset = "0x2C")]
		private TextMeshProUGUI _headerLabel;
	}
}

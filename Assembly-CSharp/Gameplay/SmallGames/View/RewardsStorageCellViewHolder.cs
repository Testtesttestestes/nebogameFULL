using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	public class RewardsStorageCellViewHolder : CellViewsHolder
	{
		// Token: 0x06001F04 RID: 7940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x706B", Offset = "0x706B", VA = "0x706B", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001F06 RID: 7942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A1")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6001F05")]
			[Address(RVA = "0x706C", Offset = "0x706C", VA = "0x706C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F06")]
			[Address(RVA = "0x706D", Offset = "0x706D", VA = "0x706D")]
			set
			{
			}
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x706E", Offset = "0x706E", VA = "0x706E")]
		public RewardsStorageCellViewHolder()
		{
		}

		// Token: 0x040010C9 RID: 4297
		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x18")]
		private ArtifactView _artifactGridView;
	}
}

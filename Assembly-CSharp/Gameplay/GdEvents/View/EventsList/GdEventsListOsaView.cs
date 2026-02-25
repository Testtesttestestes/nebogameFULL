using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000737 RID: 1847
	[Token(Token = "0x2000737")]
	public class GdEventsListOsaView : GridAdapter<MyGridParams, MyCellViewsHolder>
	{
		// Token: 0x14000162 RID: 354
		// (add) Token: 0x06002C0F RID: 11279 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002C10 RID: 11280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000162")]
		public event Action<CellModel> ClickEvent
		{
			[Token(Token = "0x6002C0F")]
			[Address(RVA = "0x7C9F", Offset = "0x7C9F", VA = "0x7C9F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C10")]
			[Address(RVA = "0x7CA0", Offset = "0x7CA0", VA = "0x7CA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C11")]
		[Address(RVA = "0x7CA1", Offset = "0x7CA1", VA = "0x7CA1")]
		private void InvokeClickEvent(CellModel model)
		{
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C12")]
		[Address(RVA = "0x7CA2", Offset = "0x7CA2", VA = "0x7CA2", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C13")]
		[Address(RVA = "0x7CA3", Offset = "0x7CA3", VA = "0x7CA3", Slot = "79")]
		public override void Refresh(bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C14")]
		[Address(RVA = "0x7CA4", Offset = "0x7CA4", VA = "0x7CA4", Slot = "126")]
		protected override CellGroupViewsHolder<MyCellViewsHolder> GetNewCellGroupViewsHolder()
		{
			return null;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C15")]
		[Address(RVA = "0x7CA5", Offset = "0x7CA5", VA = "0x7CA5", Slot = "100")]
		protected override void UpdateViewsHolder(CellGroupViewsHolder<MyCellViewsHolder> newOrRecycled)
		{
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C16")]
		[Address(RVA = "0x7CA6", Offset = "0x7CA6", VA = "0x7CA6", Slot = "128")]
		protected override void UpdateCellViewsHolder(MyCellViewsHolder viewsHolder)
		{
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C17")]
		[Address(RVA = "0x7CA7", Offset = "0x7CA7", VA = "0x7CA7", Slot = "110")]
		protected override void PostRebuildLayoutDueToScrollViewSizeChange()
		{
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C18")]
		[Address(RVA = "0x7CA8", Offset = "0x7CA8", VA = "0x7CA8")]
		public void ResetData(List<CategoryModel> categories)
		{
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C19")]
		[Address(RVA = "0x7CA9", Offset = "0x7CA9", VA = "0x7CA9")]
		public GdEventsListOsaView()
		{
		}

		// Token: 0x04001824 RID: 6180
		[Token(Token = "0x4001824")]
		[FieldOffset(Offset = "0xB4")]
		private List<CellModel> Data;

		// Token: 0x04001825 RID: 6181
		[Token(Token = "0x4001825")]
		[FieldOffset(Offset = "0xB8")]
		private List<CategoryModel> _Categories;

		// Token: 0x04001826 RID: 6182
		[Token(Token = "0x4001826")]
		[FieldOffset(Offset = "0xBC")]
		private int _LastKnownNumberOfCellsPerGroup;
	}
}

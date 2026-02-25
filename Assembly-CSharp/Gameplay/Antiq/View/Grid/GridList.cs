using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;

namespace Gameplay.Antiq.View.Grid
{
	// Token: 0x02000D89 RID: 3465
	[Token(Token = "0x2000D89")]
	internal class GridList : GridAdapter<GridParams, CellHolder>
	{
		// Token: 0x14000202 RID: 514
		// (add) Token: 0x060054C9 RID: 21705 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060054CA RID: 21706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000202")]
		public event Action<GroupData> SelectEvent
		{
			[Token(Token = "0x60054C9")]
			[Address(RVA = "0xA275", Offset = "0xA275", VA = "0xA275")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60054CA")]
			[Address(RVA = "0xA276", Offset = "0xA276", VA = "0xA276")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CB")]
		[Address(RVA = "0xA277", Offset = "0xA277", VA = "0xA277", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CC")]
		[Address(RVA = "0xA278", Offset = "0xA278", VA = "0xA278", Slot = "127")]
		protected override void OnCellViewsHolderCreated(CellHolder cellVH, CellGroupViewsHolder<CellHolder> cellGroup)
		{
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CD")]
		[Address(RVA = "0xA279", Offset = "0xA279", VA = "0xA279")]
		private void HandleItemClickEvent(GroupData data)
		{
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CE")]
		[Address(RVA = "0xA27A", Offset = "0xA27A", VA = "0xA27A", Slot = "128")]
		protected override void UpdateCellViewsHolder(CellHolder viewsHolder)
		{
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CF")]
		[Address(RVA = "0x1D25", Offset = "0x1D25", VA = "0x1D25")]
		public void SetData(IList<GroupData> value)
		{
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054D0")]
		[Address(RVA = "0xA27B", Offset = "0xA27B", VA = "0xA27B")]
		public GridList()
		{
		}

		// Token: 0x04002DF0 RID: 11760
		[Token(Token = "0x4002DF0")]
		[FieldOffset(Offset = "0xB0")]
		private SimpleDataHelper<GroupData> _data;
	}
}

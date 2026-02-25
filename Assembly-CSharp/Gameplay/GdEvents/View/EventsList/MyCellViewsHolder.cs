using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x0200073C RID: 1852
	[Token(Token = "0x200073C")]
	public class MyCellViewsHolder : CellViewsHolder
	{
		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002C21 RID: 11297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000864")]
		public GdEventItemView ItemRender
		{
			[Token(Token = "0x6002C20")]
			[Address(RVA = "0x7CB0", Offset = "0x7CB0", VA = "0x7CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002C21")]
			[Address(RVA = "0x7CB1", Offset = "0x7CB1", VA = "0x7CB1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C22")]
		[Address(RVA = "0x7CB2", Offset = "0x7CB2", VA = "0x7CB2", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C23")]
		[Address(RVA = "0x7CB3", Offset = "0x7CB3", VA = "0x7CB3")]
		public void UpdateViews(CellModel model, MyGridParams parameters, Action<CellModel> clickCallback)
		{
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x7CB4", Offset = "0x7CB4", VA = "0x7CB4")]
		private void SetVisible(bool enabled)
		{
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x7CB5", Offset = "0x7CB5", VA = "0x7CB5")]
		public MyCellViewsHolder()
		{
		}
	}
}

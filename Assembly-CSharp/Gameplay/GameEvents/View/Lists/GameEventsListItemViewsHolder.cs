using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.View.Lists
{
	// Token: 0x0200078C RID: 1932
	[Token(Token = "0x200078C")]
	public class GameEventsListItemViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D5")]
		public GameEventsListView.GameEventsListItemWrapper GameEventData
		{
			[Token(Token = "0x6002DF1")]
			[Address(RVA = "0x7E6F", Offset = "0x7E6F", VA = "0x7E6F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DF2")]
			[Address(RVA = "0x7E70", Offset = "0x7E70", VA = "0x7E70")]
			set
			{
			}
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF3")]
		[Address(RVA = "0x7E71", Offset = "0x7E71", VA = "0x7E71", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DF4")]
		[Address(RVA = "0x7E72", Offset = "0x7E72", VA = "0x7E72")]
		public GameEventsListItemViewsHolder()
		{
		}

		// Token: 0x04001931 RID: 6449
		[Token(Token = "0x4001931")]
		[FieldOffset(Offset = "0x14")]
		private GameEventItemRenderer _itemRenderer;
	}
}

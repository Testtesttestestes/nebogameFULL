using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Events.ClanWars;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanWarsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A85 RID: 2693
	[Token(Token = "0x2000A85")]
	public class ClanWarsOfficeViewMediator : AbstractViewMediator<ClanWarsOfficeModel, ClanWarsOfficeEvents, ClanWarsOfficeController, ClanWarsView>, IHideableMediator
	{
		// Token: 0x06004065 RID: 16485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004065")]
		[Address(RVA = "0x8F1F", Offset = "0x8F1F", VA = "0x8F1F")]
		public ClanWarsOfficeViewMediator(ClanWarsOfficeModel model, ClanWarsOfficeEvents events, ClanWarsOfficeController controller)
		{
		}

		// Token: 0x17000CB5 RID: 3253
		// (set) Token: 0x06004066 RID: 16486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB5")]
		public override ClanWarsView View
		{
			[Token(Token = "0x6004066")]
			[Address(RVA = "0x8F20", Offset = "0x8F20", VA = "0x8F20", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB6")]
		public override ClanWarsOfficeEvents Events
		{
			[Token(Token = "0x6004067")]
			[Address(RVA = "0x8F21", Offset = "0x8F21", VA = "0x8F21", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004068")]
		[Address(RVA = "0x8F22", Offset = "0x8F22", VA = "0x8F22")]
		private void InitEventHandler()
		{
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004069")]
		[Address(RVA = "0x8F23", Offset = "0x8F23", VA = "0x8F23")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406A")]
		[Address(RVA = "0x8F24", Offset = "0x8F24", VA = "0x8F24")]
		private void AssignNewMediator()
		{
		}

		// Token: 0x0600406B RID: 16491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600406B")]
		[Address(RVA = "0x8F25", Offset = "0x8F25", VA = "0x8F25")]
		private IHideableMediator ShowClanWarsRewardsTab()
		{
			return null;
		}

		// Token: 0x0600406C RID: 16492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600406C")]
		[Address(RVA = "0x8F26", Offset = "0x8F26", VA = "0x8F26")]
		private IHideableMediator ShowClanPoliticsTab()
		{
			return null;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600406D")]
		[Address(RVA = "0x8F27", Offset = "0x8F27", VA = "0x8F27")]
		private IHideableMediator ShowHistoryTab()
		{
			return null;
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406E")]
		[Address(RVA = "0x8F28", Offset = "0x8F28", VA = "0x8F28", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x0600406F RID: 16495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600406F")]
		[Address(RVA = "0x8F29", Offset = "0x8F29", VA = "0x8F29", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06004070 RID: 16496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004070")]
		[Address(RVA = "0x8F2A", Offset = "0x8F2A", VA = "0x8F2A")]
		[CompilerGenerated]
		private void <ShowHistoryTab>g__CreateClanWarsHistoryMVC|17_0()
		{
		}

		// Token: 0x040023D8 RID: 9176
		[Token(Token = "0x40023D8")]
		[FieldOffset(Offset = "0x18")]
		private ClanWarsRewardsViewMediator _clanWarsRewardsViewMediator;

		// Token: 0x040023D9 RID: 9177
		[Token(Token = "0x40023D9")]
		[FieldOffset(Offset = "0x1C")]
		private ClanPoliticsViewMediator _clanPoliticsViewMediator;

		// Token: 0x040023DA RID: 9178
		[Token(Token = "0x40023DA")]
		[FieldOffset(Offset = "0x20")]
		private ClanWarsHistoryViewMediator _clanWarsHistoryViewMediator;

		// Token: 0x040023DB RID: 9179
		[Token(Token = "0x40023DB")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<uint, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x040023DC RID: 9180
		[Token(Token = "0x40023DC")]
		[FieldOffset(Offset = "0x28")]
		private IHideableMediator _currentMediator;

		// Token: 0x040023DD RID: 9181
		[Token(Token = "0x40023DD")]
		[FieldOffset(Offset = "0x2C")]
		private ClanWarsHistoryEvents _clanWarsHistoryEvents;

		// Token: 0x040023DE RID: 9182
		[Token(Token = "0x40023DE")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInit;
	}
}

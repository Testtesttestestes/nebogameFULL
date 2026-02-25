using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Office.Controller.ClanWars;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A69 RID: 2665
	[Token(Token = "0x2000A69")]
	public class ClanInfoViewMediator : AbstractViewMediator<ClanInfoModel, ClanInfoEvents, ClanInfoController, ClanInfoWindow>
	{
		// Token: 0x06003F05 RID: 16133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F05")]
		[Address(RVA = "0x8DC0", Offset = "0x8DC0", VA = "0x8DC0")]
		public ClanInfoViewMediator(ClanInfoModel model, ClanInfoEvents events, ClanInfoController controller)
		{
		}

		// Token: 0x17000C9A RID: 3226
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9A")]
		public override ClanInfoWindow View
		{
			[Token(Token = "0x6003F06")]
			[Address(RVA = "0x8DC1", Offset = "0x8DC1", VA = "0x8DC1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (set) Token: 0x06003F07 RID: 16135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9B")]
		public override ClanInfoEvents Events
		{
			[Token(Token = "0x6003F07")]
			[Address(RVA = "0x8DC2", Offset = "0x8DC2", VA = "0x8DC2", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F08")]
		[Address(RVA = "0x8DC3", Offset = "0x8DC3", VA = "0x8DC3")]
		private void NewHeadAppiontedEventHandler()
		{
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F09")]
		[Address(RVA = "0x8DC4", Offset = "0x8DC4", VA = "0x8DC4")]
		private void Init()
		{
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F0A")]
		[Address(RVA = "0x8DC5", Offset = "0x8DC5", VA = "0x8DC5")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F0B")]
		[Address(RVA = "0x8DC6", Offset = "0x8DC6", VA = "0x8DC6")]
		private void AssignNewMediator()
		{
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F0C")]
		[Address(RVA = "0x8DC7", Offset = "0x8DC7", VA = "0x8DC7")]
		private IHideableMediator ShowClanOverviewTab()
		{
			return null;
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F0D")]
		[Address(RVA = "0x8DC8", Offset = "0x8DC8", VA = "0x8DC8")]
		private IHideableMediator ShowClanMembersTab()
		{
			return null;
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F0E")]
		[Address(RVA = "0x8DC9", Offset = "0x8DC9", VA = "0x8DC9")]
		private IHideableMediator ShowClanWarsTab()
		{
			return null;
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F0F")]
		[Address(RVA = "0x8DCA", Offset = "0x8DCA", VA = "0x8DCA")]
		private IHideableMediator ShowClanResumesTab()
		{
			return null;
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F10")]
		[Address(RVA = "0x8DCB", Offset = "0x8DCB", VA = "0x8DCB")]
		private IHideableMediator ShowTreasuryTab()
		{
			return null;
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F11")]
		[Address(RVA = "0x8DCC", Offset = "0x8DCC", VA = "0x8DCC")]
		private IHideableMediator ShowSquadTab()
		{
			return null;
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F12")]
		[Address(RVA = "0x8DCD", Offset = "0x8DCD", VA = "0x8DCD")]
		private IHideableMediator ShowClassTab()
		{
			return null;
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F13")]
		[Address(RVA = "0x8DCE", Offset = "0x8DCE", VA = "0x8DCE", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F15")]
		[Address(RVA = "0x8DD0", Offset = "0x8DD0", VA = "0x8DD0")]
		[CompilerGenerated]
		private void <ShowClanWarsTab>g__CreateClanWarsMVC|24_0()
		{
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F16")]
		[Address(RVA = "0x8DD1", Offset = "0x8DD1", VA = "0x8DD1")]
		[CompilerGenerated]
		private void <ShowClanResumesTab>g__CreateClanResumesMVC|25_0()
		{
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F17")]
		[Address(RVA = "0x8DD2", Offset = "0x8DD2", VA = "0x8DD2")]
		[CompilerGenerated]
		private void <ShowSquadTab>g__CreateClanResumesMVC|27_0()
		{
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F18")]
		[Address(RVA = "0x8DD3", Offset = "0x8DD3", VA = "0x8DD3")]
		[CompilerGenerated]
		private void <ShowClassTab>g__CreateClanResumesMVC|28_0()
		{
		}

		// Token: 0x04002383 RID: 9091
		[Token(Token = "0x4002383")]
		[FieldOffset(Offset = "0x18")]
		private ClanOverviewMediator _clanOverviewMediator;

		// Token: 0x04002384 RID: 9092
		[Token(Token = "0x4002384")]
		[FieldOffset(Offset = "0x1C")]
		private ClanMembersViewMediator _clanMembersViewMediator;

		// Token: 0x04002385 RID: 9093
		[Token(Token = "0x4002385")]
		[FieldOffset(Offset = "0x20")]
		private ClanWarsOfficeViewMediator _clanWarsViewMediator;

		// Token: 0x04002386 RID: 9094
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x24")]
		private ClanResumesViewMediator _clanResumesViewMediator;

		// Token: 0x04002387 RID: 9095
		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x28")]
		private ClanTreasuryViewMediator _clanTreasuryViewMediator;

		// Token: 0x04002388 RID: 9096
		[Token(Token = "0x4002388")]
		[FieldOffset(Offset = "0x2C")]
		private SquadViewMediator _squadViewMediator;

		// Token: 0x04002389 RID: 9097
		[Token(Token = "0x4002389")]
		[FieldOffset(Offset = "0x30")]
		private ClassViewMediator _classViewMediator;

		// Token: 0x0400238A RID: 9098
		[Token(Token = "0x400238A")]
		[FieldOffset(Offset = "0x34")]
		private ClanWarsOfficeEvents _clanWarsEvents;

		// Token: 0x0400238B RID: 9099
		[Token(Token = "0x400238B")]
		[FieldOffset(Offset = "0x38")]
		private ClanResumesEvents _clanResumesEvents;

		// Token: 0x0400238C RID: 9100
		[Token(Token = "0x400238C")]
		[FieldOffset(Offset = "0x3C")]
		private SquadEvents _squadEvents;

		// Token: 0x0400238D RID: 9101
		[Token(Token = "0x400238D")]
		[FieldOffset(Offset = "0x40")]
		private ClassEvents _classEvents;

		// Token: 0x0400238E RID: 9102
		[Token(Token = "0x400238E")]
		[FieldOffset(Offset = "0x44")]
		private Dictionary<ClanInfoWindow.Tab, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x0400238F RID: 9103
		[Token(Token = "0x400238F")]
		[FieldOffset(Offset = "0x48")]
		private IHideableMediator _currentMediator;
	}
}

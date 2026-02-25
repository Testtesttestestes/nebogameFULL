using System;
using System.Collections.Generic;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6C RID: 2668
	[Token(Token = "0x2000A6C")]
	public class ClanOfficeViewMediator : AbstractViewMediator<ClanOfficeModel, ClanOfficeEvents, ClanOfficeController, ClanOfficeWindow>
	{
		// Token: 0x06003F4E RID: 16206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x8E09", Offset = "0x8E09", VA = "0x8E09")]
		public ClanOfficeViewMediator(ClanOfficeModel model, ClanOfficeEvents events, ClanOfficeController controller)
		{
		}

		// Token: 0x17000C9E RID: 3230
		// (set) Token: 0x06003F4F RID: 16207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9E")]
		public override ClanOfficeWindow View
		{
			[Token(Token = "0x6003F4F")]
			[Address(RVA = "0x8E0A", Offset = "0x8E0A", VA = "0x8E0A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F50")]
		[Address(RVA = "0x8E0B", Offset = "0x8E0B", VA = "0x8E0B")]
		private void Init()
		{
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F51")]
		[Address(RVA = "0x8E0C", Offset = "0x8E0C", VA = "0x8E0C")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x17000C9F RID: 3231
		// (set) Token: 0x06003F52 RID: 16210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9F")]
		public override ClanOfficeEvents Events
		{
			[Token(Token = "0x6003F52")]
			[Address(RVA = "0x8E0D", Offset = "0x8E0D", VA = "0x8E0D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F53")]
		[Address(RVA = "0x8E0E", Offset = "0x8E0E", VA = "0x8E0E")]
		private void RequestCloseOfficeWindowEventHandler()
		{
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F54")]
		[Address(RVA = "0x8E0F", Offset = "0x8E0F", VA = "0x8E0F")]
		private void AssignNewMediator()
		{
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F55")]
		[Address(RVA = "0x8E10", Offset = "0x8E10", VA = "0x8E10")]
		private IHideableMediator ShowAboutClansTab()
		{
			return null;
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F56")]
		[Address(RVA = "0x8E11", Offset = "0x8E11", VA = "0x8E11")]
		private IHideableMediator ShowClanCreationTab()
		{
			return null;
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F57")]
		[Address(RVA = "0x8E12", Offset = "0x8E12", VA = "0x8E12")]
		private IHideableMediator ShowVacanciesTab()
		{
			return null;
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F58")]
		[Address(RVA = "0x8E13", Offset = "0x8E13", VA = "0x8E13", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04002395 RID: 9109
		[Token(Token = "0x4002395")]
		[FieldOffset(Offset = "0x18")]
		private ClanCreationViewMediator _clanCreationViewMediator;

		// Token: 0x04002396 RID: 9110
		[Token(Token = "0x4002396")]
		[FieldOffset(Offset = "0x1C")]
		private VacanciesViewMediator _vacanciesViewMediator;

		// Token: 0x04002397 RID: 9111
		[Token(Token = "0x4002397")]
		[FieldOffset(Offset = "0x20")]
		private AboutClansViewMediator _aboutClansViewMediator;

		// Token: 0x04002398 RID: 9112
		[Token(Token = "0x4002398")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<uint, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x04002399 RID: 9113
		[Token(Token = "0x4002399")]
		[FieldOffset(Offset = "0x28")]
		private IHideableMediator _currentMediator;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E6 RID: 742
	[Token(Token = "0x20002E6")]
	public class WorldAxisOfficeViewMediator : AbstractViewMediator<WorldAxisOfficeModel, WorldAxisOfficeEvents, WorldAxisOfficeController, WorldAxisOfficeWindow>
	{
		// Token: 0x06001195 RID: 4501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001195")]
		[Address(RVA = "0x6392", Offset = "0x6392", VA = "0x6392")]
		public WorldAxisOfficeViewMediator(WorldAxisOfficeModel model, WorldAxisOfficeEvents events, WorldAxisOfficeController controller)
		{
		}

		// Token: 0x17000297 RID: 663
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000297")]
		public override WorldAxisOfficeWindow View
		{
			[Token(Token = "0x6001196")]
			[Address(RVA = "0x6393", Offset = "0x6393", VA = "0x6393", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001197")]
		[Address(RVA = "0x6394", Offset = "0x6394", VA = "0x6394")]
		private void Init()
		{
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x6395", Offset = "0x6395", VA = "0x6395")]
		private void InitTabBar()
		{
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001199")]
		[Address(RVA = "0x6396", Offset = "0x6396", VA = "0x6396")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x17000298 RID: 664
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000298")]
		public override WorldAxisOfficeEvents Events
		{
			[Token(Token = "0x600119A")]
			[Address(RVA = "0x6397", Offset = "0x6397", VA = "0x6397", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119B")]
		[Address(RVA = "0x6398", Offset = "0x6398", VA = "0x6398")]
		private void ScheduleChangedEventHandler()
		{
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119C")]
		[Address(RVA = "0x6399", Offset = "0x6399", VA = "0x6399")]
		private void AssignNewMediator()
		{
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600119D")]
		[Address(RVA = "0x639A", Offset = "0x639A", VA = "0x639A")]
		private IHideableMediator ShowFrontPageTab()
		{
			return null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600119E")]
		[Address(RVA = "0x639B", Offset = "0x639B", VA = "0x639B")]
		private IHideableMediator ShowScheduleTab()
		{
			return null;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600119F")]
		[Address(RVA = "0x639C", Offset = "0x639C", VA = "0x639C")]
		private IHideableMediator ShowHistoryTab()
		{
			return null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x639D", Offset = "0x639D", VA = "0x639D")]
		private IHideableMediator ShowClanRatingsTab()
		{
			return null;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x639E", Offset = "0x639E", VA = "0x639E")]
		private IHideableMediator ShowUserRatingsTab()
		{
			return null;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x639F", Offset = "0x639F", VA = "0x639F")]
		private IHideableMediator ShowRewardsTab()
		{
			return null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x63A0", Offset = "0x63A0", VA = "0x63A0")]
		private void CreateRatingsMVC()
		{
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x63A1", Offset = "0x63A1", VA = "0x63A1")]
		private void DestroyRatingsMVC()
		{
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A5")]
		[Address(RVA = "0x63A2", Offset = "0x63A2", VA = "0x63A2", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A7")]
		[Address(RVA = "0x63A4", Offset = "0x63A4", VA = "0x63A4")]
		[CompilerGenerated]
		private void <ShowHistoryTab>g__CreateHistoryMVC|26_0()
		{
		}

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<WorldAxisOfficeWindow.Tab, Func<IHideableMediator>> _tabsOpenersById;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x1C")]
		private IHideableMediator _currentMediator;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x20")]
		private FrontPageViewMediator _frontPageViewMediator;

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		[FieldOffset(Offset = "0x24")]
		private WorldAxisScheduleViewMediator _worldAxisScheduleViewMediator;

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		[FieldOffset(Offset = "0x28")]
		private HistoryViewMediator _historyViewMediator;

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		[FieldOffset(Offset = "0x2C")]
		private ClanRatingsViewMediator _clanRatingsViewMediator;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x30")]
		private UserRatingsViewMediator _userRatingsViewMediator;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x34")]
		private SeasonRewardsViewMediator _seasonRewardsViewMediator;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x38")]
		private HistoryEvents _historyEvents;

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x3C")]
		private RatingsModel _ratingsModel;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x40")]
		private RatingsEvents _ratingsEvents;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x44")]
		private RatingsController _ratingsController;

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x48")]
		private bool _ratingsMVCCreated;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x49")]
		private bool _tabBarInitialized;
	}
}

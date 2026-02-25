using System;
using System.Collections;
using Gameplay.SmallGames.Events;
using Gameplay.SmallGames.Model;
using Gameplay.SmallGames.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;
using UnityEngine;

namespace Gameplay.SmallGames.Controller
{
	// Token: 0x0200053B RID: 1339
	[Token(Token = "0x200053B")]
	public class SmallGamesEnterPointViewMediator : AbstractViewMediator<SmallGamesModel, SmallGamesEvents, SmallGamesController, UserInterfaceView>
	{
		// Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002004")]
		[Address(RVA = "0x7169", Offset = "0x7169", VA = "0x7169")]
		public SmallGamesEnterPointViewMediator(SmallGamesModel model, SmallGamesEvents events, SmallGamesController controller)
		{
		}

		// Token: 0x170005DC RID: 1500
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DC")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6002005")]
			[Address(RVA = "0x716A", Offset = "0x716A", VA = "0x716A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DD")]
		public override SmallGamesEvents Events
		{
			[Token(Token = "0x6002006")]
			[Address(RVA = "0x716B", Offset = "0x716B", VA = "0x716B", Slot = "15")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002007")]
			[Address(RVA = "0x716C", Offset = "0x716C", VA = "0x716C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x716D", Offset = "0x716D", VA = "0x716D")]
		private void FreeAttemptsRequestedEventHandler()
		{
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x716E", Offset = "0x716E", VA = "0x716E")]
		private IEnumerator NextFreeSpinRoutine(float backtime)
		{
			return null;
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x716F", Offset = "0x716F", VA = "0x716F")]
		private void DailyRewardsButtonClickedEventHandler(IndexButtonBasic btn)
		{
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x7170", Offset = "0x7170", VA = "0x7170")]
		private void SmallGamesButtonClickedEventHandler(IndexButtonBasic indexButton)
		{
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x7171", Offset = "0x7171", VA = "0x7171")]
		private void ResetView()
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x7172", Offset = "0x7172", VA = "0x7172")]
		private void SetupView()
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x7173", Offset = "0x7173", VA = "0x7173")]
		private void HandleFreeAttemptsCountChangedEvent(int count)
		{
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x7174", Offset = "0x7174", VA = "0x7174")]
		private void HandleDailyRewardsStatusChangedEvent()
		{
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x7175", Offset = "0x7175", VA = "0x7175")]
		private void ShowSmallGames()
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x7176", Offset = "0x7176", VA = "0x7176")]
		private static void ShowDailyRewards()
		{
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x7177", Offset = "0x7177", VA = "0x7177")]
		private void SmallGamesWindowOnCloseEventHandler()
		{
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x7178", Offset = "0x7178", VA = "0x7178", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x18")]
		private SmallGamesWindow _smallGamesWindow;

		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _nextFreeSpinRoutine;
	}
}

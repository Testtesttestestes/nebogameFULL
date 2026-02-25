using System;
using Gameplay.ThemeDuelState.Model;
using Gameplay.ThemeDuelState.View.Lobby;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI;

namespace Gameplay.ThemeDuelState.Control
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	public class ThemeDuelLobbyMediator : AbstractViewMediator<ThemeDuelStateModel, ThemeDuelStateEvents, ThemeDuelStateController, ThemeDuelLobbyView>
	{
		// Token: 0x06001D61 RID: 7521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x6EE0", Offset = "0x6EE0", VA = "0x6EE0")]
		public ThemeDuelLobbyMediator(ThemeDuelStateModel model, ThemeDuelStateEvents events, ThemeDuelStateController controller)
		{
		}

		// Token: 0x17000544 RID: 1348
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000544")]
		public override ThemeDuelLobbyView View
		{
			[Token(Token = "0x6001D62")]
			[Address(RVA = "0x6EE1", Offset = "0x6EE1", VA = "0x6EE1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000545 RID: 1349
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000545")]
		public override ThemeDuelStateEvents Events
		{
			[Token(Token = "0x6001D63")]
			[Address(RVA = "0x6EE2", Offset = "0x6EE2", VA = "0x6EE2", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D64")]
		[Address(RVA = "0x6EE3", Offset = "0x6EE3", VA = "0x6EE3")]
		private void UpdateThemeDuel(ThemeDuelDic _)
		{
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x6EE4", Offset = "0x6EE4", VA = "0x6EE4")]
		private void Init()
		{
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x6EE5", Offset = "0x6EE5", VA = "0x6EE5")]
		private void ThemeDuelButtonClickedEventHandler(IndexButtonBasic indexButtonBasic)
		{
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x6EE6", Offset = "0x6EE6", VA = "0x6EE6")]
		private void UpdateBalance(long eventBalance)
		{
		}
	}
}

using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Gameplay.World.Events;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D39 RID: 3385
	[Token(Token = "0x2000D39")]
	public class IsleMonsterInfoWindowMediator2 : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleMonsterInfoWindow2>
	{
		// Token: 0x060052CD RID: 21197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CD")]
		[Address(RVA = "0xA0A3", Offset = "0xA0A3", VA = "0xA0A3")]
		public IsleMonsterInfoWindowMediator2(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010E1 RID: 4321
		// (set) Token: 0x060052CE RID: 21198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E1")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052CE")]
			[Address(RVA = "0xA0A4", Offset = "0xA0A4", VA = "0xA0A4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CF")]
		[Address(RVA = "0xA0A5", Offset = "0xA0A5", VA = "0xA0A5")]
		private void MonsterChangedEvent(WorldControllerEvents.MonsterChangeReason reason)
		{
		}

		// Token: 0x170010E2 RID: 4322
		// (set) Token: 0x060052D0 RID: 21200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E2")]
		public override IsleMonsterInfoWindow2 View
		{
			[Token(Token = "0x60052D0")]
			[Address(RVA = "0xA0A6", Offset = "0xA0A6", VA = "0xA0A6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D1")]
		[Address(RVA = "0xA0A7", Offset = "0xA0A7", VA = "0xA0A7")]
		private void UpdateMonsterInfo()
		{
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D2")]
		[Address(RVA = "0xA0A8", Offset = "0xA0A8", VA = "0xA0A8")]
		private void ResolveMonster()
		{
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D3")]
		[Address(RVA = "0xA0A9", Offset = "0xA0A9", VA = "0xA0A9")]
		private void AttackButtonClickHandler()
		{
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D4")]
		[Address(RVA = "0xA0AA", Offset = "0xA0AA", VA = "0xA0AA")]
		private void KickButtonClickHandler()
		{
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052D5")]
		[Address(RVA = "0xA0AB", Offset = "0xA0AB", VA = "0xA0AB")]
		private DialogWindow ShowMonsterFlewAwayDialogWindow()
		{
			return null;
		}
	}
}

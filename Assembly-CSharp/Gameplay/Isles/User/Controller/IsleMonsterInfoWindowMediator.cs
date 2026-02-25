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
	// Token: 0x02000D38 RID: 3384
	[Token(Token = "0x2000D38")]
	public class IsleMonsterInfoWindowMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleMonsterInfoWindow>
	{
		// Token: 0x060052C2 RID: 21186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C2")]
		[Address(RVA = "0xA098", Offset = "0xA098", VA = "0xA098")]
		public IsleMonsterInfoWindowMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010DF RID: 4319
		// (set) Token: 0x060052C3 RID: 21187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DF")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052C3")]
			[Address(RVA = "0xA099", Offset = "0xA099", VA = "0xA099", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C4")]
		[Address(RVA = "0xA09A", Offset = "0xA09A", VA = "0xA09A")]
		private void MonsterChangedEvent(WorldControllerEvents.MonsterChangeReason reason)
		{
		}

		// Token: 0x170010E0 RID: 4320
		// (set) Token: 0x060052C5 RID: 21189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E0")]
		public override IsleMonsterInfoWindow View
		{
			[Token(Token = "0x60052C5")]
			[Address(RVA = "0xA09B", Offset = "0xA09B", VA = "0xA09B", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C6")]
		[Address(RVA = "0xA09C", Offset = "0xA09C", VA = "0xA09C")]
		private void ResetView()
		{
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C7")]
		[Address(RVA = "0xA09D", Offset = "0xA09D", VA = "0xA09D")]
		private void SetupView()
		{
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C8")]
		[Address(RVA = "0xA09E", Offset = "0xA09E", VA = "0xA09E")]
		private void UpdateMonsterInfo()
		{
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C9")]
		[Address(RVA = "0xA09F", Offset = "0xA09F", VA = "0xA09F")]
		private void ResolveMonster()
		{
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CA")]
		[Address(RVA = "0xA0A0", Offset = "0xA0A0", VA = "0xA0A0")]
		private void AttackButtonClickHandler()
		{
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052CB")]
		[Address(RVA = "0xA0A1", Offset = "0xA0A1", VA = "0xA0A1")]
		private void KickButtonClickHandler()
		{
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052CC")]
		[Address(RVA = "0xA0A2", Offset = "0xA0A2", VA = "0xA0A2")]
		private DialogWindow ShowMonsterFlewAwayDialogWindow()
		{
			return null;
		}
	}
}

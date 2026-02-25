using System;
using Gameplay.Duel.Events;
using Gameplay.Duel.Model;
using Gameplay.Duel.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000868 RID: 2152
	[Token(Token = "0x2000868")]
	public class DuelViewMediator : AbstractViewMediator<DuelModel, DuelEvents, DuelController, DuelWindow>
	{
		// Token: 0x0600329D RID: 12957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329D")]
		[Address(RVA = "0x82F2", Offset = "0x82F2", VA = "0x82F2")]
		public DuelViewMediator(DuelModel model, DuelEvents events, DuelController controller)
		{
		}

		// Token: 0x170009F9 RID: 2553
		// (set) Token: 0x0600329E RID: 12958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F9")]
		public override DuelWindow View
		{
			[Token(Token = "0x600329E")]
			[Address(RVA = "0x82F3", Offset = "0x82F3", VA = "0x82F3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170009FA RID: 2554
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009FA")]
		public override DuelEvents Events
		{
			[Token(Token = "0x600329F")]
			[Address(RVA = "0x82F4", Offset = "0x82F4", VA = "0x82F4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A0")]
		[Address(RVA = "0x82F5", Offset = "0x82F5", VA = "0x82F5")]
		private void Init()
		{
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A1")]
		[Address(RVA = "0x82F6", Offset = "0x82F6", VA = "0x82F6")]
		private void HandleDuelState()
		{
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A2")]
		[Address(RVA = "0x82F7", Offset = "0x82F7", VA = "0x82F7")]
		private void CloseViewEventHandler()
		{
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A3")]
		[Address(RVA = "0x82F8", Offset = "0x82F8", VA = "0x82F8")]
		private void AttackButtonClickedEventHandler()
		{
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A4")]
		[Address(RVA = "0x82F9", Offset = "0x82F9", VA = "0x82F9")]
		private void PayOffButtonClickedEventHandler()
		{
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A5")]
		[Address(RVA = "0x82FA", Offset = "0x82FA", VA = "0x82FA")]
		private void DuelInfoRequestedEventHandler()
		{
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032A6")]
		[Address(RVA = "0x82FB", Offset = "0x82FB", VA = "0x82FB")]
		private void SkillsRequestedEventHandler()
		{
		}
	}
}

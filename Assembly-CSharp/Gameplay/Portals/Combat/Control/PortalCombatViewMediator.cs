using System;
using Core.Application;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Gameplay.Portals.Combat.Model;
using Gameplay.Portals.Combat.View;
using Gameplay.Portals.Model;
using Il2CppDummyDll;

namespace Gameplay.Portals.Combat.Control
{
	// Token: 0x020005EE RID: 1518
	[Token(Token = "0x20005EE")]
	public class PortalCombatViewMediator : AbstractOneOnOneCombatViewMediator<PortalCombatModel, PortalCombatEvents, PortalCombatController, PortalCombatView>
	{
		// Token: 0x060024D1 RID: 9425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x761F", Offset = "0x761F", VA = "0x761F")]
		public PortalCombatViewMediator(PortalCombatModel model, PortalCombatEvents events, PortalCombatController controller)
		{
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D2")]
		[Address(RVA = "0x7620", Offset = "0x7620", VA = "0x7620", Slot = "32")]
		protected override void HandleResetView()
		{
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x7621", Offset = "0x7621", VA = "0x7621", Slot = "31")]
		protected override void HandleSetupView()
		{
		}

		// Token: 0x170006DF RID: 1759
		// (set) Token: 0x060024D4 RID: 9428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DF")]
		public override PortalCombatEvents Events
		{
			[Token(Token = "0x60024D4")]
			[Address(RVA = "0x7622", Offset = "0x7622", VA = "0x7622", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D5")]
		[Address(RVA = "0x7623", Offset = "0x7623", VA = "0x7623")]
		private void DropRemovedEventHandler()
		{
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x7624", Offset = "0x7624", VA = "0x7624")]
		private void HandleGetRewardButtonClickEvent()
		{
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x7625", Offset = "0x7625", VA = "0x7625")]
		private void HandleShopButtonClickEvent()
		{
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x7626", Offset = "0x7626", VA = "0x7626")]
		private void OpenPortalWindow(IApp app, PortalsTargets target)
		{
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x7627", Offset = "0x7627", VA = "0x7627", Slot = "37")]
		protected override void HandleGameOver()
		{
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x60024DA")]
		[Address(RVA = "0x7628", Offset = "0x7628", VA = "0x7628", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
			return default(bool);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x7629", Offset = "0x7629", VA = "0x7629", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView gameOverView)
		{
			return default(bool);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x1BE4", Offset = "0x1BE4", VA = "0x1BE4")]
		private void StageChangedHandler()
		{
		}
	}
}

using System;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Inventory.Controller;
using Il2CppDummyDll;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADB RID: 2779
	[Token(Token = "0x2000ADB")]
	public class GolemArtifactActionViewMediator : ArtifactActionBaseViewMediator<GolemInventoryModel, GolemInventoryEvents, GolemInventoryController>
	{
		// Token: 0x060042EE RID: 17134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EE")]
		[Address(RVA = "0x91A2", Offset = "0x91A2", VA = "0x91A2")]
		public GolemArtifactActionViewMediator(GolemInventoryModel model, GolemInventoryEvents events, GolemInventoryController controller)
		{
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042EF")]
		[Address(RVA = "0x91A3", Offset = "0x91A3", VA = "0x91A3", Slot = "23")]
		protected override void DrawPrice()
		{
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F0")]
		[Address(RVA = "0x91A4", Offset = "0x91A4", VA = "0x91A4", Slot = "25")]
		protected override void InitReforgeCostButton()
		{
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F1")]
		[Address(RVA = "0x91A5", Offset = "0x91A5", VA = "0x91A5", Slot = "24")]
		protected override void InitRepairCostButton()
		{
		}
	}
}

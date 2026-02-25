using System;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Controller;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Events;
using Core.Gameplay.Managers.Ad.Placements.EnergyRegen.Model;
using Gameplay.Ad.EnergyRegenAd.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Ad.EnergyRegenAd.Controller
{
	// Token: 0x02000DAE RID: 3502
	[Token(Token = "0x2000DAE")]
	public class EnergyRegenAdViewMediator : AbstractViewMediator<EnergyRegenAdPlacementModel, EnergyRegenAdPlacementEvents, EnergyRegenAdPlacementController, EnergyRegenAdView>
	{
		// Token: 0x0600558D RID: 21901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600558D")]
		[Address(RVA = "0xA32D", Offset = "0xA32D", VA = "0xA32D")]
		public EnergyRegenAdViewMediator(EnergyRegenAdPlacementModel model, EnergyRegenAdPlacementEvents events, EnergyRegenAdPlacementController controller)
		{
		}

		// Token: 0x17001160 RID: 4448
		// (set) Token: 0x0600558E RID: 21902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001160")]
		public override EnergyRegenAdPlacementEvents Events
		{
			[Token(Token = "0x600558E")]
			[Address(RVA = "0xA32E", Offset = "0xA32E", VA = "0xA32E", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17001161 RID: 4449
		// (set) Token: 0x0600558F RID: 21903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001161")]
		public override EnergyRegenAdView View
		{
			[Token(Token = "0x600558F")]
			[Address(RVA = "0xA32F", Offset = "0xA32F", VA = "0xA32F", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005590")]
		[Address(RVA = "0xA330", Offset = "0xA330", VA = "0xA330")]
		private void RenderMessage()
		{
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005591")]
		[Address(RVA = "0xA331", Offset = "0xA331", VA = "0xA331")]
		private void AdRewardedEvent()
		{
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005592")]
		[Address(RVA = "0xA332", Offset = "0xA332", VA = "0xA332")]
		private void WatchButtonClickHandler()
		{
		}
	}
}

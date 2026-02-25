using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model;
using Il2CppDummyDll;
using Protocol.Main;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Controller
{
	// Token: 0x0200121A RID: 4634
	[Token(Token = "0x200121A")]
	public class BattleBonusesAdController : AbstractAdPlacementController<BattleBonusesAdModel, BattleBonusesAdEvents>
	{
		// Token: 0x06006DC9 RID: 28105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC9")]
		[Address(RVA = "0xB888", Offset = "0xB888", VA = "0xB888")]
		public BattleBonusesAdController(BattleBonusesAdModel model, BattleBonusesAdEvents events, IAdController adController, AdEvents adEvents)
		{
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCA")]
		[Address(RVA = "0xB889", Offset = "0xB889", VA = "0xB889", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCB")]
		[Address(RVA = "0xB88A", Offset = "0xB88A", VA = "0xB88A")]
		private void MedalRemovedEvent(uint medalId)
		{
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCC")]
		[Address(RVA = "0xB88B", Offset = "0xB88B", VA = "0xB88B")]
		private void MedalAddedEvent(MedalInfo medalInfo)
		{
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCD")]
		[Address(RVA = "0xB88C", Offset = "0xB88C", VA = "0xB88C")]
		private void OnMedalsChanged(uint medalId)
		{
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCE")]
		[Address(RVA = "0xB88D", Offset = "0xB88D", VA = "0xB88D", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DCF")]
		[Address(RVA = "0xB88E", Offset = "0xB88E", VA = "0xB88E")]
		public WaitForCallBack<bool> IsAdAvailable()
		{
			return null;
		}
	}
}

using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Model;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Main;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.BattleFinish.Controller
{
	// Token: 0x02001216 RID: 4630
	[Token(Token = "0x2001216")]
	public class BattleFinishAdPlacementController : AbstractAdPlacementController<BattleFinishAdPlacementModel, BattleFinishAdPlacementEvents>
	{
		// Token: 0x06006DB9 RID: 28089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB9")]
		[Address(RVA = "0xB879", Offset = "0xB879", VA = "0xB879")]
		public BattleFinishAdPlacementController(BattleFinishAdPlacementModel model, BattleFinishAdPlacementEvents events, IAdController adController, AdEvents adEvents)
		{
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DBA")]
		[Address(RVA = "0xB87A", Offset = "0xB87A", VA = "0xB87A")]
		public WaitForCallBack<bool> IsAdAvailable(GameOverData gameOverData)
		{
			return null;
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBB")]
		[Address(RVA = "0xB87B", Offset = "0xB87B", VA = "0xB87B", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBC")]
		[Address(RVA = "0xB87C", Offset = "0xB87C", VA = "0xB87C")]
		private void OnDropRemoveEvent(DropTypes dropTypes)
		{
		}

		// Token: 0x06006DBD RID: 28093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBD")]
		[Address(RVA = "0xB87D", Offset = "0xB87D", VA = "0xB87D", Slot = "6")]
		protected override void HandleStop()
		{
		}
	}
}

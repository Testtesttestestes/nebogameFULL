using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Model;
using Gameplay.ArtifactDrop.Control;
using Il2CppDummyDll;
using UI.Toast;

namespace Core.Gameplay.Managers.Ad.Placements.BattleFinish
{
	// Token: 0x02001213 RID: 4627
	[Token(Token = "0x2001213")]
	public class BattleFinishAdPlacementManager : AbstractAdPlacementManager<BattleFinishAdPlacementModel, BattleFinishAdPlacementController, BattleFinishAdPlacementEvents>
	{
		// Token: 0x06006DB2 RID: 28082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB2")]
		[Address(RVA = "0xB872", Offset = "0xB872", VA = "0xB872")]
		private BattleFinishAdPlacementManager(IAdPlacementData adPlacementData, IArtifactDrop artifactDrop, ToastController toastController, IAdController adController, AdEvents adEvents, UserData user)
		{
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB3")]
		[Address(RVA = "0xB873", Offset = "0xB873", VA = "0xB873", Slot = "7")]
		protected override BattleFinishAdPlacementController CreateController(BattleFinishAdPlacementEvents events, BattleFinishAdPlacementModel model, IAdController adController, AdEvents adEvents)
		{
			return null;
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB4")]
		[Address(RVA = "0xB874", Offset = "0xB874", VA = "0xB874", Slot = "8")]
		protected override BattleFinishAdPlacementModel CreateModel(UserData user, IAdPlacementData adPlacementData)
		{
			return null;
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB5")]
		[Address(RVA = "0xB875", Offset = "0xB875", VA = "0xB875", Slot = "9")]
		protected override BattleFinishAdPlacementEvents CreateEvents()
		{
			return null;
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DB6")]
		[Address(RVA = "0xB876", Offset = "0xB876", VA = "0xB876")]
		public static BattleFinishAdPlacementManager Create(IAdPlacementData adPlacementData, IArtifactDrop artifactDrop, ToastController toastController, IAdController adController, AdEvents adEvents, UserData user)
		{
			return null;
		}

		// Token: 0x04003969 RID: 14697
		[Token(Token = "0x4003969")]
		[FieldOffset(Offset = "0x24")]
		private readonly IArtifactDrop _artifactDrop;

		// Token: 0x0400396A RID: 14698
		[Token(Token = "0x400396A")]
		[FieldOffset(Offset = "0x28")]
		private readonly ToastController _toastController;
	}
}

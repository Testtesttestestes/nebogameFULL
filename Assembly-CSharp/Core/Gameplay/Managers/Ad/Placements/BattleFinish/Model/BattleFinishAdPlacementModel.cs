using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Placements.Base.Model;
using Gameplay.ArtifactDrop.Control;
using Il2CppDummyDll;
using UI.Toast;

namespace Core.Gameplay.Managers.Ad.Placements.BattleFinish.Model
{
	// Token: 0x02001214 RID: 4628
	[Token(Token = "0x2001214")]
	public class BattleFinishAdPlacementModel : AbstractAdPlacementModel
	{
		// Token: 0x06006DB7 RID: 28087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB7")]
		[Address(RVA = "0xB877", Offset = "0xB877", VA = "0xB877")]
		public BattleFinishAdPlacementModel(UserData user, IAdPlacementData placementData, IArtifactDrop artifactDrop, ToastController toastController)
		{
		}

		// Token: 0x0400396B RID: 14699
		[Token(Token = "0x400396B")]
		[FieldOffset(Offset = "0x10")]
		public readonly IArtifactDrop ArtifactDrop;

		// Token: 0x0400396C RID: 14700
		[Token(Token = "0x400396C")]
		[FieldOffset(Offset = "0x14")]
		public readonly ToastController ToastController;
	}
}

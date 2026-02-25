using System;
using Core.Data;
using Gameplay.Isles.Base.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.Isles.Clan.View;
using Il2CppDummyDll;

namespace Gameplay.Isles.Clan.Controller
{
	// Token: 0x02000CF7 RID: 3319
	[Token(Token = "0x2000CF7")]
	public class ClanIsleViewMediator : BaseIsleViewMediator<ClanIsleController, ClanIsleView, ClanIsleModel, ClanIsleEvents>
	{
		// Token: 0x060050D3 RID: 20691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D3")]
		[Address(RVA = "0x9EE2", Offset = "0x9EE2", VA = "0x9EE2", Slot = "22")]
		protected override void HandleBuildingClick(uint type)
		{
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D4")]
		[Address(RVA = "0x9EE3", Offset = "0x9EE3", VA = "0x9EE3", Slot = "25")]
		protected override void ValidateBuildingAvailability()
		{
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D5")]
		[Address(RVA = "0x9EE4", Offset = "0x9EE4", VA = "0x9EE4", Slot = "21")]
		protected override void HandleClickBg()
		{
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x0000EC40 File Offset: 0x0000CE40
		[Token(Token = "0x60050D6")]
		[Address(RVA = "0x9EE5", Offset = "0x9EE5", VA = "0x9EE5", Slot = "24")]
		protected override bool GetBgInteractable()
		{
			return default(bool);
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050D7")]
		[Address(RVA = "0x9EE6", Offset = "0x9EE6", VA = "0x9EE6", Slot = "27")]
		protected override string GetBgAssetId()
		{
			return null;
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D8")]
		[Address(RVA = "0x9EE7", Offset = "0x9EE7", VA = "0x9EE7")]
		public ClanIsleViewMediator(ClanIsleModel model, ClanIsleEvents events, ClanIsleController controller)
		{
		}

		// Token: 0x17001056 RID: 4182
		// (set) Token: 0x060050D9 RID: 20697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001056")]
		public override ClanIsleView View
		{
			[Token(Token = "0x60050D9")]
			[Address(RVA = "0x9EE8", Offset = "0x9EE8", VA = "0x9EE8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DA")]
		[Address(RVA = "0x9EE9", Offset = "0x9EE9", VA = "0x9EE9")]
		private void ColossusClickedEventHandler(ColossusBattleData data)
		{
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x9EEA", Offset = "0x9EEA", VA = "0x9EEA")]
		private void HandleColossusView()
		{
		}
	}
}

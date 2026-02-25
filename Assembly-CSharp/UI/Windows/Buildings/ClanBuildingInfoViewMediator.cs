using System;
using Gameplay.Isles.Clan.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace UI.Windows.Buildings
{
	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x20002B3")]
	public class ClanBuildingInfoViewMediator : AbstractViewMediator<ClanIsleModel, ClanIsleEvents, ClanIsleController, ClanBuildingInfoView>
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700025A")]
		private BaseBuildingData _buildingData
		{
			[Token(Token = "0x600103D")]
			[Address(RVA = "0x6247", Offset = "0x6247", VA = "0x6247")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103E")]
		[Address(RVA = "0x6248", Offset = "0x6248", VA = "0x6248")]
		public ClanBuildingInfoViewMediator(uint buildingTypeId, ClanIsleModel model, ClanIsleEvents events, ClanIsleController controller)
		{
		}

		// Token: 0x1700025B RID: 603
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025B")]
		public override ClanBuildingInfoView View
		{
			[Token(Token = "0x600103F")]
			[Address(RVA = "0x6249", Offset = "0x6249", VA = "0x6249", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700025C RID: 604
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025C")]
		public override ClanIsleEvents Events
		{
			[Token(Token = "0x6001040")]
			[Address(RVA = "0x624A", Offset = "0x624A", VA = "0x624A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001041")]
		[Address(RVA = "0x624B", Offset = "0x624B", VA = "0x624B")]
		private void BuildingStateChangedEventHandler(uint buildingTypeId)
		{
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001042")]
		[Address(RVA = "0x624C", Offset = "0x624C", VA = "0x624C")]
		private void ViewOnRequestCancelBuildEvent()
		{
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001043")]
		[Address(RVA = "0x624D", Offset = "0x624D", VA = "0x624D")]
		private void ViewOnRequestAccelerateBuildEvent()
		{
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001044")]
		[Address(RVA = "0x624E", Offset = "0x624E", VA = "0x624E")]
		private void ViewOnRequestStartBuildEvent()
		{
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001045")]
		[Address(RVA = "0x624F", Offset = "0x624F", VA = "0x624F")]
		private void BuildingStateChanged(uint buildingTypeId)
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x6250", Offset = "0x6250", VA = "0x6250")]
		private void UpdateView()
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x6251", Offset = "0x6251", VA = "0x6251")]
		private DialogWindow ShowConfirmCancelBuildWindow(BaseBuildingData buildingData)
		{
			return null;
		}

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x18")]
		private uint _buildingTypeId;
	}
}

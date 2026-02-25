using System;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Buildings.Ziggurat.View;
using Gameplay.Isles.Clan.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using UI;

namespace Gameplay.Clans.Ziggurat.Controller
{
	// Token: 0x02000AA9 RID: 2729
	[Token(Token = "0x2000AA9")]
	public class ZigguratViewMediator : AbstractViewMediator<ClanIsleModel, ClanIsleEvents, ClanIsleController, ZigguratWindow>
	{
		// Token: 0x060041DB RID: 16859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DB")]
		[Address(RVA = "0x908F", Offset = "0x908F", VA = "0x908F")]
		public ZigguratViewMediator(ClanIsleModel model, ClanIsleEvents events, ClanIsleController controller)
		{
		}

		// Token: 0x17000CF6 RID: 3318
		// (set) Token: 0x060041DC RID: 16860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF6")]
		public override ZigguratWindow View
		{
			[Token(Token = "0x60041DC")]
			[Address(RVA = "0x9090", Offset = "0x9090", VA = "0x9090", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x9091", Offset = "0x9091", VA = "0x9091")]
		private void ResetView()
		{
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DE")]
		[Address(RVA = "0x9092", Offset = "0x9092", VA = "0x9092")]
		private void SetupView()
		{
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DF")]
		[Address(RVA = "0x9093", Offset = "0x9093", VA = "0x9093")]
		private void ClansServiceOnClanUnregisteredEvent(ProtoUnregisterClanAns ans)
		{
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E0")]
		[Address(RVA = "0x9094", Offset = "0x9094", VA = "0x9094")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E1")]
		[Address(RVA = "0x9095", Offset = "0x9095", VA = "0x9095")]
		private void RepairButtonClickedEventHandler()
		{
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E2")]
		[Address(RVA = "0x9096", Offset = "0x9096", VA = "0x9096")]
		private void InClanButtonClickedEventHandler(IndexButtonBasic _)
		{
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E3")]
		[Address(RVA = "0x9097", Offset = "0x9097", VA = "0x9097")]
		private void ItemOnClickedEvent(BaseBuildingData buildingData)
		{
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E4")]
		[Address(RVA = "0x9098", Offset = "0x9098", VA = "0x9098")]
		private void ItemOnActionButtonClickedEvent(BaseBuildingData clanBuildingData)
		{
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E5")]
		[Address(RVA = "0x9099", Offset = "0x9099", VA = "0x9099")]
		private void HandleZigguratState()
		{
		}

		// Token: 0x17000CF7 RID: 3319
		// (set) Token: 0x060041E6 RID: 16870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF7")]
		public override ClanIsleEvents Events
		{
			[Token(Token = "0x60041E6")]
			[Address(RVA = "0x909A", Offset = "0x909A", VA = "0x909A", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E7")]
		[Address(RVA = "0x909B", Offset = "0x909B", VA = "0x909B")]
		private void IsleInformationChangedEventHandler()
		{
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E8")]
		[Address(RVA = "0x909C", Offset = "0x909C", VA = "0x909C")]
		private void BuildingStateChangedEventHandler(uint buildingType)
		{
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E9")]
		[Address(RVA = "0x909D", Offset = "0x909D", VA = "0x909D")]
		[CompilerGenerated]
		private void <HandleZigguratState>g__HandleTitledList|11_0()
		{
		}
	}
}

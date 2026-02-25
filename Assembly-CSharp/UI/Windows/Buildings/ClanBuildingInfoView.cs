using System;
using Core.Data;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	public class ClanBuildingInfoView : BaseBuildingInfoView<ClanIsle>
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000259")]
		protected override UserData Owner
		{
			[Token(Token = "0x6001039")]
			[Address(RVA = "0x6243", Offset = "0x6243", VA = "0x6243", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103A")]
		[Address(RVA = "0x6244", Offset = "0x6244", VA = "0x6244", Slot = "6")]
		public override void OnInit(ClanIsle isle, uint buildingTypeId)
		{
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103B")]
		[Address(RVA = "0x6245", Offset = "0x6245", VA = "0x6245", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x6246", Offset = "0x6246", VA = "0x6246")]
		public ClanBuildingInfoView()
		{
		}

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x40")]
		private ClanBuildingInfoViewMediator _mediator;
	}
}

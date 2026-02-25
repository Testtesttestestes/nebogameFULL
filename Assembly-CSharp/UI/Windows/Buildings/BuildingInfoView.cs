using System;
using Core.Data;
using Gameplay.Isles.User;
using Il2CppDummyDll;

namespace UI.Windows.Buildings
{
	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	public class BuildingInfoView : BaseBuildingInfoView<UserIsle>
	{
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000248")]
		protected override UserData Owner
		{
			[Token(Token = "0x600100C")]
			[Address(RVA = "0x6216", Offset = "0x6216", VA = "0x6216", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x6217", Offset = "0x6217", VA = "0x6217", Slot = "6")]
		public override void OnInit(UserIsle isle, uint buildingTypeId)
		{
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x6218", Offset = "0x6218", VA = "0x6218", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x6219", Offset = "0x6219", VA = "0x6219")]
		public BuildingInfoView()
		{
		}

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x40")]
		private BuildingInfoViewMediator _mediator;
	}
}

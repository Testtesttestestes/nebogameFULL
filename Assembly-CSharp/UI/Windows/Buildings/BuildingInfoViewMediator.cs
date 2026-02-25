using System;
using Gameplay.Isles.User.Controller;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace UI.Windows.Buildings
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	public class BuildingInfoViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, BuildingInfoView>
	{
		// Token: 0x06001010 RID: 4112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001010")]
		[Address(RVA = "0x621A", Offset = "0x621A", VA = "0x621A")]
		public BuildingInfoViewMediator(uint buildingTypeId, UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x17000249 RID: 585
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000249")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6001011")]
			[Address(RVA = "0x621B", Offset = "0x621B", VA = "0x621B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x621C", Offset = "0x621C", VA = "0x621C")]
		private void BuildingStateChanged(uint buildingTypeId)
		{
		}

		// Token: 0x1700024A RID: 586
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024A")]
		public override BuildingInfoView View
		{
			[Token(Token = "0x6001013")]
			[Address(RVA = "0x621D", Offset = "0x621D", VA = "0x621D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x621E", Offset = "0x621E", VA = "0x621E")]
		private void UpdateView()
		{
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x621F", Offset = "0x621F", VA = "0x621F")]
		private void ViewOnRequestCancelBuildEvent()
		{
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x6220", Offset = "0x6220", VA = "0x6220")]
		private void ViewOnRequestAccelerateBuildEvent()
		{
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x6221", Offset = "0x6221", VA = "0x6221")]
		private void ViewOnRequestStartBuildEvent()
		{
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x6222", Offset = "0x6222", VA = "0x6222")]
		private DialogWindow ShowConfirmCancelBuildWindow(BaseBuildingData buildingData)
		{
			return null;
		}

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x18")]
		private uint _buildingTypeId;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x1C")]
		private BaseBuildingData _buildingData;
	}
}

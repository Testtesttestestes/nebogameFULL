using System;
using Gameplay.Isles.User.Controller;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Tree.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tree.Control
{
	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	public class TreeViewMediator2 : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, TreeView2>
	{
		// Token: 0x06001BB7 RID: 7095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB7")]
		[Address(RVA = "0x6D36", Offset = "0x6D36", VA = "0x6D36")]
		public TreeViewMediator2(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170004D7 RID: 1239
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D7")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6001BB8")]
			[Address(RVA = "0x6D37", Offset = "0x6D37", VA = "0x6D37", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x6D38", Offset = "0x6D38", VA = "0x6D38")]
		private void BuildingStateChangedEvent(uint buildingType)
		{
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x6D39", Offset = "0x6D39", VA = "0x6D39")]
		private void RenderTreeBigView()
		{
		}

		// Token: 0x170004D8 RID: 1240
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004D8")]
		public override TreeView2 View
		{
			[Token(Token = "0x6001BBB")]
			[Address(RVA = "0x6D3A", Offset = "0x6D3A", VA = "0x6D3A", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x6D3B", Offset = "0x6D3B", VA = "0x6D3B")]
		private void ResetView()
		{
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x6D3C", Offset = "0x6D3C", VA = "0x6D3C")]
		private void SetupView()
		{
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x6D3D", Offset = "0x6D3D", VA = "0x6D3D")]
		private void ItemOnClickedEvent(BaseBuildingData buildingData)
		{
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x6D3E", Offset = "0x6D3E", VA = "0x6D3E")]
		private void ItemOnActionButtonClickedEvent(BaseBuildingData userBuildingData)
		{
		}
	}
}

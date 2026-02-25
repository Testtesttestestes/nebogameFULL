using System;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D30 RID: 3376
	[Token(Token = "0x2000D30")]
	public class IsleAccountMarkersViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleAccountMarkersLayerView>
	{
		// Token: 0x06005295 RID: 21141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005295")]
		[Address(RVA = "0xA06B", Offset = "0xA06B", VA = "0xA06B")]
		public IsleAccountMarkersViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010D8 RID: 4312
		// (set) Token: 0x06005296 RID: 21142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D8")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6005296")]
			[Address(RVA = "0xA06C", Offset = "0xA06C", VA = "0xA06C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (set) Token: 0x06005297 RID: 21143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D9")]
		public override IsleAccountMarkersLayerView View
		{
			[Token(Token = "0x6005297")]
			[Address(RVA = "0xA06D", Offset = "0xA06D", VA = "0xA06D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005298")]
		[Address(RVA = "0xA06E", Offset = "0xA06E", VA = "0xA06E")]
		private void HandleAccountMarkersChangedEvent()
		{
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005299")]
		[Address(RVA = "0xA06F", Offset = "0xA06F", VA = "0xA06F")]
		private void SetupView()
		{
		}
	}
}

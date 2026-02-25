using System;
using CloudsFly.Movement;
using Gameplay.Isles.Base.Controller;
using Gameplay.Isles.Base.Events;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D3F RID: 3391
	[Token(Token = "0x2000D3F")]
	public class UserIsleViewMediator : BaseIsleViewMediator<UserIsleController, UserIsleView, UserIsleModel, UserIsleEvents>
	{
		// Token: 0x0600530C RID: 21260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600530C")]
		[Address(RVA = "0xA0E1", Offset = "0xA0E1", VA = "0xA0E1")]
		public UserIsleViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		}

		// Token: 0x170010E7 RID: 4327
		// (set) Token: 0x0600530D RID: 21261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E7")]
		public override UserIsleView View
		{
			[Token(Token = "0x600530D")]
			[Address(RVA = "0xA0E2", Offset = "0xA0E2", VA = "0xA0E2", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (set) Token: 0x0600530E RID: 21262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010E8")]
		public override BaseIsleEvents Events
		{
			[Token(Token = "0x600530E")]
			[Address(RVA = "0xA0E3", Offset = "0xA0E3", VA = "0xA0E3", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600530F")]
		[Address(RVA = "0xA0E4", Offset = "0xA0E4", VA = "0xA0E4")]
		private void IsleViewChangedEventHandler(uint type)
		{
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005310")]
		[Address(RVA = "0xA0E5", Offset = "0xA0E5", VA = "0xA0E5", Slot = "22")]
		protected override void HandleBuildingClick(uint type)
		{
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005311")]
		[Address(RVA = "0xA0E6", Offset = "0xA0E6", VA = "0xA0E6")]
		private void HandleMovCompleteEvent(WorldMovementTypes worldMovementTypes)
		{
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005312")]
		[Address(RVA = "0xA0E7", Offset = "0xA0E7", VA = "0xA0E7", Slot = "21")]
		protected override void HandleClickBg()
		{
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005313")]
		[Address(RVA = "0xA0E8", Offset = "0xA0E8", VA = "0xA0E8", Slot = "25")]
		protected override void ValidateBuildingAvailability()
		{
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005314")]
		[Address(RVA = "0xA0E9", Offset = "0xA0E9", VA = "0xA0E9", Slot = "27")]
		protected override string GetBgAssetId()
		{
			return null;
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005315")]
		[Address(RVA = "0xA0EA", Offset = "0xA0EA", VA = "0xA0EA", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04002D08 RID: 11528
		[Token(Token = "0x4002D08")]
		[FieldOffset(Offset = "0x18")]
		private IsleBonusesViewMediator _isleBonusesViewMediator;

		// Token: 0x04002D09 RID: 11529
		[Token(Token = "0x4002D09")]
		[FieldOffset(Offset = "0x1C")]
		private IsleDecorationsViewMediator _isleDecorationsViewMediator;

		// Token: 0x04002D0A RID: 11530
		[Token(Token = "0x4002D0A")]
		[FieldOffset(Offset = "0x20")]
		private IsleAnimationViewMediator _isleAnimationViewMediator;

		// Token: 0x04002D0B RID: 11531
		[Token(Token = "0x4002D0B")]
		[FieldOffset(Offset = "0x24")]
		private IsleAccountMarkersViewMediator _isleAccountMarkersViewMediator;
	}
}

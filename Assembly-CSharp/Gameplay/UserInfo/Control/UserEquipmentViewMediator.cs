using System;
using Core.Data;
using Gameplay.Antiq;
using Gameplay.UserInfo.Model;
using Gameplay.UserInfo.View.Equipment;
using Il2CppDummyDll;
using MVC;
using UnityEngine.EventSystems;

namespace Gameplay.UserInfo.Control
{
	// Token: 0x02000415 RID: 1045
	[Token(Token = "0x2000415")]
	public class UserEquipmentViewMediator : AbstractCozyViewMediator<UserInfoModel, UserInfoEvents, UserInfoController, UserEquipmentView>
	{
		// Token: 0x0600187D RID: 6269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600187D")]
		[Address(RVA = "0x6A1D", Offset = "0x6A1D", VA = "0x6A1D", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600187E")]
		[Address(RVA = "0x6A1E", Offset = "0x6A1E", VA = "0x6A1E")]
		public UserEquipmentViewMediator(UserEquipmentView view, UserInfoModel model, UserInfoEvents events, UserInfoController controller)
		{
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x6A1F", Offset = "0x6A1F", VA = "0x6A1F", Slot = "21")]
		protected override void ResetEvents(UserInfoEvents events)
		{
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001880")]
		[Address(RVA = "0x6A20", Offset = "0x6A20", VA = "0x6A20", Slot = "22")]
		protected override void SetupEvents(UserInfoEvents events)
		{
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001881")]
		[Address(RVA = "0x6A21", Offset = "0x6A21", VA = "0x6A21", Slot = "23")]
		protected override void ResetView(UserEquipmentView view)
		{
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001882")]
		[Address(RVA = "0x6A22", Offset = "0x6A22", VA = "0x6A22", Slot = "24")]
		protected override void SetupView(UserEquipmentView view)
		{
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001883")]
		[Address(RVA = "0x6A23", Offset = "0x6A23", VA = "0x6A23")]
		private void HandleUserTriggersChangedEvent(UserData user)
		{
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001884")]
		[Address(RVA = "0x6A24", Offset = "0x6A24", VA = "0x6A24")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001885")]
		[Address(RVA = "0x6A25", Offset = "0x6A25", VA = "0x6A25")]
		private void ValidateExtraSlots(UserData user)
		{
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x6A26", Offset = "0x6A26", VA = "0x6A26")]
		private void HandleUserEquipmentChangedEvent()
		{
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001887")]
		[Address(RVA = "0x6A27", Offset = "0x6A27", VA = "0x6A27")]
		private void EquipmentViewOnSlotClickedEvent(UserEquipmentSlotConfig slotConfig)
		{
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001888")]
		[Address(RVA = "0x6A28", Offset = "0x6A28", VA = "0x6A28")]
		private void HandleExtraSlotsStubClickEvent(PointerEventData data)
		{
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001889")]
		[Address(RVA = "0x6A29", Offset = "0x6A29", VA = "0x6A29")]
		private void ShowAntiqGroupReview(int triggerId)
		{
		}

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x18")]
		private Launch _antiqLaunch;
	}
}

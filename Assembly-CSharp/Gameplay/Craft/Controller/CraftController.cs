using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Craft.Events;
using Gameplay.Craft.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Craft;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.Craft.Controller
{
	// Token: 0x020008C3 RID: 2243
	[Token(Token = "0x20008C3")]
	public class CraftController : AbstractController<CraftModel, Gameplay.Craft.Events.CraftEvents>
	{
		// Token: 0x060034B2 RID: 13490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B2")]
		[Address(RVA = "0x84DB", Offset = "0x84DB", VA = "0x84DB")]
		public CraftController(CraftModel model, Gameplay.Craft.Events.CraftEvents events)
		{
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B3")]
		[Address(RVA = "0x84DC", Offset = "0x84DC", VA = "0x84DC")]
		public void TakeArtifacts(params ulong[] artifactIds)
		{
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x84DD", Offset = "0x84DD", VA = "0x84DD")]
		private void RequestTakeArtifacts(ulong[] artifactIds)
		{
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x84DE", Offset = "0x84DE", VA = "0x84DE")]
		private void TakeArtifactResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x84DF", Offset = "0x84DF", VA = "0x84DF")]
		public void SellArtifacts(params ArtifactData[] artifacts)
		{
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x84E0", Offset = "0x84E0", VA = "0x84E0")]
		private void RequestSellArtifacts(params ArtifactData[] artifacts)
		{
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x84E1", Offset = "0x84E1", VA = "0x84E1")]
		private void SellArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x84E2", Offset = "0x84E2", VA = "0x84E2")]
		public void GetUserProfessions()
		{
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x84E3", Offset = "0x84E3", VA = "0x84E3")]
		private void GetUserProfessionsResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x84E4", Offset = "0x84E4", VA = "0x84E4")]
		public void GetUserCraftSlotsInfo()
		{
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BC")]
		[Address(RVA = "0x84E5", Offset = "0x84E5", VA = "0x84E5")]
		private void GetUserCraftSlotsInfoResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BD")]
		[Address(RVA = "0x84E6", Offset = "0x84E6", VA = "0x84E6")]
		public void OpenCraftSlot(uint slotId, Action callback)
		{
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BE")]
		[Address(RVA = "0x84E7", Offset = "0x84E7", VA = "0x84E7")]
		private void OpenCraftSlotResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BF")]
		[Address(RVA = "0x84E8", Offset = "0x84E8", VA = "0x84E8")]
		public void StartCraft(uint schemeId, uint quantity)
		{
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x84E9", Offset = "0x84E9", VA = "0x84E9")]
		private void StartCraftResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x84EA", Offset = "0x84EA", VA = "0x84EA")]
		public void CancelCraft(uint craftSlotId)
		{
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x84EB", Offset = "0x84EB", VA = "0x84EB")]
		private void CancelCraftResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x84EC", Offset = "0x84EC", VA = "0x84EC")]
		public void SpeedupCraft(uint craftSlotId)
		{
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x84ED", Offset = "0x84ED", VA = "0x84ED")]
		private void SpeedupCraftResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x84EE", Offset = "0x84EE", VA = "0x84EE")]
		public void GetUserSchemes()
		{
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x84EF", Offset = "0x84EF", VA = "0x84EF")]
		private void GetUserSchemesResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x84F0", Offset = "0x84F0", VA = "0x84F0")]
		public void RemoveUserScheme(UserScheme scheme)
		{
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C8")]
		[Address(RVA = "0x84F1", Offset = "0x84F1", VA = "0x84F1")]
		private void RemoveUserSchemeResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x84F2", Offset = "0x84F2", VA = "0x84F2")]
		private void ProfessionChangedEventHandler(UserProfession profession)
		{
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x84F3", Offset = "0x84F3", VA = "0x84F3")]
		private void SchemeChangedEventHandler(UserScheme scheme)
		{
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x84F4", Offset = "0x84F4", VA = "0x84F4")]
		private void CraftSlotsChangedEventHandler(ProtoCraftSlotsChangedEvt evt)
		{
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x84F5", Offset = "0x84F5", VA = "0x84F5")]
		public void Subscribe()
		{
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x84F6", Offset = "0x84F6", VA = "0x84F6")]
		public void Unsubscribe()
		{
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x84F7", Offset = "0x84F7", VA = "0x84F7")]
		private DialogWindow ShowSlotExpiredWindow()
		{
			return null;
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x84F8", Offset = "0x84F8", VA = "0x84F8")]
		private void HandleAccountChangedEventService(AccountInfo info)
		{
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0x84F9", Offset = "0x84F9", VA = "0x84F9", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x84FA", Offset = "0x84FA", VA = "0x84FA", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x84FB", Offset = "0x84FB", VA = "0x84FB")]
		private void UserBalanceChangedEventHandler(ResourceSet balance, ResourceSet delta)
		{
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x84FC", Offset = "0x84FC", VA = "0x84FC")]
		private void SetCraftSlots(IList<UserCraftSlotInfo> slots)
		{
		}

		// Token: 0x04001CE3 RID: 7395
		[Token(Token = "0x4001CE3")]
		[FieldOffset(Offset = "0x18")]
		private CraftService _craftService;

		// Token: 0x04001CE4 RID: 7396
		[Token(Token = "0x4001CE4")]
		[FieldOffset(Offset = "0x1C")]
		private MainService _mainService;

		// Token: 0x04001CE5 RID: 7397
		[Token(Token = "0x4001CE5")]
		[FieldOffset(Offset = "0x20")]
		private bool _subscribed;
	}
}

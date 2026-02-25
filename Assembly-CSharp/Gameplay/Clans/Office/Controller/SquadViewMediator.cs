using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.SquadTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Clans;
using Protocol.Common;
using UI.Windows;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A79 RID: 2681
	[Token(Token = "0x2000A79")]
	public class SquadViewMediator : AbstractViewMediator<SquadModel, SquadEvents, SquadController, SquadView>, IHideableMediator
	{
		// Token: 0x06003FDB RID: 16347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0x8E95", Offset = "0x8E95", VA = "0x8E95")]
		public SquadViewMediator(SquadModel model, SquadEvents events, SquadController controller)
		{
		}

		// Token: 0x17000CAB RID: 3243
		// (set) Token: 0x06003FDC RID: 16348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAB")]
		public override SquadView View
		{
			[Token(Token = "0x6003FDC")]
			[Address(RVA = "0x8E96", Offset = "0x8E96", VA = "0x8E96", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0x8E97", Offset = "0x8E97", VA = "0x8E97")]
		private void Init()
		{
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0x8E98", Offset = "0x8E98", VA = "0x8E98")]
		private void RentButtonClickedEventHandler()
		{
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FDF")]
		[Address(RVA = "0x8E99", Offset = "0x8E99", VA = "0x8E99")]
		private void JoinButtonClickedEventHandler(MemberSlotView slot, SquadListElement squad)
		{
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE0")]
		[Address(RVA = "0x8E9A", Offset = "0x8E9A", VA = "0x8E9A")]
		private void ShowBuySlotDialogWindow(SquadListElement squad)
		{
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE1")]
		[Address(RVA = "0x8E9B", Offset = "0x8E9B", VA = "0x8E9B")]
		private void CrossButtonClickedEventHandler(MemberSlotView slot, SquadListElement squad)
		{
		}

		// Token: 0x17000CAC RID: 3244
		// (set) Token: 0x06003FE2 RID: 16354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAC")]
		public override SquadEvents Events
		{
			[Token(Token = "0x6003FE2")]
			[Address(RVA = "0x8E9C", Offset = "0x8E9C", VA = "0x8E9C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0x8E9D", Offset = "0x8E9D", VA = "0x8E9D")]
		private void UserLeftClanEventHandler(ProtoUserLeftClanEvt evt)
		{
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE4")]
		[Address(RVA = "0x8E9E", Offset = "0x8E9E", VA = "0x8E9E")]
		private void UpdateSeasonInfo()
		{
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE5")]
		[Address(RVA = "0x8E9F", Offset = "0x8E9F", VA = "0x8E9F")]
		private void InitEventHandler()
		{
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x8EA0", Offset = "0x8EA0", VA = "0x8EA0")]
		private void UpdateDollInfo()
		{
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE7")]
		[Address(RVA = "0x8EA1", Offset = "0x8EA1", VA = "0x8EA1")]
		private void SlotsChangedEventHandler()
		{
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE8")]
		[Address(RVA = "0x8EA2", Offset = "0x8EA2", VA = "0x8EA2")]
		private void PartyInfoRequestedEventHandler()
		{
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x8EA3", Offset = "0x8EA3", VA = "0x8EA3")]
		private void UpdateSquadInfo()
		{
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x8EA4", Offset = "0x8EA4", VA = "0x8EA4", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x8EA5", Offset = "0x8EA5", VA = "0x8EA5")]
		private DialogWindow ShowRentPartyDialogWindow(ResourceSet price)
		{
			return null;
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x8EA6", Offset = "0x8EA6", VA = "0x8EA6")]
		private DialogWindow ShowBuyPartySlotDialogWindow(uint partyId, ResourceSet price)
		{
			return null;
		}
	}
}

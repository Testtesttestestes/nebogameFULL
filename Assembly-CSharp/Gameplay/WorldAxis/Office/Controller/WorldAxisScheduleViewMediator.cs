using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E7 RID: 743
	[Token(Token = "0x20002E7")]
	public class WorldAxisScheduleViewMediator : AbstractViewMediator<WorldAxisOfficeModel, WorldAxisOfficeEvents, WorldAxisOfficeController, WorldAxisScheduleView>, IHideableMediator
	{
		// Token: 0x060011A8 RID: 4520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x63A5", Offset = "0x63A5", VA = "0x63A5")]
		public WorldAxisScheduleViewMediator(WorldAxisOfficeModel model, WorldAxisOfficeEvents events, WorldAxisOfficeController controller)
		{
		}

		// Token: 0x17000299 RID: 665
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000299")]
		public override WorldAxisScheduleView View
		{
			[Token(Token = "0x60011A9")]
			[Address(RVA = "0x63A6", Offset = "0x63A6", VA = "0x63A6", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x63A7", Offset = "0x63A7", VA = "0x63A7")]
		private void Init()
		{
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x63A8", Offset = "0x63A8", VA = "0x63A8")]
		private void HandleBottomGroup()
		{
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x63A9", Offset = "0x63A9", VA = "0x63A9")]
		private void EnterSquadButtonClickedEventHandler()
		{
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x63AA", Offset = "0x63AA", VA = "0x63AA")]
		private void ToWorldAxisButtonClickedEventHandler()
		{
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x63AB", Offset = "0x63AB", VA = "0x63AB")]
		private void ColossusInfoButtonClickedEventHandler()
		{
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x63AC", Offset = "0x63AC", VA = "0x63AC")]
		private void InjectCallback()
		{
		}

		// Token: 0x1700029A RID: 666
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029A")]
		public override WorldAxisOfficeEvents Events
		{
			[Token(Token = "0x60011B0")]
			[Address(RVA = "0x63AD", Offset = "0x63AD", VA = "0x63AD", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x63AE", Offset = "0x63AE", VA = "0x63AE")]
		private void UserClanStatusChangedEventHandler()
		{
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0x63AF", Offset = "0x63AF", VA = "0x63AF")]
		private void ScheduleChangedEventHandler()
		{
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0x63B0", Offset = "0x63B0", VA = "0x63B0")]
		private void ColossusRatingRequestedEventHandler()
		{
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B4")]
		[Address(RVA = "0x63B1", Offset = "0x63B1", VA = "0x63B1")]
		private void ListElementClickedEventHandler(ColossusBattleListElement element)
		{
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x63B2", Offset = "0x63B2", VA = "0x63B2")]
		private void Select(ColossusBattleListElement.ColossusBattleListElementArgs args)
		{
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B6")]
		[Address(RVA = "0x63B3", Offset = "0x63B3", VA = "0x63B3", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x18")]
		private ColossusBattleListElement.ColossusBattleListElementArgs _selectedArgs;
	}
}

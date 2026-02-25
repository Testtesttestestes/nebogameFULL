using System;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Gameplay.WorldAxis.ColossusInfo.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.WorldAxis.ColossusInfo.Controller.ColossusInfo
{
	// Token: 0x02000333 RID: 819
	[Token(Token = "0x2000333")]
	public class ColossusInfoViewMediator : AbstractViewMediator<ColossusInfoModel, ColossusInfoEvents, ColossusInfoController, ColossusInfoWindow>
	{
		// Token: 0x060012D0 RID: 4816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x64CA", Offset = "0x64CA", VA = "0x64CA")]
		public ColossusInfoViewMediator(ColossusInfoModel model, ColossusInfoEvents events, ColossusInfoController controller)
		{
		}

		// Token: 0x170002E9 RID: 745
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E9")]
		public override ColossusInfoWindow View
		{
			[Token(Token = "0x60012D1")]
			[Address(RVA = "0x64CB", Offset = "0x64CB", VA = "0x64CB", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x64CC", Offset = "0x64CC", VA = "0x64CC")]
		private void Init()
		{
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x64CD", Offset = "0x64CD", VA = "0x64CD")]
		private void DrawBattleStatus()
		{
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x64CE", Offset = "0x64CE", VA = "0x64CE")]
		private void CreateClanButtonClickedEventHandler()
		{
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x64CF", Offset = "0x64CF", VA = "0x64CF")]
		private void JoinSquadButtonClickedEventHandler()
		{
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x64D0", Offset = "0x64D0", VA = "0x64D0")]
		private void JoinSquadButtonClickedEventHandler(IndexButtonBasic btn)
		{
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x64D1", Offset = "0x64D1", VA = "0x64D1")]
		private void ClassButtonClickedEventHandler(IndexButtonBasic btn)
		{
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x64D2", Offset = "0x64D2", VA = "0x64D2")]
		private void AttackButtonClickedEventHandler()
		{
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x64D3", Offset = "0x64D3", VA = "0x64D3")]
		private void HandleActionButtons()
		{
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x64D4", Offset = "0x64D4", VA = "0x64D4")]
		private void TabBarChangedEventHandler()
		{
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x64D5", Offset = "0x64D5", VA = "0x64D5")]
		private void ShowTreasuryTab()
		{
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x64D6", Offset = "0x64D6", VA = "0x64D6")]
		private void CreateTreasuryMVC()
		{
		}

		// Token: 0x170002EA RID: 746
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002EA")]
		public override ColossusInfoEvents Events
		{
			[Token(Token = "0x60012DD")]
			[Address(RVA = "0x64D7", Offset = "0x64D7", VA = "0x64D7", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x64D8", Offset = "0x64D8", VA = "0x64D8")]
		private void ScheduleChangedEventHandler()
		{
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x64D9", Offset = "0x64D9", VA = "0x64D9")]
		private void PartyChangedEventHandler()
		{
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x64DA", Offset = "0x64DA", VA = "0x64DA")]
		private void ColossusRatingRequestedEventHandler()
		{
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x64DB", Offset = "0x64DB", VA = "0x64DB", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x18")]
		private ColossusTreasuryModel _treasuryModel;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x1C")]
		private ColossusTreasuryEvents _treasuryEvents;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x20")]
		private ColossusTreasuryController _treasuryController;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x24")]
		private ColossusTreasuryViewMediator _treasuryMediator;
	}
}

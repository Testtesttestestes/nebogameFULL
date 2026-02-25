using System;
using System.Collections;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model;
using Gameplay.Ad.BattleBonusesAd.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Ad.BattleBonusesAd.Controller
{
	// Token: 0x02000DBF RID: 3519
	[Token(Token = "0x2000DBF")]
	public class BattleBonusesAdMediator : AbstractViewMediator<BattleBonusesAdModel, BattleBonusesAdEvents, BattleBonusesAdController, BattleBonusesAdEntryView>
	{
		// Token: 0x060055D6 RID: 21974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D6")]
		[Address(RVA = "0xA376", Offset = "0xA376", VA = "0xA376", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D7")]
		[Address(RVA = "0xA377", Offset = "0xA377", VA = "0xA377")]
		public BattleBonusesAdMediator(BattleBonusesAdModel model, BattleBonusesAdEvents events, BattleBonusesAdController controller)
		{
		}

		// Token: 0x17001173 RID: 4467
		// (set) Token: 0x060055D8 RID: 21976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001173")]
		public override BattleBonusesAdEntryView View
		{
			[Token(Token = "0x60055D8")]
			[Address(RVA = "0xA378", Offset = "0xA378", VA = "0xA378", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17001174 RID: 4468
		// (set) Token: 0x060055D9 RID: 21977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001174")]
		public override BattleBonusesAdEvents Events
		{
			[Token(Token = "0x60055D9")]
			[Address(RVA = "0xA379", Offset = "0xA379", VA = "0xA379", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DA")]
		[Address(RVA = "0xA37A", Offset = "0xA37A", VA = "0xA37A")]
		private void BonusAchievedChangedEvent()
		{
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DB")]
		[Address(RVA = "0xA37B", Offset = "0xA37B", VA = "0xA37B")]
		private void AdAvailabilityPossiblyChangedEvent()
		{
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DC")]
		[Address(RVA = "0xA37C", Offset = "0xA37C", VA = "0xA37C")]
		private void ButtonClickHandler()
		{
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DD")]
		[Address(RVA = "0xA37D", Offset = "0xA37D", VA = "0xA37D")]
		private void ShowWatchWindow()
		{
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DE")]
		[Address(RVA = "0xA37E", Offset = "0xA37E", VA = "0xA37E")]
		private void ShowBonusInfoWindow()
		{
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DF")]
		[Address(RVA = "0xA37F", Offset = "0xA37F", VA = "0xA37F")]
		private void ValidateState()
		{
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E0")]
		[Address(RVA = "0xA380", Offset = "0xA380", VA = "0xA380")]
		private void StopValidateStateRoutine()
		{
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E1")]
		[Address(RVA = "0xA381", Offset = "0xA381", VA = "0xA381")]
		private void RunValidateStateRoutine()
		{
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60055E2")]
		[Address(RVA = "0xA382", Offset = "0xA382", VA = "0xA382")]
		private IEnumerator ValidateStateRoutine()
		{
			return null;
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E3")]
		[Address(RVA = "0xA383", Offset = "0xA383", VA = "0xA383")]
		private void StopButtonClickRoutine()
		{
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055E4")]
		[Address(RVA = "0xA384", Offset = "0xA384", VA = "0xA384")]
		private void RunButtonClickRoutine()
		{
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60055E5")]
		[Address(RVA = "0xA385", Offset = "0xA385", VA = "0xA385")]
		private IEnumerator HandleButtonClickedRoutine()
		{
			return null;
		}

		// Token: 0x04002E86 RID: 11910
		[Token(Token = "0x4002E86")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine _buttonClickedRoutine;

		// Token: 0x04002E87 RID: 11911
		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _validateStateRoutine;

		// Token: 0x04002E88 RID: 11912
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x20")]
		private bool _adAvailable;
	}
}

using System;
using System.Collections;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Controller;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Events;
using Core.Gameplay.Managers.Ad.Placements.BankOptions.Model;
using Gameplay.Bank.Model;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C63 RID: 3171
	[Token(Token = "0x2000C63")]
	public class BankOptionAdPlacementViewMediator : AbstractViewMediator<BankOptionsAdPlacementModel, BankOptionsAdPlacementEvents, BankOptionsAdPlacementController, BankOptionAdPlacementView>
	{
		// Token: 0x06004D79 RID: 19833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D79")]
		[Address(RVA = "0x9BB1", Offset = "0x9BB1", VA = "0x9BB1")]
		public BankOptionAdPlacementViewMediator(BankOptionsAdPlacementModel model, BankOptionsAdPlacementEvents events, BankOptionsAdPlacementController controller, BankOptionData bankOptionData)
		{
		}

		// Token: 0x17000FAF RID: 4015
		// (set) Token: 0x06004D7A RID: 19834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAF")]
		public override BankOptionAdPlacementView View
		{
			[Token(Token = "0x6004D7A")]
			[Address(RVA = "0x9BB2", Offset = "0x9BB2", VA = "0x9BB2", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D7B")]
		[Address(RVA = "0x9BB3", Offset = "0x9BB3", VA = "0x9BB3")]
		private void WatchButtonClickedEventHandler()
		{
		}

		// Token: 0x17000FB0 RID: 4016
		// (set) Token: 0x06004D7C RID: 19836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FB0")]
		public override BankOptionsAdPlacementEvents Events
		{
			[Token(Token = "0x6004D7C")]
			[Address(RVA = "0x9BB4", Offset = "0x9BB4", VA = "0x9BB4", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D7D")]
		[Address(RVA = "0x9BB5", Offset = "0x9BB5", VA = "0x9BB5")]
		private void ValidateState()
		{
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004D7E")]
		[Address(RVA = "0x9BB6", Offset = "0x9BB6", VA = "0x9BB6")]
		private IEnumerator ValidateRoutine()
		{
			return null;
		}

		// Token: 0x04002A3D RID: 10813
		[Token(Token = "0x4002A3D")]
		[FieldOffset(Offset = "0x18")]
		private BankOptionData _bankOptionData;

		// Token: 0x04002A3E RID: 10814
		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x1C")]
		private bool _adAvailable;

		// Token: 0x04002A3F RID: 10815
		[Token(Token = "0x4002A3F")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine _validateRoutine;
	}
}

using System;
using Core.Data;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008BD RID: 2237
	[Token(Token = "0x20008BD")]
	public class ManufactureGroupView : MonoBehaviourWithStates<ManufactureGroupView.State>
	{
		// Token: 0x06003487 RID: 13447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x84B1", Offset = "0x84B1", VA = "0x84B1")]
		public void ShowEmptyState(long expirationTime)
		{
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003488")]
		[Address(RVA = "0x84B2", Offset = "0x84B2", VA = "0x84B2")]
		public void ShowDisabledState()
		{
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003489")]
		[Address(RVA = "0x84B3", Offset = "0x84B3", VA = "0x84B3")]
		public void ShowFilledState(long expirationTime)
		{
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348A")]
		[Address(RVA = "0x84B4", Offset = "0x84B4", VA = "0x84B4")]
		public void ShowDisabledFilledState()
		{
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348B")]
		[Address(RVA = "0x84B5", Offset = "0x84B5", VA = "0x84B5")]
		public void ResolveSlotState(UserData user, CraftSlotListElement element, long expirationTime)
		{
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348C")]
		[Address(RVA = "0x84B6", Offset = "0x84B6", VA = "0x84B6")]
		private void DisplayTimer(long expirationTime)
		{
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348D")]
		[Address(RVA = "0x84B7", Offset = "0x84B7", VA = "0x84B7")]
		public ManufactureGroupView()
		{
		}

		// Token: 0x04001CC0 RID: 7360
		[Token(Token = "0x4001CC0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x020008BE RID: 2238
		[Token(Token = "0x20008BE")]
		public enum State
		{
			// Token: 0x04001CC2 RID: 7362
			[Token(Token = "0x4001CC2")]
			UNKNOWN_STATE,
			// Token: 0x04001CC3 RID: 7363
			[Token(Token = "0x4001CC3")]
			EMPTY,
			// Token: 0x04001CC4 RID: 7364
			[Token(Token = "0x4001CC4")]
			DISABLED,
			// Token: 0x04001CC5 RID: 7365
			[Token(Token = "0x4001CC5")]
			FILLED,
			// Token: 0x04001CC6 RID: 7366
			[Token(Token = "0x4001CC6")]
			DISABLED_FILLED
		}
	}
}

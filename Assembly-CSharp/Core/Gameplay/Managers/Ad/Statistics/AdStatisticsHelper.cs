using System;
using System.Collections.Generic;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Statistics
{
	// Token: 0x020011F8 RID: 4600
	[Token(Token = "0x20011F8")]
	public class AdStatisticsHelper : IDisposable
	{
		// Token: 0x06006D42 RID: 27970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D42")]
		[Address(RVA = "0xB82A", Offset = "0xB82A", VA = "0xB82A")]
		public AdStatisticsHelper(AdManager adManager)
		{
		}

		// Token: 0x06006D43 RID: 27971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D43")]
		[Address(RVA = "0xB82B", Offset = "0xB82B", VA = "0xB82B")]
		private void AdRewardedEvent(AdTransaction transactionData)
		{
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D44")]
		[Address(RVA = "0xB82C", Offset = "0xB82C", VA = "0xB82C")]
		private void TransactionClosedEvent(string transactionId)
		{
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D45")]
		[Address(RVA = "0xB82D", Offset = "0xB82D", VA = "0xB82D")]
		private void TransactionCreatedEvent(AdTransaction transaction)
		{
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D46")]
		[Address(RVA = "0xB82E", Offset = "0xB82E", VA = "0xB82E", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0400392D RID: 14637
		[Token(Token = "0x400392D")]
		[FieldOffset(Offset = "0x8")]
		private AdManager _adManager;

		// Token: 0x0400392E RID: 14638
		[Token(Token = "0x400392E")]
		[FieldOffset(Offset = "0xC")]
		private AdEvents _events;

		// Token: 0x0400392F RID: 14639
		[Token(Token = "0x400392F")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, AdTransactionStatisticsInfo> _transactions;
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Services;
using Utils;
using Utils.Timers;

namespace Core.Gameplay.Managers.Ad.Placements
{
	// Token: 0x02001209 RID: 4617
	[Token(Token = "0x2001209")]
	public class AdPlacementData : IAdPlacementData, IDisposable
	{
		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06006D8E RID: 28046 RVA: 0x00014208 File Offset: 0x00012408
		[Token(Token = "0x17001645")]
		public uint AdPlacementId
		{
			[Token(Token = "0x6006D8E")]
			[Address(RVA = "0xB855", Offset = "0xB855", VA = "0xB855", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06006D8F RID: 28047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001646")]
		public string Name
		{
			[Token(Token = "0x6006D8F")]
			[Address(RVA = "0xB856", Offset = "0xB856", VA = "0xB856", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002DB RID: 731
		// (add) Token: 0x06006D90 RID: 28048 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006D91 RID: 28049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002DB")]
		public event Action<IAdPlacementData> BackTimerCompleteEvent
		{
			[Token(Token = "0x6006D90")]
			[Address(RVA = "0xB857", Offset = "0xB857", VA = "0xB857", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006D91")]
			[Address(RVA = "0xB858", Offset = "0xB858", VA = "0xB858", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06006D92 RID: 28050 RVA: 0x00014220 File Offset: 0x00012420
		[Token(Token = "0x17001647")]
		public bool IsAvailableByAppServer
		{
			[Token(Token = "0x6006D92")]
			[Address(RVA = "0xB859", Offset = "0xB859", VA = "0xB859", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D93")]
		[Address(RVA = "0x2246", Offset = "0x2246", VA = "0x2246")]
		public AdPlacementData(uint adPlacementId)
		{
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006D94")]
		[Address(RVA = "0xB85A", Offset = "0xB85A", VA = "0xB85A", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D95")]
		[Address(RVA = "0xB85B", Offset = "0xB85B", VA = "0xB85B", Slot = "9")]
		private void SetInfo(AdPlacementInfo value)
		{
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D96")]
		[Address(RVA = "0xB85C", Offset = "0xB85C", VA = "0xB85C")]
		private void SetupTimer()
		{
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D97")]
		[Address(RVA = "0xB85D", Offset = "0xB85D", VA = "0xB85D")]
		private void OnTimerComplete()
		{
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D98")]
		[Address(RVA = "0xB85E", Offset = "0xB85E", VA = "0xB85E", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x04003965 RID: 14693
		[Token(Token = "0x4003965")]
		[FieldOffset(Offset = "0x10")]
		private BackTime _backTime;

		// Token: 0x04003966 RID: 14694
		[Token(Token = "0x4003966")]
		[FieldOffset(Offset = "0x14")]
		private DelayedCall _delayedCall;

		// Token: 0x04003967 RID: 14695
		[Token(Token = "0x4003967")]
		[FieldOffset(Offset = "0x18")]
		private AdPlacementInfo _info;
	}
}

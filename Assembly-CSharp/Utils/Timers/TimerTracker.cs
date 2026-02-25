using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils.Timers
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public class TimerTracker : IDisposable
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000E")]
		public event Action TimerExpiredEvent
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x578F", Offset = "0x578F", VA = "0x578F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x5790", Offset = "0x5790", VA = "0x5790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x5791", Offset = "0x5791", VA = "0x5791")]
		public TimerTracker()
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1E0B", Offset = "0x1E0B", VA = "0x1E0B")]
		public bool TryGetValue(uint id, out BackTime value)
		{
			return default(bool);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1CA6", Offset = "0x1CA6", VA = "0x1CA6")]
		public void UpdateOrCreate(uint id, BackTime value)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x5792", Offset = "0x5792", VA = "0x5792")]
		public bool TryRun()
		{
			return default(bool);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x5793", Offset = "0x5793", VA = "0x5793")]
		private void StartTracking()
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x5794", Offset = "0x5794", VA = "0x5794")]
		private void ClearExpiredTimers()
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x5795", Offset = "0x5795", VA = "0x5795", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<uint, TimerTracker.TimerWrapper> _timers;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<TimerTracker.TimerWrapper> _timersList;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x14")]
		private DelayedCall _delayedCall;

		// Token: 0x02000061 RID: 97
		[Token(Token = "0x2000061")]
		private class TimerWrapper
		{
			// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x5796", Offset = "0x5796", VA = "0x5796")]
			public TimerWrapper(uint id, BackTime backtime)
			{
			}

			// Token: 0x04000167 RID: 359
			[Token(Token = "0x4000167")]
			[FieldOffset(Offset = "0x8")]
			public readonly uint Id;

			// Token: 0x04000168 RID: 360
			[Token(Token = "0x4000168")]
			[FieldOffset(Offset = "0xC")]
			public BackTime Backtime;
		}
	}
}

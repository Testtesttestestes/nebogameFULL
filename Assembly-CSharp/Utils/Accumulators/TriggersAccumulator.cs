using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;

namespace Utils.Accumulators
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public class TriggersAccumulator : AccumulatorBase<int, TriggerValue>
	{
		// Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x57BC", Offset = "0x57BC", VA = "0x57BC")]
		public TriggersAccumulator(float seconds)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x57BD", Offset = "0x57BD", VA = "0x57BD", Slot = "8")]
		public override bool TryGetValue(int triggerId, out TriggerValue trigger)
		{
			return default(bool);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x57BE", Offset = "0x57BE", VA = "0x57BE", Slot = "7")]
		protected override bool TryUpdateOrCreate(IEnumerable<TriggerValue> collection, out IEnumerable<TriggerValue> changes)
		{
			return default(bool);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x57BF", Offset = "0x57BF", VA = "0x57BF", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, TriggerValue> _triggers;
	}
}

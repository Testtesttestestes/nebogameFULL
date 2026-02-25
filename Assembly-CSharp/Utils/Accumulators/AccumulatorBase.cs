using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Utils.Accumulators
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public abstract class AccumulatorBase<TKey, SValue> : IDisposable
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000010")]
		public event AccumulatorBase<TKey, SValue>.AccumulatorUpdateDelegate UpdateEvent
		{
			[Token(Token = "0x6000373")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000374")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000084")]
		[NotNull]
		protected virtual List<SValue> LastChanges
		{
			[Token(Token = "0x6000375")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000376")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000377")]
		public AccumulatorBase(float seconds)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000378")]
		private void RunTimer()
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000379")]
		public void Update(IEnumerable<SValue> value)
		{
		}

		// Token: 0x0600037A RID: 890
		[Token(Token = "0x600037A")]
		protected abstract bool TryUpdateOrCreate(IEnumerable<SValue> collection, out IEnumerable<SValue> changes);

		// Token: 0x0600037B RID: 891
		[Token(Token = "0x600037B")]
		public abstract bool TryGetValue(TKey key, out SValue value);

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x0")]
		private readonly float _timeout;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x0")]
		private bool _running;

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x0600037D RID: 893
		[Token(Token = "0x2000079")]
		public delegate void AccumulatorUpdateDelegate(IEnumerable<SValue> changes, AccumulatorBase<TKey, SValue> accumulator);
	}
}

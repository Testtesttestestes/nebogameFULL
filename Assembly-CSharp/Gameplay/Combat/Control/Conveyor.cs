using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace Gameplay.Combat.Control
{
	// Token: 0x020009BA RID: 2490
	[Token(Token = "0x20009BA")]
	public class Conveyor : IDisposable
	{
		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x0000C030 File Offset: 0x0000A230
		// (set) Token: 0x06003BA8 RID: 15272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC6")]
		public bool IsPause
		{
			[Token(Token = "0x6003BA7")]
			[Address(RVA = "0x8A80", Offset = "0x8A80", VA = "0x8A80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BA8")]
			[Address(RVA = "0x8A81", Offset = "0x8A81", VA = "0x8A81")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x17000BC7")]
		public LinkedList<IConveyorItem>.Enumerator GetQueueEnumerator
		{
			[Token(Token = "0x6003BA9")]
			[Address(RVA = "0x8A82", Offset = "0x8A82", VA = "0x8A82")]
			get
			{
				return default(LinkedList<IConveyorItem>.Enumerator);
			}
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x8A83", Offset = "0x8A83", VA = "0x8A83", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x8A84", Offset = "0x8A84", VA = "0x8A84")]
		public Conveyor(Action<IConveyorItem> executeCallback, Action completeQueueCallback)
		{
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x1C3C", Offset = "0x1C3C", VA = "0x1C3C")]
		private void Next()
		{
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x8A85", Offset = "0x8A85", VA = "0x8A85")]
		private void Execute(IConveyorItem item)
		{
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAE")]
		[Address(RVA = "0x8A86", Offset = "0x8A86", VA = "0x8A86")]
		private void StopInternal()
		{
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x8A87", Offset = "0x8A87", VA = "0x8A87")]
		public void Reset()
		{
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x8A88", Offset = "0x8A88", VA = "0x8A88")]
		public Conveyor Append(IConveyorItem item)
		{
			return null;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x8A89", Offset = "0x8A89", VA = "0x8A89")]
		public void Play()
		{
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x8A8A", Offset = "0x8A8A", VA = "0x8A8A")]
		public void Stop()
		{
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB3")]
		[Address(RVA = "0x8A8B", Offset = "0x8A8B", VA = "0x8A8B")]
		public void Pause()
		{
		}

		// Token: 0x040020CC RID: 8396
		[Token(Token = "0x40020CC")]
		[FieldOffset(Offset = "0x8")]
		private bool _isPlay;

		// Token: 0x040020CE RID: 8398
		[Token(Token = "0x40020CE")]
		[FieldOffset(Offset = "0xC")]
		private Action<IConveyorItem> _executeCallback;

		// Token: 0x040020CF RID: 8399
		[Token(Token = "0x40020CF")]
		[FieldOffset(Offset = "0x10")]
		private Action _completeQueueCallback;

		// Token: 0x040020D0 RID: 8400
		[Token(Token = "0x40020D0")]
		[FieldOffset(Offset = "0x14")]
		private bool _isDisposed;

		// Token: 0x040020D1 RID: 8401
		[Token(Token = "0x40020D1")]
		[FieldOffset(Offset = "0x18")]
		private readonly LinkedList<IConveyorItem> _queue;

		// Token: 0x040020D2 RID: 8402
		[Token(Token = "0x40020D2")]
		[FieldOffset(Offset = "0x1C")]
		private CancellationTokenSource _awaitableCancellationTs;
	}
}

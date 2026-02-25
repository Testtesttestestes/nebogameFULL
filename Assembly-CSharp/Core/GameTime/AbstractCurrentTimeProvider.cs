using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.GameTime
{
	// Token: 0x02000EC7 RID: 3783
	[Token(Token = "0x2000EC7")]
	public abstract class AbstractCurrentTimeProvider : ICurrentTimeProvider, IDisposable
	{
		// Token: 0x1400022C RID: 556
		// (add) Token: 0x06005C21 RID: 23585 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005C22 RID: 23586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400022C")]
		public event Action<AbstractCurrentTimeProvider> ReadyEvent
		{
			[Token(Token = "0x6005C21")]
			[Address(RVA = "0xA8CE", Offset = "0xA8CE", VA = "0xA8CE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005C22")]
			[Address(RVA = "0xA8CF", Offset = "0xA8CF", VA = "0xA8CF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06005C23 RID: 23587 RVA: 0x000108A8 File Offset: 0x0000EAA8
		// (set) Token: 0x06005C24 RID: 23588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012B5")]
		public bool IsReady
		{
			[Token(Token = "0x6005C23")]
			[Address(RVA = "0xA8D0", Offset = "0xA8D0", VA = "0xA8D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C24")]
			[Address(RVA = "0xA8D1", Offset = "0xA8D1", VA = "0xA8D1")]
			protected set
			{
			}
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C25")]
		[Address(RVA = "0xA8D2", Offset = "0xA8D2", VA = "0xA8D2", Slot = "6")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x000108C0 File Offset: 0x0000EAC0
		[Token(Token = "0x6005C26")]
		[Address(RVA = "0xA8D3", Offset = "0xA8D3", VA = "0xA8D3")]
		public bool TryRun()
		{
			return default(bool);
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C27")]
		[Address(RVA = "0xA8D4", Offset = "0xA8D4", VA = "0xA8D4")]
		public void Stop()
		{
		}

		// Token: 0x06005C28 RID: 23592
		[Token(Token = "0x6005C28")]
		public abstract ulong GetUnixTimeMilliseconds();

		// Token: 0x06005C29 RID: 23593
		[Token(Token = "0x6005C29")]
		protected abstract void HandleRun();

		// Token: 0x06005C2A RID: 23594
		[Token(Token = "0x6005C2A")]
		protected abstract void HandleStop();

		// Token: 0x06005C2B RID: 23595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C2B")]
		[Address(RVA = "0xA8D5", Offset = "0xA8D5", VA = "0xA8D5")]
		protected AbstractCurrentTimeProvider()
		{
		}

		// Token: 0x0400325A RID: 12890
		[Token(Token = "0x400325A")]
		[FieldOffset(Offset = "0xC")]
		private bool _isRun;

		// Token: 0x0400325B RID: 12891
		[Token(Token = "0x400325B")]
		[FieldOffset(Offset = "0xD")]
		private bool _isReady;
	}
}

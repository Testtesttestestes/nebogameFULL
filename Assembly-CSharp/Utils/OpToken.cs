using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public class OpToken : IOpToken, IDisposable
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00002AF0 File Offset: 0x00000CF0
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public OpToken.OpTokenStatus Status
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x5743", Offset = "0x5743", VA = "0x5743", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return OpToken.OpTokenStatus.IDLE;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x5744", Offset = "0x5744", VA = "0x5744")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x1700006E")]
		public bool IsPending
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x5745", Offset = "0x5745", VA = "0x5745")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x1700006F")]
		public bool IsIdle
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x5746", Offset = "0x5746", VA = "0x5746")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public object CustomData
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x5747", Offset = "0x5747", VA = "0x5747")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x5748", Offset = "0x5748", VA = "0x5748")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000071")]
		public object Index
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x5749", Offset = "0x5749", VA = "0x5749", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x574A", Offset = "0x574A", VA = "0x574A", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x574B", Offset = "0x574B", VA = "0x574B", Slot = "9")]
		public virtual void Dispose()
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x574C", Offset = "0x574C", VA = "0x574C")]
		public OpToken()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x574D", Offset = "0x574D", VA = "0x574D")]
		public OpToken(object index)
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x574E", Offset = "0x574E", VA = "0x574E", Slot = "10")]
		public virtual void Run()
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x574F", Offset = "0x574F", VA = "0x574F", Slot = "11")]
		public virtual void Cancel()
		{
		}

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x200004C")]
		public enum OpTokenStatus
		{
			// Token: 0x0400012E RID: 302
			[Token(Token = "0x400012E")]
			IDLE,
			// Token: 0x0400012F RID: 303
			[Token(Token = "0x400012F")]
			PENDING,
			// Token: 0x04000130 RID: 304
			[Token(Token = "0x4000130")]
			COMPLETE,
			// Token: 0x04000131 RID: 305
			[Token(Token = "0x4000131")]
			FAILED,
			// Token: 0x04000132 RID: 306
			[Token(Token = "0x4000132")]
			CANCELLED
		}
	}
}

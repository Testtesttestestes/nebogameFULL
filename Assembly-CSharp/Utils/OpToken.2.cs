using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public class OpToken<TResult, TFault> : OpToken
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		public TResult Result
		{
			[Token(Token = "0x60002BB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		public TFault Fault
		{
			[Token(Token = "0x60002BD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002BF")]
		public OpToken<TResult, TFault> SetCustomData(object data)
		{
			return null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		public override void Dispose()
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		public OpToken()
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		public OpToken(object index)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C3")]
		public OpToken<TResult, TFault> RemoveResultHandler(Action<OpToken<TResult, TFault>> handler)
		{
			return null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C4")]
		public OpToken<TResult, TFault> RemoveFaultHandler(Action<OpToken<TResult, TFault>> handler)
		{
			return null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C5")]
		public OpToken<TResult, TFault> AddHandlers(Action<OpToken<TResult, TFault>> result, Action<OpToken<TResult, TFault>> fault)
		{
			return null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C6")]
		public OpToken<TResult, TFault> AddResultHandler(Action<OpToken<TResult, TFault>> handler, [Optional] object customData)
		{
			return null;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002C7")]
		public OpToken<TResult, TFault> AddFaultHandler(Action<OpToken<TResult, TFault>> handler)
		{
			return null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C8")]
		public void SetCancelHandler(Action<OpToken<TResult, TFault>> value)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		public void Complete(TResult obj)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		public void Fail(TFault obj)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CB")]
		public override void Cancel()
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CC")]
		private void DisposeHandlers()
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002CD")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<Action<OpToken<TResult, TFault>>> _resultHandlers;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<Action<OpToken<TResult, TFault>>> _faultHandlers;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<OpToken<TResult, TFault>> _cancelHandler;
	}
}

using System;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Dict.DictWrappers.Base
{
	// Token: 0x020010A0 RID: 4256
	[Token(Token = "0x20010A0")]
	public abstract class AbstractDictWrapper<TData, TId> : IDisposable, IManagedDictWrapper<TId> where TData : class, IMessage
	{
		// Token: 0x1400022F RID: 559
		// (add) Token: 0x060062E2 RID: 25314 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060062E3 RID: 25315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400022F")]
		public event Action DataChangedEvent
		{
			[Token(Token = "0x60062E2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60062E3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x060062E4 RID: 25316 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170013B3")]
		public TId Id
		{
			[Token(Token = "0x60062E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (set) Token: 0x060062E5 RID: 25317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B4")]
		private TId Id
		{
			[Token(Token = "0x60062E5")]
			set
			{
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x060062E6 RID: 25318 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062E7 RID: 25319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B5")]
		public TData Data
		{
			[Token(Token = "0x60062E6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062E7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062E8 RID: 25320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E8")]
		public void Dispose()
		{
		}

		// Token: 0x060062E9 RID: 25321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062E9")]
		private void UpdateData(Dictionaries dictionaries)
		{
		}

		// Token: 0x060062EA RID: 25322
		[Token(Token = "0x60062EA")]
		protected abstract TData GetData(Dictionaries dictionaries);

		// Token: 0x060062EB RID: 25323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062EB")]
		protected AbstractDictWrapper()
		{
		}

		// Token: 0x0400350E RID: 13582
		[Token(Token = "0x400350E")]
		[FieldOffset(Offset = "0x0")]
		private TId _id;
	}
}

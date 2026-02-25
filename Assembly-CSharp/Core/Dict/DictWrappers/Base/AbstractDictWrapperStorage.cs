using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Dict.DictWrappers.Base
{
	// Token: 0x020010A1 RID: 4257
	[Token(Token = "0x20010A1")]
	public abstract class AbstractDictWrapperStorage<TWrapper, TId> : IDisposable where TWrapper : class, new()
	{
		// Token: 0x060062EC RID: 25324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062EC")]
		public AbstractDictWrapperStorage(IDictProvider dictProvider)
		{
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062ED")]
		private void DictProviderOnChangedEvent()
		{
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062EE")]
		private void UpdateWrappers()
		{
		}

		// Token: 0x060062EF RID: 25327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60062EF")]
		public TWrapper GetWrapper(TId id)
		{
			return null;
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062F0")]
		public void Dispose()
		{
		}

		// Token: 0x04003510 RID: 13584
		[Token(Token = "0x4003510")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TId, WeakReference<TWrapper>> _cache;

		// Token: 0x04003511 RID: 13585
		[Token(Token = "0x4003511")]
		[FieldOffset(Offset = "0x0")]
		private IDictProvider _dictProvider;
	}
}

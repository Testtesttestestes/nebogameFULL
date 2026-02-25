using System;
using System.Collections.Generic;
using Core.Rounting;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GameActivityRouting
{
	// Token: 0x020011C7 RID: 4551
	[Token(Token = "0x20011C7")]
	public class LocatorRepository : ILocatorRepository, IDisposable
	{
		// Token: 0x06006C6A RID: 27754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C6A")]
		[Address(RVA = "0xB756", Offset = "0xB756", VA = "0xB756", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C6B")]
		[Address(RVA = "0xB757", Offset = "0xB757", VA = "0xB757")]
		public LocatorRepository(ILocator defaultLocator)
		{
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C6C")]
		[Address(RVA = "0xB758", Offset = "0xB758", VA = "0xB758")]
		public void Add(ILocator locator)
		{
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x00014028 File Offset: 0x00012228
		[Token(Token = "0x6006C6D")]
		[Address(RVA = "0xB759", Offset = "0xB759", VA = "0xB759", Slot = "4")]
		public bool TryGetLocator(Uri uri, out ILocator locator)
		{
			return default(bool);
		}

		// Token: 0x040038FF RID: 14591
		[Token(Token = "0x40038FF")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<ILocator> _locators;

		// Token: 0x04003900 RID: 14592
		[Token(Token = "0x4003900")]
		[FieldOffset(Offset = "0xC")]
		private ILocator _defaultLocator;
	}
}

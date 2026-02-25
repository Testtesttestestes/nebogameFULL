using System;
using System.Collections.Generic;
using Core.Rounting;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path.Factories
{
	// Token: 0x020011ED RID: 4589
	[Token(Token = "0x20011ED")]
	public class PathNodeFactoryRepository : IPathNodeFactoryRepository, IDisposable
	{
		// Token: 0x06006CF9 RID: 27897 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006CF9")]
		[Address(RVA = "0xB7E2", Offset = "0xB7E2", VA = "0xB7E2", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFA")]
		[Address(RVA = "0xB7E3", Offset = "0xB7E3", VA = "0xB7E3", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x06006CFB RID: 27899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFB")]
		[Address(RVA = "0xB7E4", Offset = "0xB7E4", VA = "0xB7E4")]
		public PathNodeFactoryRepository(IPathNodeFactory defaultNodeFactory)
		{
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFC")]
		[Address(RVA = "0xB7E5", Offset = "0xB7E5", VA = "0xB7E5")]
		public void Add(IPathNodeFactory factory)
		{
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x000140E8 File Offset: 0x000122E8
		[Token(Token = "0x6006CFD")]
		[Address(RVA = "0xB7E6", Offset = "0xB7E6", VA = "0xB7E6", Slot = "4")]
		public bool TryGetFactory(string name, out IPathNodeFactory factory)
		{
			return default(bool);
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFE")]
		[Address(RVA = "0xB7E7", Offset = "0xB7E7", VA = "0xB7E7")]
		private void Init()
		{
		}

		// Token: 0x0400390B RID: 14603
		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<string, IPathNodeFactory> _factories;

		// Token: 0x0400390C RID: 14604
		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0xC")]
		private IPathNodeFactory _defaultFactory;
	}
}

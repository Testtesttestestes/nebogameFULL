using System;
using Core.Data;
using Core.Data.InfoRows;
using Il2CppDummyDll;

namespace Gameplay.Inventory.Model
{
	// Token: 0x0200069D RID: 1693
	[Token(Token = "0x200069D")]
	public interface IItemInformationProvider : IInformationProvider, IDisposable
	{
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060028FD RID: 10493
		[Token(Token = "0x170007C1")]
		ArtikulData Artikul { [Token(Token = "0x60028FD")] get; }
	}
}

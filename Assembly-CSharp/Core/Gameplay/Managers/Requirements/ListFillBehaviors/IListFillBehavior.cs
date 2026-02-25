using System;
using System.Collections.Generic;
using Core.Data.InfoRows;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Requirements.ListFillBehaviors
{
	// Token: 0x0200119B RID: 4507
	[Token(Token = "0x200119B")]
	public interface IListFillBehavior
	{
		// Token: 0x06006B1A RID: 27418
		[Token(Token = "0x6006B1A")]
		void Add(IList<IInformationRow> collection, IInformationProvider provider);

		// Token: 0x06006B1B RID: 27419
		[Token(Token = "0x6006B1B")]
		void Add(IList<IInformationRow> collection, IInformationRow title, IList<IInformationRow> rows);

		// Token: 0x06006B1C RID: 27420
		[Token(Token = "0x6006B1C")]
		void Add(IList<IInformationRow> collection, IEnumerable<IInformationRow> rows);

		// Token: 0x06006B1D RID: 27421
		[Token(Token = "0x6006B1D")]
		void Add(IList<IInformationRow> collection, params IInformationRow[] rows);
	}
}

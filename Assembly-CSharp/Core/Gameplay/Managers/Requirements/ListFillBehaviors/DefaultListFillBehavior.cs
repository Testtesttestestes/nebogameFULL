using System;
using System.Collections.Generic;
using Core.Data.InfoRows;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Requirements.ListFillBehaviors
{
	// Token: 0x0200119A RID: 4506
	[Token(Token = "0x200119A")]
	public class DefaultListFillBehavior : IListFillBehavior
	{
		// Token: 0x06006B15 RID: 27413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B15")]
		[Address(RVA = "0xB61C", Offset = "0xB61C", VA = "0xB61C", Slot = "4")]
		public void Add(IList<IInformationRow> collection, IInformationProvider provider)
		{
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B16")]
		[Address(RVA = "0xB61D", Offset = "0xB61D", VA = "0xB61D", Slot = "5")]
		public void Add(IList<IInformationRow> collection, IInformationRow title, IList<IInformationRow> rows)
		{
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B17")]
		[Address(RVA = "0xB61E", Offset = "0xB61E", VA = "0xB61E", Slot = "6")]
		public void Add(IList<IInformationRow> collection, IEnumerable<IInformationRow> rows)
		{
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B18")]
		[Address(RVA = "0xB61F", Offset = "0xB61F", VA = "0xB61F", Slot = "7")]
		public void Add(IList<IInformationRow> collection, params IInformationRow[] rows)
		{
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B19")]
		[Address(RVA = "0xB620", Offset = "0xB620", VA = "0xB620")]
		public DefaultListFillBehavior()
		{
		}
	}
}

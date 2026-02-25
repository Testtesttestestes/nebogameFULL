using System;
using System.Collections.Generic;
using Core.Data.InfoRows;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Requirements.ListFillBehaviors
{
	// Token: 0x0200119C RID: 4508
	[Token(Token = "0x200119C")]
	public class ListFillBehaviorWhitOutSeparation : IListFillBehavior
	{
		// Token: 0x06006B1E RID: 27422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B1E")]
		[Address(RVA = "0xB621", Offset = "0xB621", VA = "0xB621", Slot = "4")]
		public void Add(IList<IInformationRow> collection, IInformationProvider provider)
		{
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B1F")]
		[Address(RVA = "0xB622", Offset = "0xB622", VA = "0xB622", Slot = "5")]
		public void Add(IList<IInformationRow> collection, IInformationRow title, IList<IInformationRow> rows)
		{
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B20")]
		[Address(RVA = "0xB623", Offset = "0xB623", VA = "0xB623", Slot = "6")]
		public void Add(IList<IInformationRow> collection, IEnumerable<IInformationRow> rows)
		{
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B21")]
		[Address(RVA = "0xB624", Offset = "0xB624", VA = "0xB624", Slot = "7")]
		public void Add(IList<IInformationRow> collection, params IInformationRow[] rows)
		{
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B22")]
		[Address(RVA = "0xB625", Offset = "0xB625", VA = "0xB625")]
		public ListFillBehaviorWhitOutSeparation()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000739 RID: 1849
	[Token(Token = "0x2000739")]
	public class CategoryModel
	{
		// Token: 0x06002C1E RID: 11294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x7CAE", Offset = "0x7CAE", VA = "0x7CAE")]
		public CategoryModel()
		{
		}

		// Token: 0x04001829 RID: 6185
		[Token(Token = "0x4001829")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		// Token: 0x0400182A RID: 6186
		[Token(Token = "0x400182A")]
		[FieldOffset(Offset = "0xC")]
		public List<CellModel> items;
	}
}

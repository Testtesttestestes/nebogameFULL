using System;
using Gameplay.GdEvents.Model;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x0200073A RID: 1850
	[Token(Token = "0x200073A")]
	public class CellModel
	{
		// Token: 0x06002C1F RID: 11295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0x7CAF", Offset = "0x7CAF", VA = "0x7CAF")]
		public CellModel()
		{
		}

		// Token: 0x0400182B RID: 6187
		[Token(Token = "0x400182B")]
		[FieldOffset(Offset = "0x8")]
		public CategoryModel parentCategory;

		// Token: 0x0400182C RID: 6188
		[Token(Token = "0x400182C")]
		[FieldOffset(Offset = "0xC")]
		public int id;

		// Token: 0x0400182D RID: 6189
		[Token(Token = "0x400182D")]
		[FieldOffset(Offset = "0x10")]
		public CellModel.CellType type;

		// Token: 0x0400182E RID: 6190
		[Token(Token = "0x400182E")]
		[FieldOffset(Offset = "0x14")]
		public GdEventData Data;

		// Token: 0x0200073B RID: 1851
		[Token(Token = "0x200073B")]
		public enum CellType
		{
			// Token: 0x04001830 RID: 6192
			[Token(Token = "0x4001830")]
			VALID,
			// Token: 0x04001831 RID: 6193
			[Token(Token = "0x4001831")]
			FOR_ROW_COMPLETION,
			// Token: 0x04001832 RID: 6194
			[Token(Token = "0x4001832")]
			IN_ROW_SEPARATING_CATEGORIES
		}
	}
}

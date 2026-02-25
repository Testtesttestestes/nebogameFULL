using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D92 RID: 3474
	[Token(Token = "0x2000D92")]
	internal class Filter
	{
		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060054F7 RID: 21751 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060054F8 RID: 21752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700114C")]
		public CategoryData Category
		{
			[Token(Token = "0x60054F7")]
			[Address(RVA = "0xA29D", Offset = "0xA29D", VA = "0xA29D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054F8")]
			[Address(RVA = "0xA29E", Offset = "0xA29E", VA = "0xA29E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x060054F9 RID: 21753 RVA: 0x0000F588 File Offset: 0x0000D788
		// (set) Token: 0x060054FA RID: 21754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700114D")]
		public bool IsShowOnlyReceived
		{
			[Token(Token = "0x60054F9")]
			[Address(RVA = "0xA29F", Offset = "0xA29F", VA = "0xA29F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60054FA")]
			[Address(RVA = "0xA2A0", Offset = "0xA2A0", VA = "0xA2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060054FC RID: 21756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700114E")]
		public string CurrentSearchPhrase
		{
			[Token(Token = "0x60054FB")]
			[Address(RVA = "0xA2A1", Offset = "0xA2A1", VA = "0xA2A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054FC")]
			[Address(RVA = "0xA2A2", Offset = "0xA2A2", VA = "0xA2A2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054FD")]
		[Address(RVA = "0xA2A3", Offset = "0xA2A3", VA = "0xA2A3")]
		public Filter(CategoryData defaultCategory)
		{
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x1D24", Offset = "0x1D24", VA = "0x1D24")]
		public IList<GroupData> Apply(IList<GroupData> items, out int currentCount, out int totalCount)
		{
			return null;
		}

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x8")]
		public readonly CategoryData DefaultCategory;
	}
}

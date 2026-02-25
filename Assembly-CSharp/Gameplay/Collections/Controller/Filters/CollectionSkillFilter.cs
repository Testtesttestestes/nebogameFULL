using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Collections.Controller.Filters
{
	// Token: 0x020009EB RID: 2539
	[Token(Token = "0x20009EB")]
	public class CollectionSkillFilter : ICollectionFilter
	{
		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06003CA8 RID: 15528 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003CA9 RID: 15529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF1")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6003CA8")]
			[Address(RVA = "0x8B6F", Offset = "0x8B6F", VA = "0x8B6F", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CA9")]
			[Address(RVA = "0x8B70", Offset = "0x8B70", VA = "0x8B70", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x8B71", Offset = "0x8B71", VA = "0x8B71", Slot = "6")]
		public bool Filter(CollectionData collectionData)
		{
			return default(bool);
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x8B72", Offset = "0x8B72", VA = "0x8B72")]
		public CollectionSkillFilter()
		{
		}
	}
}

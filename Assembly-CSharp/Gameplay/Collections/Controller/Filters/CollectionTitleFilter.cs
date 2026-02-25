using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Collections.Controller.Filters
{
	// Token: 0x020009EC RID: 2540
	[Token(Token = "0x20009EC")]
	public class CollectionTitleFilter : ICollectionFilter
	{
		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06003CAC RID: 15532 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003CAD RID: 15533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF2")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6003CAC")]
			[Address(RVA = "0x8B73", Offset = "0x8B73", VA = "0x8B73", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CAD")]
			[Address(RVA = "0x8B74", Offset = "0x8B74", VA = "0x8B74", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x0000C360 File Offset: 0x0000A560
		[Token(Token = "0x6003CAE")]
		[Address(RVA = "0x8B75", Offset = "0x8B75", VA = "0x8B75", Slot = "6")]
		public bool Filter(CollectionData collectionData)
		{
			return default(bool);
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAF")]
		[Address(RVA = "0x8B76", Offset = "0x8B76", VA = "0x8B76")]
		public CollectionTitleFilter()
		{
		}
	}
}

using System;
using Il2CppDummyDll;
using UI;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009CA RID: 2506
	[Token(Token = "0x20009CA")]
	public class CollectionsOSAView : OSAGenericBase<CollectionsViewsHolder, CollectionListElement.CollectionListElementArgs>
	{
		// Token: 0x06003C0A RID: 15370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C0A")]
		[Address(RVA = "0x8AD9", Offset = "0x8AD9", VA = "0x8AD9", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C0B")]
		[Address(RVA = "0x8ADA", Offset = "0x8ADA", VA = "0x8ADA", Slot = "99")]
		protected override CollectionsViewsHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0x8ADB", Offset = "0x8ADB", VA = "0x8ADB", Slot = "100")]
		protected override void UpdateViewsHolder(CollectionsViewsHolder newOrRecycled)
		{
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C0D")]
		[Address(RVA = "0x8ADC", Offset = "0x8ADC", VA = "0x8ADC", Slot = "119")]
		protected override CollectionsViewsHolder CreateViewsHolder()
		{
			return null;
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C0E")]
		[Address(RVA = "0x8ADD", Offset = "0x8ADD", VA = "0x8ADD")]
		public CollectionsOSAView()
		{
		}

		// Token: 0x04002123 RID: 8483
		[Token(Token = "0x4002123")]
		[FieldOffset(Offset = "0xA4")]
		private Mask _viewportMask;
	}
}

using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Collections.Events
{
	// Token: 0x020009E5 RID: 2533
	[Token(Token = "0x20009E5")]
	public class CollectionsEvents : AbstractMVCEvents
	{
		// Token: 0x06003C7C RID: 15484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7C")]
		[Address(RVA = "0x8B43", Offset = "0x8B43", VA = "0x8B43")]
		public CollectionsEvents()
		{
		}

		// Token: 0x04002176 RID: 8566
		[Token(Token = "0x4002176")]
		[FieldOffset(Offset = "0x14")]
		public Action UserCollectionImprovedEvent;

		// Token: 0x04002177 RID: 8567
		[Token(Token = "0x4002177")]
		[FieldOffset(Offset = "0x18")]
		public Action DependenciesChangedEvent;
	}
}

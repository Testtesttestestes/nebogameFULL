using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02000FF1 RID: 4081
	[Token(Token = "0x2000FF1")]
	public class CollectionsScope : AbstractEventBusScope
	{
		// Token: 0x0600610D RID: 24845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600610D")]
		[Address(RVA = "0xAD39", Offset = "0xAD39", VA = "0xAD39", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600610E")]
		[Address(RVA = "0xAD3A", Offset = "0xAD3A", VA = "0xAD3A")]
		public CollectionsScope()
		{
		}

		// Token: 0x040033F6 RID: 13302
		[Token(Token = "0x40033F6")]
		[FieldOffset(Offset = "0x8")]
		public Action<CollectionsScope.CollectionsEventArgs> CollectionImprovedEvent;

		// Token: 0x02000FF2 RID: 4082
		[Token(Token = "0x2000FF2")]
		public class CollectionsEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700132D RID: 4909
			// (get) Token: 0x0600610F RID: 24847 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700132D")]
			public CollectionData CollectionData
			{
				[Token(Token = "0x600610F")]
				[Address(RVA = "0xAD3B", Offset = "0xAD3B", VA = "0xAD3B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006110 RID: 24848 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006110")]
			[Address(RVA = "0xAD3C", Offset = "0xAD3C", VA = "0xAD3C")]
			public CollectionsEventArgs(App app, IGame game, CollectionData collectionData)
			{
			}
		}
	}
}

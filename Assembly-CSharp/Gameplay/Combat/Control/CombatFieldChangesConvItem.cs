using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Control
{
	// Token: 0x020009B8 RID: 2488
	[Token(Token = "0x20009B8")]
	public class CombatFieldChangesConvItem : IConveyorItem
	{
		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06003BA0 RID: 15264 RVA: 0x0000C000 File Offset: 0x0000A200
		// (set) Token: 0x06003BA1 RID: 15265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC2")]
		public float Duration
		{
			[Token(Token = "0x6003BA0")]
			[Address(RVA = "0x8A7B", Offset = "0x8A7B", VA = "0x8A7B", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003BA1")]
			[Address(RVA = "0x8A7C", Offset = "0x8A7C", VA = "0x8A7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x0000C018 File Offset: 0x0000A218
		// (set) Token: 0x06003BA3 RID: 15267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC3")]
		public float Delay
		{
			[Token(Token = "0x6003BA2")]
			[Address(RVA = "0x8A7D", Offset = "0x8A7D", VA = "0x8A7D", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003BA3")]
			[Address(RVA = "0x8A7E", Offset = "0x8A7E", VA = "0x8A7E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BA4")]
		[Address(RVA = "0x8A7F", Offset = "0x8A7F", VA = "0x8A7F")]
		public CombatFieldChangesConvItem(FieldChangedTypes changeType, object data)
		{
		}

		// Token: 0x040020C8 RID: 8392
		[Token(Token = "0x40020C8")]
		[FieldOffset(Offset = "0x8")]
		public readonly FieldChangedTypes ChangeType;

		// Token: 0x040020CB RID: 8395
		[Token(Token = "0x40020CB")]
		[FieldOffset(Offset = "0x14")]
		public readonly object Data;
	}
}

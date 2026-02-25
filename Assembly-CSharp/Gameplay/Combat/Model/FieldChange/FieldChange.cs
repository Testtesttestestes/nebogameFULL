using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Model.FieldChange
{
	// Token: 0x020009A8 RID: 2472
	[Token(Token = "0x20009A8")]
	public class FieldChange : AbstractFieldChangeDecorator<ProtoFieldChangedEvt>
	{
		// Token: 0x06003B0A RID: 15114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B0A")]
		[Address(RVA = "0x8A70", Offset = "0x8A70", VA = "0x8A70")]
		public FieldChange(ProtoFieldChangedEvt change)
		{
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06003B0B RID: 15115 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		[Token(Token = "0x17000BBB")]
		public override FieldChangedTypes ChangeType
		{
			[Token(Token = "0x6003B0B")]
			[Address(RVA = "0x8A71", Offset = "0x8A71", VA = "0x8A71", Slot = "8")]
			get
			{
				return FieldChangedTypes.UnknownFieldChangedType;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BBC")]
		public override IList<CellInfo> Points
		{
			[Token(Token = "0x6003B0C")]
			[Address(RVA = "0x8A72", Offset = "0x8A72", VA = "0x8A72", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[Token(Token = "0x6003B0D")]
		[Address(RVA = "0x8A73", Offset = "0x8A73", VA = "0x8A73", Slot = "10")]
		public override bool TryGetUserId(out ulong userId)
		{
			return default(bool);
		}
	}
}

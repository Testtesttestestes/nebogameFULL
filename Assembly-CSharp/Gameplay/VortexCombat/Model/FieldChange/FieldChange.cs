using System;
using System.Collections.Generic;
using Gameplay.Combat.Model.FieldChange;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Partycombat;

namespace Gameplay.VortexCombat.Model.FieldChange
{
	// Token: 0x020003B5 RID: 949
	[Token(Token = "0x20003B5")]
	public class FieldChange : AbstractFieldChangeDecorator<FieldChangedInfo>
	{
		// Token: 0x06001638 RID: 5688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x67F9", Offset = "0x67F9", VA = "0x67F9")]
		public FieldChange(FieldChangedInfo change)
		{
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x170003B7")]
		public override FieldChangedTypes ChangeType
		{
			[Token(Token = "0x6001639")]
			[Address(RVA = "0x67FA", Offset = "0x67FA", VA = "0x67FA", Slot = "8")]
			get
			{
				return FieldChangedTypes.UnknownFieldChangedType;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B8")]
		public override IList<CellInfo> Points
		{
			[Token(Token = "0x600163A")]
			[Address(RVA = "0x67FB", Offset = "0x67FB", VA = "0x67FB", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x67FC", Offset = "0x67FC", VA = "0x67FC", Slot = "10")]
		public override bool TryGetUserId(out ulong userId)
		{
			return default(bool);
		}
	}
}

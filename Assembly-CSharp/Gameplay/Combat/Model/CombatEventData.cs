using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Combat.Model
{
	// Token: 0x02000992 RID: 2450
	[Token(Token = "0x2000992")]
	public class CombatEventData
	{
		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B70")]
		public virtual string AnimationAssetId
		{
			[Token(Token = "0x6003A6A")]
			[Address(RVA = "0x89E0", Offset = "0x89E0", VA = "0x89E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A6B")]
		[Address(RVA = "0x89E1", Offset = "0x89E1", VA = "0x89E1")]
		public CombatEventData(CombatEventDic eventDic)
		{
		}

		// Token: 0x0400203F RID: 8255
		[Token(Token = "0x400203F")]
		[FieldOffset(Offset = "0x8")]
		public CombatEventDic EventDic;
	}
}

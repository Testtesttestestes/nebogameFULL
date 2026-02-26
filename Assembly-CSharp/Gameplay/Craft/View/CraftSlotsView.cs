using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008B4 RID: 2228
	[Token(Token = "0x20008B4")]
	public class CraftSlotsView : MonoBehaviour
	{
		// Token: 0x0600345B RID: 13403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600345B")]
		[Address(RVA = "0x8485", Offset = "0x8485", VA = "0x8485")]
		public List<CraftSlotListElement> CreateManufactureSlots(IList<CraftSlotDic> dics, Action<CraftSlotListElement> selectCallback)
		{
			return null;
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345C")]
		[Address(RVA = "0x8486", Offset = "0x8486", VA = "0x8486")]
		public CraftSlotsView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Craft_View_CraftSlotsView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cf9 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12606);
		    DAT_ram_00a57cf9 = '\x01';
		  }
		  return StringLiteral_12606;
		}
		*/

		}

		// Token: 0x04001C96 RID: 7318
		[Token(Token = "0x4001C96")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CraftSlotListElement _listElementPrefab;

		// Token: 0x04001C97 RID: 7319
		[Token(Token = "0x4001C97")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _craftSlotsContentParent;

		// Token: 0x04001C98 RID: 7320
		[Token(Token = "0x4001C98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _manufactureBg;
	}
}

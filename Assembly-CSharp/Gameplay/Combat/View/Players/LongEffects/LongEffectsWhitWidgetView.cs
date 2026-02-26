using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Combat.View.Players.LongEffects
{
	// Token: 0x0200095D RID: 2397
	[Token(Token = "0x200095D")]
	public class LongEffectsWhitWidgetView : LongEffectsView, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x060038D8 RID: 14552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D8")]
		[Address(RVA = "0x8876", Offset = "0x8876", VA = "0x8876", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerDown ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectsWhitWidgetView__OnPointerDown
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x2c) = 0xffffffff;
		  *(undefined8 *)(param1 + 0x24) = 0x3e99999a00000007;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D9")]
		[Address(RVA = "0x8877", Offset = "0x8877", VA = "0x8877")]
		public LongEffectsWhitWidgetView()
		{
		}

		// Token: 0x04001F66 RID: 8038
		[Token(Token = "0x4001F66")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LongEffectWidget _widget;
	}
}

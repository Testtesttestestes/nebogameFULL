using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C52 RID: 3154
	[Token(Token = "0x2000C52")]
	public class VipPointsView : AbstractDataRenderer<Nullable<int>>
	{
		// Token: 0x06004CD3 RID: 19667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CD3")]
		[Address(RVA = "0x9B10", Offset = "0x9B10", VA = "0x9B10", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Bank_View_VipPointsView__HandleDataChanged(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a597b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_Nullable_int____ctor__);
		    DAT_ram_00a597b2 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_Nullable_int____ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CD4")]
		[Address(RVA = "0x9B11", Offset = "0x9B11", VA = "0x9B11")]
		public VipPointsView()
		{
		}

		// Token: 0x040029F7 RID: 10743
		[Token(Token = "0x40029F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _valueLabel;

		// Token: 0x040029F8 RID: 10744
		[Token(Token = "0x40029F8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject _content;
	}
}

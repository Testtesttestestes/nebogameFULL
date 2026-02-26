using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	public class CurrentStatusTitledListElement : BaseTitledListElement<CurrentStatusTitledListElementArgs>
	{
		// Token: 0x06000D37 RID: 3383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x601A", Offset = "0x601A", VA = "0x601A", Slot = "6")]
		protected override void OnInit(CurrentStatusTitledListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void UI_Elements_RightPanel_TitledList_Elements_CurrentStatusTitledListElement__OnInit
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63963 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_CurrentStatusTitledListElementArgs___ctor__
		              );
		    DAT_ram_00a63963 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_CurrentStatusTitledListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x601B", Offset = "0x601B", VA = "0x601B")]
		public CurrentStatusTitledListElement()
		{
		}

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _energy;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _energyRestoringLimit;

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _maxLimit;
	}
}

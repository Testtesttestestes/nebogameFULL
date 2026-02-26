using System;
using Gameplay.FeedbackForm.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.FeedbackForm.View
{
	// Token: 0x02000814 RID: 2068
	[Token(Token = "0x2000814")]
	public class FeedbackFormField : MonoBehaviour
	{
		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x00009F00 File Offset: 0x00008100
		[Token(Token = "0x17000980")]
		public FormFields FormField
		{
			[Token(Token = "0x60030C3")]
			[Address(RVA = "0x8128", Offset = "0x8128", VA = "0x8128")]
			get
			{
				return (FormFields)0;
			}
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x8129", Offset = "0x8129", VA = "0x8129")]
		public FeedbackFormField()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_FeedbackForm_View_FeedbackFormField___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a575e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo);
		    DAT_ram_00a575e7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04001A95 RID: 6805
		[Token(Token = "0x4001A95")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FormFields _formField;
	}
}

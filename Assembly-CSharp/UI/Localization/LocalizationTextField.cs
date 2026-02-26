using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace UI.Localization
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	[RequireComponent(typeof(TextMeshProUGUI))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class LocalizationTextField : BaseMonoBehaviour
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000199")]
		private TextMeshProUGUI TextField
		{
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x5F5F", Offset = "0x5F5F", VA = "0x5F5F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x5F60", Offset = "0x5F60", VA = "0x5F60")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Localization_LocalizationTextField__Awake(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63912 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    DAT_ram_00a63912 = '\x01';
		  }
		  if (DAT_ram_00a63911 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		    DAT_ram_00a63911 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) == 0) {
		    piVar1 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___
		                                );
		    *(int **)(param1 + 0x18) = piVar1;
		  }
		  else {
		    piVar1 = *(int **)(param1 + 0x18);
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x2d0) * 4))
		            (piVar1,uVar2,*(undefined4 *)(*piVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x5F61", Offset = "0x5F61", VA = "0x5F61")]
		private void Localize()
		{
		/* --- GHIDRA: Localize ---
		void UI_Localization_LocalizationTextField__Localize(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63913 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    DAT_ram_00a63913 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string___ctor__);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  ScreenAdaptation_Common_AppSize__Update(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x5F62", Offset = "0x5F62", VA = "0x5F62")]
		public LocalizationTextField()
		{
		}

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _key;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<string> _terms;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x18")]
		private TextMeshProUGUI _textField;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TextField ---
		void UI_Localization_LocalizationTextField__get_TextField(undefined4 param1,undefined4 param2)
		
		{
		  UI_Localization_LocalizationTextField__Awake(param1,param1);
		  return;
		}
		*/

}

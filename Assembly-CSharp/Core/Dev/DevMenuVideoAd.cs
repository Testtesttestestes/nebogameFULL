using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Dev
{
	// Token: 0x020010B2 RID: 4274
	[Token(Token = "0x20010B2")]
	public class DevMenuVideoAd : MonoBehaviour
	{
		// Token: 0x0600633D RID: 25405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633D")]
		[Address(RVA = "0xAF49", Offset = "0xAF49", VA = "0xAF49")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Dev_DevMenuVideoAd__Awake(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a60778 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60778 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x268);
		        goto code_r0x81cdd71f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x81cdd71f:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  piVar3 = *(int **)(iVar4 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cdd7a4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo,0
		                               );
		code_r0x81cdd7a4:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,1,0,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600633E RID: 25406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633E")]
		[Address(RVA = "0xAF4A", Offset = "0xAF4A", VA = "0xAF4A")]
		private void ButtonClick()
		{
		/* --- GHIDRA: ButtonClick ---
		void Core_Dev_DevMenuVideoAd__ButtonClick(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a60779 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuVideoAd_ButtonClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a60779 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(param1_00,param1,Method_Core_Dev_DevMenuVideoAd_ButtonClick__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600633F RID: 25407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633F")]
		[Address(RVA = "0xAF4B", Offset = "0xAF4B", VA = "0xAF4B")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006340")]
		[Address(RVA = "0xAF4C", Offset = "0xAF4C", VA = "0xAF4C")]
		public DevMenuVideoAd()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dev_DevMenuVideoAd___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x04003533 RID: 13619
		[Token(Token = "0x4003533")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _inputField;

		// Token: 0x04003534 RID: 13620
		[Token(Token = "0x4003534")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _button;
	}
}

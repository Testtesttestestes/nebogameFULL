using System;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009D1 RID: 2513
	[Token(Token = "0x20009D1")]
	public class CollectionMedalView : MonoBehaviour
	{
		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BDD")]
		public MedalView View
		{
			[Token(Token = "0x6003C26")]
			[Address(RVA = "0x8AF5", Offset = "0x8AF5", VA = "0x8AF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x8AF6", Offset = "0x8AF6", VA = "0x8AF6")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Collections_View_CollectionMedalView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57ea5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionMedalView_MedalViewClickedEventHandler__)
		    ;
		    DAT_ram_00a57ea5 = '\x01';
		  }
		  if (DAT_ram_00a57ea3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MedalView___);
		    DAT_ram_00a57ea3 = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x1c);
		  if (param1_01 == 0) {
		    param1_01 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_MedalView___);
		    *(int *)(param1 + 0x1c) = param1_01;
		  }
		  param1_00 = unnamed_function_1417(System_Action_MedalView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Collections_View_CollectionMedalView_MedalViewClickedEventHandler__,0);
		  Gameplay_Medals_View_MedalView__add_ClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C28")]
		[Address(RVA = "0x8AF7", Offset = "0x8AF7", VA = "0x8AF7")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Collections_View_CollectionMedalView__OnDestroy
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57ea6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57ea6 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = param2;
		  *(undefined4 *)(param1 + 0x18) = param4;
		  if (DAT_ram_00a57ea3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MedalView___);
		    DAT_ram_00a57ea3 = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x1c);
		  if (piVar1 == (int *)0x0) {
		    piVar1 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_MedalView___);
		    *(int **)(param1 + 0x1c) = piVar1;
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x138) * 4))
		            (piVar1,param3,*(undefined4 *)(*piVar1 + 0x13c));
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = *(undefined4 *)(*(int *)(param3 + 0x10) + 0x24);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  UI_Price_Price__SetColor(uVar2,param4,uVar3,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param5,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C29")]
		[Address(RVA = "0x8AF8", Offset = "0x8AF8", VA = "0x8AF8")]
		public void Init(MedalData medalData, MedalDicWrapper medal, UserData user, bool showPrice)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Collections_View_CollectionMedalView__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57ea7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57ea7 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80e757f7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e757f7:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = func_ii_7112(uVar3,0);
		  if (*(int *)(param1 + 0x18) == iVar5) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x130);
		          goto code_r0x80e758bb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e758bb:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    if (DAT_ram_00a57ea3 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MedalView___);
		      DAT_ram_00a57ea3 = '\x01';
		    }
		    piVar4 = *(int **)(param1 + 0x1c);
		    if (piVar4 == (int *)0x0) {
		      piVar4 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_MedalView___);
		      *(int **)(param1 + 0x1c) = piVar4;
		    }
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x130) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0x134));
		    Core_Gameplay_Managers_MedalsManager__Deinit(uVar3,*(undefined4 *)(iVar5 + 0x10),0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		        goto code_r0x80e759c6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e759c6:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  if (DAT_ram_00a57ea3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MedalView___);
		    DAT_ram_00a57ea3 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x1c);
		  if (piVar4 == (int *)0x0) {
		    piVar4 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_MedalView___);
		    *(int **)(param1 + 0x1c) = piVar4;
		  }
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x130) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x134));
		  Core_Gameplay_Managers_MedalsManager__ShowOwnMedalInfoWindow
		            (uVar3,param2_00,*(undefined4 *)(*(int *)(iVar6 + 0x10) + 0x20),
		             *(undefined4 *)(param1 + 0x18),iVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0x8AF9", Offset = "0x8AF9", VA = "0x8AF9")]
		private void MedalViewClickedEventHandler(MedalView view)
		{
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C2B")]
		[Address(RVA = "0x8AFA", Offset = "0x8AFA", VA = "0x8AFA")]
		public CollectionMedalView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Collections_View_CollectionMedalView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ea8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__get_Count__);
		    DAT_ram_00a57ea8 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_uint__CollectionRanksDic__get_Count__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400213D RID: 8509
		[Token(Token = "0x400213D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Price _price;

		// Token: 0x0400213E RID: 8510
		[Token(Token = "0x400213E")]
		[FieldOffset(Offset = "0x14")]
		private MedalData _medalData;

		// Token: 0x0400213F RID: 8511
		[Token(Token = "0x400213F")]
		[FieldOffset(Offset = "0x18")]
		private UserData _user;

		// Token: 0x04002140 RID: 8512
		[Token(Token = "0x4002140")]
		[FieldOffset(Offset = "0x1C")]
		private MedalView _view;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_View ---
		void Gameplay_Collections_View_CollectionMedalView__get_View(int param1,undefined4 param2)
		
		{
		  char cVar1;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57ea4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionMedalView_MedalViewClickedEventHandler__)
		    ;
		    DAT_ram_00a57ea4 = '\x01';
		  }
		  if (DAT_ram_00a57ea3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MedalView___);
		    DAT_ram_00a57ea3 = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x1c);
		  if (param1_01 == 0) {
		    param1_01 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_MedalView___);
		    *(int *)(param1 + 0x1c) = param1_01;
		    cVar1 = DAT_ram_00a57ea3;
		    *(undefined4 *)(param1_01 + 0x40) = 1;
		    if (cVar1 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_MedalView___);
		      DAT_ram_00a57ea3 = '\x01';
		      param1_01 = *(int *)(param1 + 0x1c);
		      if (param1_01 == 0) {
		        param1_01 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_MedalView___);
		        *(int *)(param1 + 0x1c) = param1_01;
		      }
		    }
		  }
		  else {
		    *(undefined4 *)(param1_01 + 0x40) = 1;
		  }
		  param1_00 = unnamed_function_1417(System_Action_MedalView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Collections_View_CollectionMedalView_MedalViewClickedEventHandler__,0);
		  Gameplay_Medals_View_MedalView__get_MedalDic(param1_01,param1_00,0);
		  return;
		}
		*/

}

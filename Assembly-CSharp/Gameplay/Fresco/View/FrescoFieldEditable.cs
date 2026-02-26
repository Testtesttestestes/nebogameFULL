using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Fresco.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Fresco;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007F3 RID: 2035
	[Token(Token = "0x20007F3")]
	public class FrescoFieldEditable : FrescoField
	{
		// Token: 0x14000168 RID: 360
		// (add) Token: 0x06002FCF RID: 12239 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002FD0 RID: 12240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000168")]
		public event Action<List<uint>> OnChangeSelected
		{
			[Token(Token = "0x6002FCF")]
			[Address(RVA = "0x8035", Offset = "0x8035", VA = "0x8035")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002FD0")]
			[Address(RVA = "0x8036", Offset = "0x8036", VA = "0x8036")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0x8037", Offset = "0x8037", VA = "0x8037")]
		public void Init(Protocol.Fresco.Fresco fresco, Protocol.Dic.Fresco.Types.FrescoDic frescoDic, FrescoEditView view, FrescoModel model)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Fresco_View_FrescoFieldEditable__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5756a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Clear__);
		    DAT_ram_00a5756a = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x60);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  return;
		}
		*/

		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x8038", Offset = "0x8038", VA = "0x8038")]
		public void ClearSelection()
		{
		/* --- GHIDRA: ClearSelection ---
		void Gameplay_Fresco_View_FrescoFieldEditable__ClearSelection
		               (int param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  bool bVar2;
		  bool bVar3;
		  uint uVar4;
		  int iVar5;
		  int iVar6;
		  uint uVar7;
		  uint uVar8;
		  float param2_00;
		  undefined4 uVar9;
		  
		  bVar3 = false;
		  if (DAT_ram_00a5756b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_FrescoEditView_States__get_CurrentState__);
		    DAT_ram_00a5756b = '\x01';
		  }
		  iVar5 = *(int *)(param2 + 0x24);
		  if (iVar5 - 1U < 2) {
		    uVar7 = *(uint *)(*(int *)(param1 + 0x58) + 0x18);
		    if ((uVar7 < 5) && ((1 << (uVar7 & 0x1f) & 0x16U) != 0)) goto code_r0x80da99e5;
		  }
		  else if ((iVar5 == 0) && (bVar3 = true, *(int *)(*(int *)(param1 + 0x58) + 0x18) - 1U < 2)) {
		code_r0x80da99e5:
		    Gameplay_Fresco_View_FrescoFieldEditable__ClickHandler
		              (param1,*(undefined4 *)(param2 + 0x28),param2);
		    return;
		  }
		  iVar6 = *(int *)(param1 + 0x58);
		  uVar7 = *(uint *)(iVar6 + 0x18);
		  cVar1 = *(char *)(param2 + 0x20);
		  if ((cVar1 == '\0') && (uVar7 == 4)) {
		    if ((longlong)(ulonglong)*(uint *)(*(int *)(param1 + 0x5c) + 0x2c) <=
		        (longlong)*(int *)(*(int *)(*(int *)(param1 + 0x5c) + 0x28) + 0xc)) {
		      return;
		    }
		    *(undefined1 *)(param2 + 0x20) = 1;
		    uVar4 = 1;
		code_r0x80da9ab3:
		    if (bVar3) {
		      if (*(int *)(param2 + 0x28) == 0) {
		        uVar9 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar6 + 0x2c),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar9,(uint)*(byte *)(param2 + 0x20),0);
		        Gameplay_Inventory_View_ArtikulView__GetData
		                  (*(undefined4 *)(*(int *)(param1 + 0x58) + 0x2c),1.0,0);
		      }
		      else {
		        if (DAT_ram_00a57573 == '\0') {
		          Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		          DAT_ram_00a57573 = '\x01';
		        }
		        iVar5 = *(int *)(param2 + 0x14);
		        uVar9 = *(undefined4 *)(iVar5 + 0x80);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        uVar7 = UnityEngine_Component__GetComponent_object_(uVar9,0);
		        UnityEngine_Object__op_Implicit(iVar5,uVar7 & uVar4,0);
		        UnityEngine_Object__op_Implicit(*(undefined4 *)(param2 + 0x10),(uint)(cVar1 != '\0'),0);
		        Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param2 + 0x14),1.0,0);
		      }
		    }
		  }
		  else {
		    bVar2 = cVar1 != '\0';
		    uVar4 = (uint)(cVar1 == '\0');
		    *(bool *)(param2 + 0x20) = cVar1 == '\0';
		    if (8 < uVar7) goto code_r0x80da9b6b;
		    uVar8 = 1 << (uVar7 & 0x1f);
		    if ((uVar8 & 0x188) != 0) {
		      return;
		    }
		    if ((uVar8 & 6) == 0) {
		      if (uVar7 != 4) goto code_r0x80da9b6b;
		      goto code_r0x80da9ab3;
		    }
		    if (iVar5 == 1) {
		      param2_00 = 1.0;
		      if (cVar1 == '\0') {
		        param2_00 = 0.0;
		      }
		      if (*(int *)(param2 + 0x28) == 0) {
		        Gameplay_Inventory_View_ArtikulView__GetData(*(undefined4 *)(iVar6 + 0x2c),param2_00,0);
		      }
		      else {
		        Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param2 + 0x14),param2_00,0);
		      }
		    }
		  }
		  bVar2 = *(char *)(param2 + 0x20) == '\0';
		code_r0x80da9b6b:
		  iVar5 = Method_System_Collections_Generic_List_uint__Add__;
		  uVar9 = *(undefined4 *)(param2 + 0x28);
		  iVar6 = *(int *)(param1 + 0x60);
		  if (bVar2) {
		    System_Collections_Generic_List_uint___IsCompatibleObject
		              (iVar6,uVar9,Method_System_Collections_Generic_List_uint__Remove__);
		  }
		  else {
		    *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		    uVar7 = *(uint *)(iVar6 + 0xc);
		    if (uVar7 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		      *(uint *)(iVar6 + 0xc) = uVar7 + 1;
		      *(undefined4 *)(*(int *)(iVar6 + 8) + uVar7 * 4 + 0x10) = uVar9;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar6,uVar9,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar5 = *(int *)(param1 + 0x54);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(param1 + 0x60),
		               *(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x8039", Offset = "0x8039", VA = "0x8039", Slot = "14")]
		public override void ClickHandler(FrescoFragment fragment)
		{
		/* --- GHIDRA: ClickHandler ---
		void Gameplay_Fresco_View_FrescoFieldEditable__ClickHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5756c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ArtikulInfoPopupWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12635);
		    DAT_ram_00a5756c = '\x01';
		  }
		  uVar1 = Gameplay_Fresco_Model_FrescoModel__SetOptions
		                    (*(undefined4 *)(param1 + 0x5c),param2,param2);
		  piVar2 = (int *)Core_Data_ArtikulDataCustom__SetCurrentDurability
		                            (uVar1,*(undefined4 *)(*(int *)(*(int *)(param1 + 0x5c) + 0xc) + 8),0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe8) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0xec));
		  piVar2[0xe] = iVar3;
		  uVar1 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x5c) + 0xc) + 0xc);
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs_TypeInfo
		                    );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar3,0);
		  *(int **)(iVar3 + 0x1c) = piVar2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12635,iVar3,
		             Method_UI_Windows_PopupController_Show_ArtikulInfoPopupWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD4")]
		[Address(RVA = "0x803A", Offset = "0x803A", VA = "0x803A")]
		private void ShowInfo(uint index)
		{
		/* --- GHIDRA: ShowInfo ---
		void Gameplay_Fresco_View_FrescoFieldEditable__ShowInfo
		               (int param1,int param2,int param3,int param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Gameplay_Fresco_View_FrescoField__ClearField
		            (&local_8,&local_10,uVar1,(float)*(int *)(param4 + 0x18),&local_10);
		  local_4 = (float4)((float)local_4 / (float)param3);
		  local_8 = (float4)((float)local_8 / (float)param2);
		  local_10 = CONCAT44(local_4,local_8);
		  UnityEngine_UI_GridLayoutGroup__get_cellSize(*(undefined4 *)(param1 + 0x28),&local_10,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x30),0);
		  Gameplay_Fresco_View_FrescoField__ClearField
		            (&local_8,&local_10,uVar1,(float)*(int *)(param4 + 0x14),&local_10);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  Gameplay_Fresco_View_FrescoField__ClearField
		            (&local_8,&local_10,uVar1,(float)*(int *)(param4 + 0x18),&local_10);
		  return;
		}
		*/

		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x803B", Offset = "0x803B", VA = "0x803B", Slot = "15")]
		protected override void ValidateSize(int sizeX, int sizeY, FrescoSpriteSelectorSO.SpriteSelectorElement spriteElement)
		{
		/* --- GHIDRA: ValidateSize ---
		void Gameplay_Fresco_View_FrescoFieldEditable__ValidateSize(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5756d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_FrescoFragment___);
		    Mono_Security_ASN1__get_Item(&System_Func_FrescoFragment__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_FrescoFragment__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_FrescoFragment__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_View_FrescoFieldEditable___c__SelectAll_b__11_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo);
		    DAT_ram_00a5756d = '\x01';
		  }
		  iVar5 = param1[0x11];
		  if (*(int *)(Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[1];
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Func_FrescoFragment__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar7,uVar4,Method_Gameplay_Fresco_View_FrescoFieldEditable___c__SelectAll_b__11_0__,
		               0);
		    *(int *)(*(int *)(Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo + 0x5c) + 4) = iVar7;
		  }
		  uVar1 = 0;
		  piVar2 = (int *)System_Linq_Enumerable__Where_PlayerLoopSystem_
		                            (iVar5,iVar7,Method_System_Linq_Enumerable_Where_FrescoFragment___);
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_FrescoFragment__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80da9fed;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_IEnumerable_FrescoFragment__TypeInfo,0);
		code_r0x80da9fed:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar2 = local_4;
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar6 = (undefined4 *)(iVar5 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80daa0bb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80daa235:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80daa23d;
		    }
		code_r0x80daa0bb:
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii(*puVar6,piVar2,puVar6[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80daa235;
		    if (iVar5 == 0) {
		      iVar5 = 0;
		      goto code_r0x80daa286;
		    }
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_FrescoFragment__TypeInfo == *piVar8) {
		          puVar6 = (undefined4 *)(iVar5 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80daa195;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_FrescoFragment__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80daa221:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80daa23d;
		    }
		code_r0x80daa195:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar6,piVar2,puVar6[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80daa221;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*param1 + 0x130),param1,uVar4,*(undefined4 *)(*param1 + 0x134));
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar5 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80daa23d:
		  iVar5 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar7) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar5 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar5;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80daa286:
		      piVar2 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80daa2fe;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80daa2fe:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      }
		      if (iVar5 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30b,&local_c);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x803C", Offset = "0x803C", VA = "0x803C")]
		public void SelectAll()
		{
		/* --- GHIDRA: SelectAll ---
		void Gameplay_Fresco_View_FrescoFieldEditable__SelectAll(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5756e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    DAT_ram_00a5756e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_uint___ctor__);
		  *(undefined4 *)(param1 + 0x60) = uVar1;
		  if (DAT_ram_00a57566 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FrescoFragment___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_FrescoFragment__TypeInfo);
		    DAT_ram_00a57566 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_FrescoFragment__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_FrescoFragment___ctor__);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  AssetContent_Loaders_GameRawImageLoader__LoadAsset(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x803D", Offset = "0x803D", VA = "0x803D")]
		public FrescoFieldEditable()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Fresco_View_FrescoFieldEditable___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5756f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo);
		    DAT_ram_00a5756f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Fresco_View_FrescoFieldEditable___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001A24 RID: 6692
		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x58")]
		private FrescoEditView _view;

		// Token: 0x04001A25 RID: 6693
		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x5C")]
		private FrescoModel _model;

		// Token: 0x04001A26 RID: 6694
		[Token(Token = "0x4001A26")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<uint> _selectedCells;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnChangeSelected ---
		void Gameplay_Fresco_View_FrescoFieldEditable__add_OnChangeSelected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57568 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_List_uint___TypeInfo);
		    DAT_ram_00a57568 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_List_uint___TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_List_uint___TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x54,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnChangeSelected ---
		void Gameplay_Fresco_View_FrescoFieldEditable__remove_OnChangeSelected
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a57569 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a57569 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x5c) = param5;
		  *(int *)(param1 + 0x50) = param3;
		  *(undefined4 *)(param1 + 0x4c) = param2;
		  *(undefined4 *)(param1 + 0x58) = param4;
		  if (param3 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar1 = *(int *)(param3 + 0x24);
		    param2_00 = Core_Extensions_Dict_FrescoDicExt__GetTitle(param3,0);
		  }
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (param1,param2_00,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  Gameplay_Fresco_View_FrescoField__Init
		            (param1,*(undefined4 *)(param1 + 0x48),*(undefined4 *)(iVar1 + 0xc),
		             *(undefined4 *)(iVar1 + 0x10),param1);
		  return;
		}
		*/

}

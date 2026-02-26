using System;
using System.Collections.Generic;
using Gameplay.Clans.Office.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200025F RID: 607
	[Token(Token = "0x200025F")]
	public class ClanCursesDialogWindow : BaseDialogWindow<ClanCursesDialogWindow.ClanCursesDialogWindowArgs>
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FC")]
		public override string WindowId
		{
			[Token(Token = "0x6000EA6")]
			[Address(RVA = "0x6126", Offset = "0x6126", VA = "0x6126", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x6127", Offset = "0x6127", VA = "0x6127", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void UI_Windows_ClanCursesDialogWindow__HandleContent(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a639d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ClanCursesDialogWindow_ClanCursesDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a639d4 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ClanCursesDialogWindow_ClanCursesDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x6128", Offset = "0x6128", VA = "0x6128")]
		public ClanCursesDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_ClanCursesDialogWindow___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int param2_00;
		  uint *puVar3;
		  undefined4 param3_00;
		  int iVar4;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a639d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ClanCursesDialogWindow_ClanCursesDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ClanCurseData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4206);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4207);
		    DAT_ram_00a639d5 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ClanCursesDialogWindow_ClanCursesDialogWindowArgs___ctor__
		            );
		  *(int **)(param1 + 0x2c) = param2;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4207,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4206,1,0,1,0,0,0,0);
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_ClanCurseData__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x823271c5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_ClanCurseData__TypeInfo,0);
		code_r0x823271c5:
		  local_4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  param3_00 = func_ii_4443(&local_4,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_21978,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,param2_00,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/ClanCursesDialogWindow";

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ClanCurseView _cursePrefab;

		// Token: 0x02000260 RID: 608
		[Token(Token = "0x2000260")]
		public class ClanCursesDialogWindowArgs : BaseDialogWindow<ClanCursesDialogWindow.ClanCursesDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000EA9 RID: 3753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000EA9")]
			[Address(RVA = "0x6129", Offset = "0x6129", VA = "0x6129")]
			public ClanCursesDialogWindowArgs(IList<ClanCurseData> restrictions)
			{
			}

			// Token: 0x04000761 RID: 1889
			[Token(Token = "0x4000761")]
			[FieldOffset(Offset = "0x2C")]
			public IList<ClanCurseData> Restrictions;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_ClanCursesDialogWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  undefined4 param2_00;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a639d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ClanCursesDialogWindow_ClanCursesDialogWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ClanCursesDialogWindow_ClanCursesDialogWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ClanCursesDialogWindow_ClanCursesDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ClanCurseData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ClanCurseData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ClanCurseView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a639d3 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ClanCursesDialogWindow_ClanCursesDialogWindowArgs__HandleContent__
		            );
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ClanCursesDialogWindow_ClanCursesDialogWindowArgs__get_WindowArgs__
		                      );
		  piVar7 = *(int **)(iVar2 + 0x2c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ClanCurseData__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x82326c44;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,
		                                System_Collections_Generic_IEnumerable_ClanCurseData__TypeInfo,0);
		code_r0x82326c44:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x82326d1c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x82326f1a:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82326f22;
		    }
		code_r0x82326d1c:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x82326f1a;
		    if (iVar2 == 0) {
		      iVar2 = 0;
		      goto code_r0x82326f6b;
		    }
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ClanCurseData__TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x82326df6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ClanCurseData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x82326ef2:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82326f22;
		    }
		code_r0x82326df6:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x82326ef2;
		    uVar8 = *(undefined4 *)(param1 + 0x40);
		    param2_00 = *(undefined4 *)(param1 + 0x50);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x82326f22;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar8,
		                       Method_UnityEngine_Object_Instantiate_ClanCurseView___);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x82326f22;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x18,uVar8,uVar5,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x82326f22:
		  iVar2 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar2 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x82326f6b:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x82326fe3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x82326fe3:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      }
		      if (iVar2 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x19,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}

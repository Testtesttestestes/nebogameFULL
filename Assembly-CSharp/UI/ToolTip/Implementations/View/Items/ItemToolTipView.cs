using System;
using Gameplay.Inventory.Model;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using UI.ToolTip.Implementations.View.Parts;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Items
{
	// Token: 0x02000156 RID: 342
	[Token(Token = "0x2000156")]
	public class ItemToolTipView : BaseToolTip<IItemInformationProvider>
	{
		// Token: 0x060009D5 RID: 2517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x5D3C", Offset = "0x5D3C", VA = "0x5D3C", Slot = "6")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_ToolTip_Implementations_View_Items_ItemToolTipView__Dispose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5997e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_IItemInformationProvider__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_IItemInformationProvider__get_Data__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo);
		    DAT_ram_00a5997e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x14);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    piVar4 = *(int **)(param1 + 0x18);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81099d39;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x81099d39:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar5 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0x138) * 4))
		              (piVar4,uVar3,*(undefined4 *)(iVar5 + 0x13c));
		    Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__get_Data
		              (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x14),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x5D3D", Offset = "0x5D3D", VA = "0x5D3D", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_Items_ItemToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5997f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_IItemInformationProvider___ctor__);
		    DAT_ram_00a5997f = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_IItemInformationProvider___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x5D3E", Offset = "0x5D3E", VA = "0x5D3E")]
		public ItemToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Items_ItemToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param2_00;
		  int *piVar4;
		  undefined4 param2_01;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59980 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_BossCombatSpellData__HandleModifiers__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_BossCombatSpellData__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_MercenarieRowView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59980 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_object___HandleDescription
		            (param1,
		             Method_UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_BossCombatSpellData__HandleModifiers__
		            );
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(0 < *(int *)(*(int *)(*(int *)(param1 + 0x14) + 0x48) + 0xc)),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(*(int *)(param1 + 0x14) + 0x48),
		             Method_System_Collections_Generic_List_TeamData_TeamAssistantData__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_TeamData_TeamAssistantData__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8109a03b;
		      }
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      uVar2 = *(undefined4 *)(param1 + 0x40);
		      param2_01 = *(undefined4 *)(param1 + 0x44);
		      iVar1 = local_8._4_4_;
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8109a03b;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_01,uVar2
		                             ,Method_UnityEngine_Object_Instantiate_MercenarieRowView___);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8109a03b;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,param2_00,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8109a01f:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8109a03b;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar2,1,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8109a01f;
		    } while (*(int *)(param2_00 + 0x20) == iVar1);
		    *(int *)(param2_00 + 0x20) = iVar1;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x42,param2_00,param2_00);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8109a03b:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x43,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ItemToolTipView";

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtikulViewWhitTitle _header;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ArtifactInformationBox _informationBox;
	}
}

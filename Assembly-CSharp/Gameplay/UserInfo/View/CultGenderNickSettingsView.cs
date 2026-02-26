using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Buttons;
using UI.Price;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F1 RID: 1009
	[Token(Token = "0x20003F1")]
	public class CultGenderNickSettingsView : MonoBehaviour
	{
		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000416")]
		public PatternTextInput NickInputField
		{
			[Token(Token = "0x60017A3")]
			[Address(RVA = "0x695E", Offset = "0x695E", VA = "0x695E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000417")]
		public Button ChangeNickButton
		{
			[Token(Token = "0x60017A4")]
			[Address(RVA = "0x695F", Offset = "0x695F", VA = "0x695F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000418")]
		public Button ChangeCultGenderButton
		{
			[Token(Token = "0x60017A5")]
			[Address(RVA = "0x6960", Offset = "0x6960", VA = "0x6960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000419")]
		public Button GenerateNickButton
		{
			[Token(Token = "0x60017A6")]
			[Address(RVA = "0x6961", Offset = "0x6961", VA = "0x6961")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041A")]
		public Price ChangeCultGenderPrice
		{
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x6962", Offset = "0x6962", VA = "0x6962")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041B")]
		public Price ChangeNickPrice
		{
			[Token(Token = "0x60017A8")]
			[Address(RVA = "0x6963", Offset = "0x6963", VA = "0x6963")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041C")]
		public Toggle HideMedalsCheckBox
		{
			[Token(Token = "0x60017A9")]
			[Address(RVA = "0x6964", Offset = "0x6964", VA = "0x6964")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041D")]
		public Toggle HideAprsCheckBox
		{
			[Token(Token = "0x60017AA")]
			[Address(RVA = "0x6965", Offset = "0x6965", VA = "0x6965")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041E")]
		public GameObject HideContentControls
		{
			[Token(Token = "0x60017AB")]
			[Address(RVA = "0x6966", Offset = "0x6966", VA = "0x6966")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700041F")]
		public GameAssetViewRawImage Avatar
		{
			[Token(Token = "0x60017AC")]
			[Address(RVA = "0x6967", Offset = "0x6967", VA = "0x6967")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000114 RID: 276
		// (add) Token: 0x060017AD RID: 6061 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060017AE RID: 6062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000114")]
		public event Action OnGenderOrCultSelected
		{
			[Token(Token = "0x60017AD")]
			[Address(RVA = "0x6968", Offset = "0x6968", VA = "0x6968")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60017AE")]
			[Address(RVA = "0x6969", Offset = "0x6969", VA = "0x6969")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AF")]
		[Address(RVA = "0x696A", Offset = "0x696A", VA = "0x696A")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__OnDestroy
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_UserInfo_View_CultGenderNickSettingsView__HandleNickInputFieldStatusChanged
		            (param1,param1);
		  Gameplay_UserInfo_View_CultGenderNickSettingsView__CreateGenders(param1,param1);
		  Gameplay_UserInfo_View_CultGenderNickSettingsView__Start(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x696B", Offset = "0x696B", VA = "0x696B")]
		public void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__Start(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int param1_00;
		  undefined4 *puVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  int *piVar11;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a598cb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_CultRadioButton___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RadioButton___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_CultGenderNickSettingsView_HandleNickInputFieldStatusChanged__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28216);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a598cb = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  iVar8 = *(int *)(param1 + 0x44);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar2 = 0;
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x810876f7;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810876f7:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		  uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		  uVar5 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar5,StringLiteral_28216,0);
		  if (DAT_ram_00a598e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_RegularExpressions_Regex_TypeInfo);
		    DAT_ram_00a598e5 = '\x01';
		  }
		  iVar10 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar8 + 0x18),uVar5,0);
		  if (iVar10 == 0) {
		    *(undefined4 *)(iVar8 + 0x18) = uVar5;
		    uVar6 = unnamed_function_1417(System_Text_RegularExpressions_Regex_TypeInfo);
		    System_Xml_Schema_FacetsChecker_FacetsCompiler__Preprocess(uVar6,uVar5,0x218,0);
		    *(undefined4 *)(iVar8 + 0x1c) = uVar6;
		  }
		  iVar8 = *(int *)(param1 + 0x44);
		  uVar5 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar5,param1,
		             Method_Gameplay_UserInfo_View_CultGenderNickSettingsView_HandleNickInputFieldStatusChanged__
		             ,0);
		  if (DAT_ram_00a598e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a598e3 = '\x01';
		  }
		  iVar10 = *(int *)(iVar8 + 0x14);
		  do {
		    iVar3 = 0;
		    param1_00 = UnityEngine_UI_Image__set_sprite(iVar10,uVar5,0);
		    uVar6 = System_Action_bool__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar3 = func_ii_1082(param1_00,System_Action_bool__TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(param1_00,uVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(iVar8 + 0x14,iVar3,iVar10);
		    bVar1 = iVar3 != iVar10;
		    iVar10 = iVar3;
		  } while (bVar1);
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(*(int *)(param1 + 0x44) + 0x10),StringLiteral_5,0);
		  *(undefined4 *)(param1 + 0x6c) = *(undefined4 *)(*(int *)(param1 + 0x5c) + 0x4c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar9;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x810878cb;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810878cb:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		  uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		  uVar5 = Core_Extensions_Dict_DictExt__GetArtikulTypesBySlotId
		                    (uVar5,*(undefined4 *)(*(int *)(*(int *)(param1 + 0x5c) + 0x34) + 0x2c),0);
		  *(undefined4 *)(param1 + 0x68) = uVar5;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar9 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar7 = (undefined4 *)(iVar8 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x810879d8;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81087c50:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81087c58;
		    }
		code_r0x810879d8:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar7,piVar9,puVar7[1]);
		    piVar9 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81087c50;
		    if (iVar8 == 0) goto code_r0x81087ca1;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar7 = (undefined4 *)(piVar11[1] * 8 + iVar8 + 200);
		          goto code_r0x81087ab5;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81087c1e:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81087c58;
		    }
		code_r0x81087ab5:
		    DAT_ram_009d3e38 = 0;
		    piVar9 = (int *)import::env::invoke_iii(*puVar7,piVar9,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81087c1e;
		    if (piVar9 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar9 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar9 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar9,
		                   UnityEngine_Transform_TypeInfo);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) goto code_r0x8108826f;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81087c58;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar9 = (int *)import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x267,piVar9,
		                               Method_UnityEngine_Component_GetComponent_RadioButton___);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81087c58;
		    }
		    iVar3 = piVar9[5];
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii
		                       (*(undefined4 *)(*piVar9 + 0xe0),piVar9,*(undefined4 *)(*piVar9 + 0xe4));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81087c58;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22d,iVar3,
		               (uint)(*(int *)(param1 + 0x68) == iVar10),0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81087c58:
		  iVar8 = global_1;
		  iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar10) {
		    piVar9 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_14 = *piVar9;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x81087ca1:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar9 = (int *)*local_c;
		      if (piVar9 != (int *)0x0) {
		        iVar8 = *piVar9;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		              puVar4 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81087d31;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar9,System_IDisposable_TypeInfo,0);
		code_r0x81087d31:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x18),0);
		      local_c = &local_8;
		      local_14 = 0;
		      local_10 = &local_4;
		      do {
		        piVar9 = local_4;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar7 = (undefined4 *)(iVar8 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x81087e5b;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x810880d4:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810880dc;
		        }
		code_r0x81087e5b:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar7,piVar9,puVar7[1]);
		        piVar9 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x810880d4;
		        if (iVar8 == 0) {
		          iVar8 = 7;
		          goto code_r0x81088129;
		        }
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar7 = (undefined4 *)(piVar11[1] * 8 + iVar8 + 200);
		              goto code_r0x81087f35;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,1);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x810880ac:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810880dc;
		        }
		code_r0x81087f35:
		        DAT_ram_009d3e38 = 0;
		        piVar9 = (int *)import::env::invoke_iii(*puVar7,piVar9,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x810880ac;
		        if (piVar9 != (int *)0x0) {
		          if (((uint)*(byte *)(*piVar9 + 0xb8) <
		               (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar9 + 100) +
		                       (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		              UnityEngine_Transform_TypeInfo)) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar9,
		                       UnityEngine_Transform_TypeInfo);
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 != 1) {
		code_r0x8108826f:
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810880dc;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar9 = (int *)import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x267,piVar9,
		                                   Method_UnityEngine_Component_GetComponent_CultRadioButton___);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810880dc;
		        }
		        iVar3 = piVar9[5];
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii
		                           (*(undefined4 *)(*piVar9 + 0xe0),piVar9,*(undefined4 *)(*piVar9 + 0xe4));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810880dc;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x22d,iVar3,
		                   (uint)(*(int *)(param1 + 0x6c) == iVar10),0);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar8 != 1);
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810880dc:
		      iVar8 = global_1;
		      iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar10) {
		        piVar9 = (int *)import::env::__cxa_begin_catch(uVar5);
		        local_14 = *piVar9;
		        iVar8 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		code_r0x81088129:
		          DAT_ram_009d3e38 = 0;
		          local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		          piVar9 = (int *)*local_c;
		          if (piVar9 != (int *)0x0) {
		            iVar10 = *piVar9;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              uVar2 = 0;
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		                  puVar4 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x810881b9;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		            }
		            puVar4 = (uint *)func_ii_1080(piVar9,System_IDisposable_TypeInfo,0);
		code_r0x810881b9:
		            (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		          }
		          if (local_14 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_14);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if ((iVar8 == 0) ||
		             ((((iVar8 != 1 && (iVar8 != 2)) && (iVar8 != 3)) &&
		              (((iVar8 != 4 && (iVar8 != 5)) && ((iVar8 != 6 && (iVar8 == 7)))))))) {
		            uVar5 = Core_Extensions_Dict_CultDicExt__GetIconAssetId
		                              (*(undefined4 *)(param1 + 0x6c),0);
		            iVar8 = **(int **)(param1 + 0x1c);
		            (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		                      (*(int **)(param1 + 0x1c),uVar5,*(undefined4 *)(iVar8 + 0x2d4));
		          }
		          return;
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2d,&local_14);
		      goto joined_r0x81088211;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2c,&local_14);
		joined_r0x81088211:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x696C", Offset = "0x696C", VA = "0x696C")]
		public void UpdateInfo()
		{
		/* --- GHIDRA: UpdateInfo ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__UpdateInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a598cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11299);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a598cc = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x48);
		  uVar1 = StringLiteral_5;
		  if (param2 == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_11299,1,0,1,0,0,0,0);
		  }
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x696D", Offset = "0x696D", VA = "0x696D")]
		private void HandleNickInputFieldStatusChanged(bool status)
		{
		/* --- GHIDRA: HandleNickInputFieldStatusChanged ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__HandleNickInputFieldStatusChanged
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a598cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_CultGenderNickSettingsView_HandleGenderToggleValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GenderDic__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GenderDic__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GenderDic__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GenderDic__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_RadioButton___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a598cd = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x60),
		             Method_System_Collections_Generic_List_GenderDic__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_GenderDic__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81086fa2;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar5 = *(undefined4 *)(param1 + 0x14);
		    uVar6 = *(undefined4 *)(param1 + 0x34);
		    uVar3 = local_8._4_4_;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81086fa2;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar6,uVar5,
		                               Method_UnityEngine_Object_Instantiate_RadioButton___);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81086fa2;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x25,piVar4[5],
		               *(undefined4 *)(param1 + 0x2c),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81086fa2;
		    }
		    uVar6 = *(undefined4 *)(piVar4[5] + 0xc0);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       UnityEngine_Events_UnityAction_bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81086f7c:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81086fa2;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x26,uVar5,param1,
		               Method_Gameplay_UserInfo_View_CultGenderNickSettingsView_HandleGenderToggleValueChangedEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81086f7c;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x27,uVar6,uVar5,
		               Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81086f7c;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar4 + 0xe8),piVar4,uVar3,*(undefined4 *)(*piVar4 + 0xec));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81086fa2;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x28,uVar3,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29,piVar4,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81086fa2:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2a,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar3);
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

		// Token: 0x060017B3 RID: 6067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x696E", Offset = "0x696E", VA = "0x696E")]
		private void CreateGenders()
		{
		/* --- GHIDRA: CreateGenders ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__CreateGenders(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a598ce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_CultGenderNickSettingsView_HandleCultToggleValueChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_CultDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CultRadioButton___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CultDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a598ce = '\x01';
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param1 + 100),
		                              Method_Google_Protobuf_Collections_RepeatedField_CultDic__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x81087195;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810874a5:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810874ad;
		    }
		code_r0x81087195:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810874a5;
		    if (iVar7 == 0) {
		      iVar7 = 0;
		      goto code_r0x810874f6;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_CultDic__TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x8108726f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_CultDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81087469:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810874ad;
		    }
		code_r0x8108726f:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81087469;
		    uVar8 = *(undefined4 *)(param1 + 0x18);
		    uVar9 = *(undefined4 *)(param1 + 0x38);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810874ad;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar9,uVar8,
		                               Method_UnityEngine_Object_Instantiate_CultRadioButton___);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810874ad;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x25,piVar5[5],
		               *(undefined4 *)(param1 + 0x30),0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810874ad;
		    }
		    uVar9 = *(undefined4 *)(piVar5[5] + 0xc0);
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       UnityEngine_Events_UnityAction_bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81087491:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810874ad;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x26,uVar8,param1,
		               Method_Gameplay_UserInfo_View_CultGenderNickSettingsView_HandleCultToggleValueChangedEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81087491;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x27,uVar9,uVar8,
		               Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81087491;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar5 + 0xe8),piVar5,uVar3,*(undefined4 *)(*piVar5 + 0xec));
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810874ad:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar7 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x810874f6:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8108756e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8108756e:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (iVar7 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2b,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x696F", Offset = "0x696F", VA = "0x696F")]
		private void CreateCults()
		{
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000420")]
		public GenderDic CurrentGender
		{
			[Token(Token = "0x60017B5")]
			[Address(RVA = "0x6970", Offset = "0x6970", VA = "0x6970")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017B6")]
			[Address(RVA = "0x6971", Offset = "0x6971", VA = "0x6971")]
			private set
			{
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000421")]
		public CultDic CurrentCult
		{
			[Token(Token = "0x60017B7")]
			[Address(RVA = "0x6972", Offset = "0x6972", VA = "0x6972")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017B8")]
			[Address(RVA = "0x6973", Offset = "0x6973", VA = "0x6973")]
			private set
			{
			}
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B9")]
		[Address(RVA = "0x6974", Offset = "0x6974", VA = "0x6974")]
		private void HandleGenderToggleValueChangedEvent(bool selected)
		{
		/* --- GHIDRA: HandleGenderToggleValueChangedEvent ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__HandleGenderToggleValueChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a598d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_CultRadioButton___);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_CultDic_TypeInfo);
		    DAT_ram_00a598d0 = '\x01';
		  }
		  uVar1 = UnityEngine_UI_ToggleGroup__ActiveToggles(*(undefined4 *)(param1 + 0x30),0);
		  piVar2 = (int *)func_ii_5677(uVar1,Method_UnityEngine_Component_GetComponent_CultRadioButton___);
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe0) * 4))
		                            (piVar2,*(undefined4 *)(*piVar2 + 0xe4));
		  if ((piVar2 != (int *)0x0) && (Protocol_Dic_CultDic_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,Protocol_Dic_CultDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int **)(param1 + 0x6c) != piVar2) {
		    *(int **)(param1 + 0x6c) = piVar2;
		    iVar3 = *(int *)(param1 + 0x58);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		      piVar2 = *(int **)(param1 + 0x6c);
		    }
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetIconAssetId(piVar2,0);
		  iVar3 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x1c),uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x6975", Offset = "0x6975", VA = "0x6975")]
		private void HandleCultToggleValueChangedEvent(bool selected)
		{
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x6976", Offset = "0x6976", VA = "0x6976")]
		private void SetCultDescription(string text)
		{
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x6977", Offset = "0x6977", VA = "0x6977")]
		public CultGenderNickSettingsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a598d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_CultDic_TypeInfo);
		    DAT_ram_00a598d1 = '\x01';
		  }
		  *(int **)(param1 + 0x18) = param2;
		  if (param2 != (int *)0x0) {
		    if (Protocol_Dic_CultDic_TypeInfo != *param2) {
		      System_Activator__CreateInstance(param2,Protocol_Dic_CultDic_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = *(undefined4 *)(param1 + 0x1c);
		    param2_00 = Core_Extensions_Dict_CultDicExt__GetCultBgAssetId(param2,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _gendersOwner;

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _cultsOwner;

		// Token: 0x04000C85 RID: 3205
		[Token(Token = "0x4000C85")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _cultDescriptionField;

		// Token: 0x04000C86 RID: 3206
		[Token(Token = "0x4000C86")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _changeCultGenderButton;

		// Token: 0x04000C87 RID: 3207
		[Token(Token = "0x4000C87")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _changeNickButton;

		// Token: 0x04000C88 RID: 3208
		[Token(Token = "0x4000C88")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _generateNickButton;

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ToggleGroup _genderToggelGroup;

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ToggleGroup _cultToggleGroup;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RadioButton _radioButtonPrefab;

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4000C8C")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("_cultButtonPrefab")]
		[SerializeField]
		private CultRadioButton cultRadioButtonPrefab;

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Price _changeCultGenderPrice;

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Price _changeNickPrice;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private PatternTextInput _nickInputField;

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _nickInputStatusField;

		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Toggle _hideMedalsCheckBox;

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Toggle _hideAprsCheckBox;

		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _hideContentControls;

		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x5C")]
		public UserData User;

		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x60")]
		public List<GenderDic> Genders;

		// Token: 0x04000C97 RID: 3223
		[Token(Token = "0x4000C97")]
		[FieldOffset(Offset = "0x64")]
		public RepeatedField<CultDic> Cults;

		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		public const string NICK_DOSNT_MATCH_THE_PATTERN_LOCALE_KEY = "NICK_DOSNT_MATCH_THE_PATTERN";

		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x68")]
		private GenderDic _currentGender;

		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x6C")]
		private CultDic _currentCult;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Avatar ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__get_Avatar
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a598c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a598c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x58);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x58,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnGenderOrCultSelected ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__add_OnGenderOrCultSelected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a598c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a598c9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x58);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x58,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnGenderOrCultSelected ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__remove_OnGenderOrCultSelected
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a598ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_CultGenderNickSettingsView_HandleNickInputFieldStatusChanged__
		              );
		    DAT_ram_00a598ca = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x44);
		  param1_01 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (param1_01,param1,
		             Method_Gameplay_UserInfo_View_CultGenderNickSettingsView_HandleNickInputFieldStatusChanged__
		             ,0);
		  if (DAT_ram_00a598e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a598e4 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_CurrentGender ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__get_CurrentGender
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x68) != param2) {
		    *(int *)(param1 + 0x68) = param2;
		    iVar1 = *(int *)(param1 + 0x58);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_CurrentCult ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__get_CurrentCult
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x6c) != param2) {
		    *(int *)(param1 + 0x6c) = param2;
		    iVar1 = *(int *)(param1 + 0x58);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentCult ---
		void Gameplay_UserInfo_View_CultGenderNickSettingsView__set_CurrentCult
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a598cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RadioButton___);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_GenderDic_TypeInfo);
		    DAT_ram_00a598cf = '\x01';
		  }
		  param1_00 = UnityEngine_UI_ToggleGroup__ActiveToggles(*(undefined4 *)(param1 + 0x2c),0);
		  piVar1 = (int *)func_ii_5677(param1_00,Method_UnityEngine_Component_GetComponent_RadioButton___);
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe0) * 4))
		                            (piVar1,*(undefined4 *)(*piVar1 + 0xe4));
		  if ((piVar1 != (int *)0x0) && (Protocol_Dic_GenderDic_TypeInfo != *piVar1)) {
		    System_Activator__CreateInstance(piVar1,Protocol_Dic_GenderDic_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int **)(param1 + 0x68) != piVar1) {
		    *(int **)(param1 + 0x68) = piVar1;
		    iVar2 = *(int *)(param1 + 0x58);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

}

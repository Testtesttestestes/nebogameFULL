using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Gifts.View
{
	// Token: 0x02000708 RID: 1800
	[Token(Token = "0x2000708")]
	public class GiftView : MonoBehaviour
	{
		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082F")]
		public SocialGiftDic GiftDic
		{
			[Token(Token = "0x6002B10")]
			[Address(RVA = "0x7BAB", Offset = "0x7BAB", VA = "0x7BAB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B11")]
			[Address(RVA = "0x7BAC", Offset = "0x7BAC", VA = "0x7BAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x7BAD", Offset = "0x7BAD", VA = "0x7BAD")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Gifts_View_GiftView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a21e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Gifts_View_GiftView_HandleInfoButtonClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Gifts_View_GiftView_HandleSendGiftEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a21e = '\x01';
		  }
		  if (*(int *)(param1 + 0x20) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,Method_Gameplay_Gifts_View_GiftView_HandleInfoButtonClickEvent__,0);
		    UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_Gifts_View_GiftView_HandleSendGiftEvent__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0x7BAE", Offset = "0x7BAE", VA = "0x7BAE")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Gifts_View_GiftView__OnDestroy
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a5a21f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5a21f = '\x01';
		  }
		  *(int *)(param1 + 0x2c) = param2;
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Core_Extensions_Dict_SlotMachineSymbolDicExt__GetIconAssetId(param2,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Core_Extensions_Dict_SocialGiftDicExt__GetIconAssetId(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  param1_00 = *(int *)(param1 + 0x18);
		  if (param1_00 != 0) {
		    uVar1 = Core_Extensions_Dict_SocialGiftDicExt__GetTitle(param2,0);
		    UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		  }
		  uVar1 = *(undefined4 *)(param2 + 0x10);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  UI_Price_Price__SetColor(uVar2,param3,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x7BAF", Offset = "0x7BAF", VA = "0x7BAF")]
		public void SetGiftDic(SocialGiftDic dic, UserData userData)
		{
		/* --- GHIDRA: SetGiftDic ---
		void Gameplay_Gifts_View_GiftView__SetGiftDic
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Gifts_View_GiftView__OnDestroy(param1,param3,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B15")]
		[Address(RVA = "0x7BB0", Offset = "0x7BB0", VA = "0x7BB0")]
		public void Init(UserData userData, SocialGiftDic dic)
		{
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B16")]
		[Address(RVA = "0x7BB1", Offset = "0x7BB1", VA = "0x7BB1")]
		public void SetButtonActive(bool enable)
		{
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B17")]
		[Address(RVA = "0x7BB2", Offset = "0x7BB2", VA = "0x7BB2")]
		private void HandleSendGiftEvent()
		{
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B18")]
		[Address(RVA = "0x7BB3", Offset = "0x7BB3", VA = "0x7BB3")]
		private void HandleInfoButtonClickEvent()
		{
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B19")]
		[Address(RVA = "0x7BB4", Offset = "0x7BB4", VA = "0x7BB4")]
		public GiftView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftView___ctor
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param3;
		  uint uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int param2_00;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  int *piVar10;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a281 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_SocialGiftDic__get_Content__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SocialGiftDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_GiftView___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftsStageContentGroupView_HandleClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a5a281 = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		code_r0x811f201a:
		  piVar7 = local_4;
		  iVar9 = *local_4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		        puVar3 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		        goto code_r0x811f20b2;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x811f20f6:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f24a5;
		  }
		code_r0x811f20b2:
		  DAT_ram_009d3e38 = 0;
		  iVar9 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		  piVar7 = local_4;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x811f20f6;
		  if (iVar9 == 0) goto code_r0x811f24ee;
		  iVar9 = *local_4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		        puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar9 + 200);
		        goto code_r0x811f2199;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,1);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x811f249d:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f24a5;
		  }
		code_r0x811f2199:
		  DAT_ram_009d3e38 = 0;
		  piVar7 = (int *)import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x811f249d;
		  if (piVar7 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar7 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*piVar7 + 100) +
		                    (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		           UnityEngine_Transform_TypeInfo)) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar7,
		                 UnityEngine_Transform_TypeInfo);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 != 1) {
		code_r0x811f25eb:
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811f24a5:
		      iVar9 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar6) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		        local_14 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		code_r0x811f24ee:
		          DAT_ram_009d3e38 = 0;
		          local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		          piVar7 = (int *)*local_c;
		          if (piVar7 != (int *)0x0) {
		            iVar9 = *piVar7;
		            if (*(ushort *)(iVar9 + 0xb6) != 0) {
		              uVar2 = 0;
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		                  puVar8 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x811f257e;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		            }
		            puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x811f257e:
		            (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		          }
		          if (local_14 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(local_14);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x280,&local_14);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
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
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar7,0);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f24a5;
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar6 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x202,uVar4,
		                     Method_UnityEngine_GameObject_GetComponent_GiftView___);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f24a5;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     System_Action_SocialGiftDic__TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x811f2475:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f24a5;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viiii
		            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftsStageContentGroupView_HandleClickEvent__
		             ,0);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x811f2475;
		  if (DAT_ram_00a5a280 == '\0') {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi(0x7ff,&System_Action_SocialGiftDic__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f2475;
		    DAT_ram_00a5a280 = '\x01';
		  }
		  iVar9 = *(int *)(iVar6 + 0x18);
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar9,uVar4,0);
		    param3 = System_Action_SocialGiftDic__TypeInfo;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811f246b:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f24a5;
		    }
		    if (iVar5 == 0) {
		      param2_00 = 0;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar5,
		                             System_Action_SocialGiftDic__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811f246b;
		      if (param2_00 == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar5,param3);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) goto code_r0x811f25eb;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f24a5;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = func_ii_4329(iVar6 + 0x18,param2_00,iVar9);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f246b;
		    bVar1 = iVar9 != iVar5;
		    iVar9 = iVar5;
		  } while (bVar1);
		  goto code_r0x811f201a;
		}
		*/

		}

		// Token: 0x04001784 RID: 6020
		[Token(Token = "0x4001784")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04001785 RID: 6021
		[Token(Token = "0x4001785")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001786 RID: 6022
		[Token(Token = "0x4001786")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001787 RID: 6023
		[Token(Token = "0x4001787")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _costButton;

		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		[FieldOffset(Offset = "0x24")]
		public Action<GiftView> OnSendGiftEvent;

		// Token: 0x0400178A RID: 6026
		[Token(Token = "0x400178A")]
		[FieldOffset(Offset = "0x28")]
		public Action<GiftView> OnOpenGiftInfoEvent;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_GiftDic ---
		void Gameplay_Gifts_View_GiftView__set_GiftDic(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a21d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Gifts_View_GiftView_HandleInfoButtonClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Gifts_View_GiftView_HandleSendGiftEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8377);
		    DAT_ram_00a5a21d = '\x01';
		  }
		  if (*(int *)(param1 + 0x20) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,Method_Gameplay_Gifts_View_GiftView_HandleInfoButtonClickEvent__,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_Gifts_View_GiftView_HandleSendGiftEvent__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(param1 + 0x1c),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8377,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		  return;
		}
		*/


		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a280 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SocialGiftDic__TypeInfo);
		    DAT_ram_00a5a280 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_SocialGiftDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SocialGiftDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftView__remove_ClickEvent
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x1c) != 0) {
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftView__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if ((*(int *)(param1 + 0x1c) != param2) && (*(int *)(param1 + 0x1c) = param2, param2 != 0)) {
		    piVar2 = *(int **)(param1 + 0x10);
		    uVar1 = Core_Extensions_Dict_SocialGiftDicExt__GetIconAssetId(param2,0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = Core_Extensions_Dict_SlotMachineSymbolDicExt__GetIconAssetId
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftView__set_Data
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (*(int *)(param1 + 0x1c) != 0) {
		    piVar2 = *(int **)(param1 + 0x10);
		    uVar1 = Core_Extensions_Dict_SocialGiftDicExt__GetIconAssetId(*(int *)(param1 + 0x1c),0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = Core_Extensions_Dict_SlotMachineSymbolDicExt__GetIconAssetId
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Gifts_GiftView__HandleDataChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x1c),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}

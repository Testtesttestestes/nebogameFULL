using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Isles.Axis.Controller;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Isles.Axis.View
{
	// Token: 0x02000D03 RID: 3331
	[Token(Token = "0x2000D03")]
	public class AxisIsleView : MonoBehaviour
	{
		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06005145 RID: 20805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001077")]
		public GameSpriteRendererLoaderInteractable BgSprite
		{
			[Token(Token = "0x6005145")]
			[Address(RVA = "0x9F24", Offset = "0x9F24", VA = "0x9F24")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001EB RID: 491
		// (add) Token: 0x06005146 RID: 20806 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005147 RID: 20807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EB")]
		public event Action OnClickEvent
		{
			[Token(Token = "0x6005146")]
			[Address(RVA = "0x9F25", Offset = "0x9F25", VA = "0x9F25")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005147")]
			[Address(RVA = "0x9F26", Offset = "0x9F26", VA = "0x9F26")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001EC RID: 492
		// (add) Token: 0x06005148 RID: 20808 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005149 RID: 20809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EC")]
		public event Action<ColossusBattleData> ColossusClickedEvent
		{
			[Token(Token = "0x6005148")]
			[Address(RVA = "0x9F27", Offset = "0x9F27", VA = "0x9F27")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005149")]
			[Address(RVA = "0x9F28", Offset = "0x9F28", VA = "0x9F28")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514A")]
		[Address(RVA = "0x9F29", Offset = "0x9F29", VA = "0x9F29")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Isles_Axis_View_AxisIsleView__Start(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a58cf3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_View_AxisIsleView_ColossusClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_Axis_View_AxisIsleView_OnPointerClick__);
		    DAT_ram_00a58cf3 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Gameplay_Isles_Axis_View_AxisIsleView_OnPointerClick__,0);
		  AssetContent_Loaders_GameSpriteRendererLoaderInteractable__add_ClickEvent(uVar4,uVar3,0);
		  iVar5 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      iVar6 = *(int *)(iVar5 + iVar7 * 4 + 0x10);
		      uVar3 = unnamed_function_1417(System_Action_ColossusBattleData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Isles_Axis_View_AxisIsleView_ColossusClickedEventHandler__,0);
		      if (DAT_ram_00a58cf9 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		        DAT_ram_00a58cf9 = '\x01';
		      }
		      param1_00 = *(int *)(iVar6 + 0x44);
		      do {
		        iVar2 = 0;
		        param1_01 = func_ii_7048(param1_00,uVar3,0);
		        uVar4 = System_Action_ColossusBattleData__TypeInfo;
		        if ((param1_01 != 0) &&
		           (iVar2 = func_ii_1082(param1_01,System_Action_ColossusBattleData__TypeInfo), iVar2 == 0))
		        {
		          System_Activator__CreateInstance(param1_01,uVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar6 + 0x44,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar7 = iVar7 + 1;
		    } while (iVar7 < *(int *)(iVar5 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514B")]
		[Address(RVA = "0x9F2A", Offset = "0x9F2A", VA = "0x9F2A")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514C")]
		[Address(RVA = "0x9F2B", Offset = "0x9F2B", VA = "0x9F2B")]
		private void OnPointerClick()
		{
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514D")]
		[Address(RVA = "0x9F2C", Offset = "0x9F2C", VA = "0x9F2C")]
		private void ColossusClickedEventHandler(ColossusBattleData data)
		{
		/* --- GHIDRA: ColossusClickedEventHandler ---
		void Gameplay_Isles_Axis_View_AxisIsleView__ColossusClickedEventHandler
		               (int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int param1_00;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a58cf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_ColossusBattleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ColossusBattleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ColossusDic__TypeInfo);
		    DAT_ram_00a58cf4 = '\x01';
		  }
		  if (0 < *(int *)(*(int *)(param1 + 0x18) + 0xc)) {
		    do {
		      iVar6 = *param2;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_ICollection_ColossusBattleData__TypeInfo == *piVar7) {
		            puVar3 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80f9c108;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_ICollection_ColossusBattleData__TypeInfo
		                                    ,0);
		code_r0x80f9c108:
		      iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		      param1_00 = *(int *)(*(int *)(param1 + 0x18) + iVar2 * 4 + 0x10);
		      if (iVar2 < iVar6) {
		        iVar6 = *param2;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IList_ColossusBattleData__TypeInfo == *piVar7) {
		              puVar3 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		              goto code_r0x80f9c19f;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_IList_ColossusBattleData__TypeInfo,
		                                      0);
		code_r0x80f9c19f:
		        uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar2,puVar3[1]);
		        Gameplay_Isles_Axis_View_ColossusInWorldView__ButtonClickedEventHandler
		                  (param1_00,uVar5,puVar3);
		      }
		      else {
		        iVar6 = *param3;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IList_ColossusDic__TypeInfo == *piVar7) {
		              puVar3 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		              goto code_r0x80f9c222;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param3,System_Collections_Generic_IList_ColossusDic__TypeInfo,
		                                      0);
		code_r0x80f9c222:
		        uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param3,iVar2,puVar3[1]);
		        if (DAT_ram_00a58cfd == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Data_ColossusBattleData_TypeInfo);
		          DAT_ram_00a58cfd = '\x01';
		        }
		        if (*(int *)(Core_Data_ColossusBattleData_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_Data_ColossusBattleData_TypeInfo);
		        }
		        uVar4 = Core_Data_ColossusBattleData__Create(uVar5,0);
		        *(undefined4 *)(param1_00 + 0x40) = uVar4;
		        uVar4 = *(undefined4 *)(param1_00 + 0x1c);
		        uVar5 = Core_Extensions_Dict_ColossusDicExt__GetIconFilter(uVar5,0);
		        AssetContent_GameAssetViewSpriteRenderer__get_AssetId(uVar4,uVar5,0);
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(*(int *)(param1 + 0x18) + 0xc));
		  }
		  iVar2 = 0;
		  do {
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_ColossusBattleData__TypeInfo == *piVar7) {
		          puVar3 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80f9c30c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_ColossusBattleData__TypeInfo
		                                  ,0);
		code_r0x80f9c30c:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    if (iVar6 <= iVar2) {
		      return;
		    }
		    uVar5 = *(undefined4 *)(*(int *)(param1 + 0x18) + iVar2 * 4 + 0x10);
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_ColossusBattleData__TypeInfo == *piVar7) {
		          puVar3 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80f9c399;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_IList_ColossusBattleData__TypeInfo,0);
		code_r0x80f9c399:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,iVar2,puVar3[1]);
		    Gameplay_Isles_Axis_View_ColossusInWorldView__ButtonClickedEventHandler(uVar5,uVar4,puVar3);
		    iVar2 = iVar2 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514E")]
		[Address(RVA = "0x9F2D", Offset = "0x9F2D", VA = "0x9F2D")]
		public void UpdateViews(IList<ColossusBattleData> datas, IList<ColossusDic> colossus)
		{
		/* --- GHIDRA: UpdateViews ---
		void Gameplay_Isles_Axis_View_AxisIsleView__UpdateViews(int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58cf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_TypeInfo);
		    DAT_ram_00a58cf5 = '\x01';
		  }
		  param4 = *(undefined4 *)(param2 + 0x14);
		  param3_00 = *(undefined4 *)(param2 + 0xc);
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Isles_Axis_Controller_AxisIsleViewMediator_TypeInfo);
		  if (DAT_ram_00a58d07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AxisIsleModel__AxisIsleEvents__AxisIsleController__AxisIsleView___ctor__
		              );
		    DAT_ram_00a58d07 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_AxisIsleModel__AxisIsleEvents__AxisIsleController__AxisIsleView___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x1c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514F")]
		[Address(RVA = "0x9F2E", Offset = "0x9F2E", VA = "0x9F2E")]
		public void Init(AxisIsle isle)
		{
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005150")]
		[Address(RVA = "0x9F2F", Offset = "0x9F2F", VA = "0x9F2F")]
		public void Deinit()
		{
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005151")]
		[Address(RVA = "0x9F30", Offset = "0x9F30", VA = "0x9F30")]
		public AxisIsleView()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Isles_Axis_View_AxisIsleView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a58cf6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_Axis_View_ColossusInWorldView_UpdateState__)
		    ;
		    Mono_Security_ASN1__get_Item(&Utils_Timers_DelayedCall_TypeInfo);
		    DAT_ram_00a58cf6 = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x38);
		  if (param1_01 == 0) {
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,Method_Gameplay_Isles_Axis_View_ColossusInWorldView_UpdateState__,0)
		    ;
		    param1_01 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_01,param1_00,0);
		    *(int *)(param1 + 0x38) = param1_01;
		  }
		  return param1_01;
		}
		*/

		}

		// Token: 0x04002C3B RID: 11323
		[Token(Token = "0x4002C3B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpriteRendererLoaderInteractable _spriteLoader;

		// Token: 0x04002C3C RID: 11324
		[Token(Token = "0x4002C3C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SpriteRenderer _cloud;

		// Token: 0x04002C3D RID: 11325
		[Token(Token = "0x4002C3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ColossusInWorldView[] _colossusViews;

		// Token: 0x04002C3E RID: 11326
		[Token(Token = "0x4002C3E")]
		[FieldOffset(Offset = "0x1C")]
		private AxisIsleViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BgSprite ---
		void Gameplay_Isles_Axis_View_AxisIsleView__get_BgSprite
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58cee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58cee = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x20,param1_01,param1_00);
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


		/* --- GHIDRA: add_OnClickEvent ---
		void Gameplay_Isles_Axis_View_AxisIsleView__add_OnClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58cef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58cef = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x20,param1_01,param1_00);
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


		/* --- GHIDRA: remove_OnClickEvent ---
		void Gameplay_Isles_Axis_View_AxisIsleView__remove_OnClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58cf0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    DAT_ram_00a58cf0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ColossusBattleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ColossusBattleData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: add_ColossusClickedEvent ---
		void Gameplay_Isles_Axis_View_AxisIsleView__add_ColossusClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58cf1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    DAT_ram_00a58cf1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ColossusBattleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ColossusBattleData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ColossusClickedEvent ---
		void Gameplay_Isles_Axis_View_AxisIsleView__remove_ColossusClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a58cf2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_View_AxisIsleView_ColossusClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_Axis_View_AxisIsleView_OnPointerClick__);
		    DAT_ram_00a58cf2 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_Gameplay_Isles_Axis_View_AxisIsleView_OnPointerClick__,0);
		  AssetContent_Loaders_GameSpriteRendererLoader___ctor(uVar4,uVar3,0);
		  iVar5 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      iVar6 = *(int *)(iVar5 + iVar7 * 4 + 0x10);
		      uVar3 = unnamed_function_1417(System_Action_ColossusBattleData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar3,param1,
		                 Method_Gameplay_Isles_Axis_View_AxisIsleView_ColossusClickedEventHandler__,0);
		      if (DAT_ram_00a58cf8 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		        DAT_ram_00a58cf8 = '\x01';
		      }
		      param1_00 = *(int *)(iVar6 + 0x44);
		      do {
		        iVar2 = 0;
		        param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		        uVar4 = System_Action_ColossusBattleData__TypeInfo;
		        if ((param1_01 != 0) &&
		           (iVar2 = func_ii_1082(param1_01,System_Action_ColossusBattleData__TypeInfo), iVar2 == 0))
		        {
		          System_Activator__CreateInstance(param1_01,uVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar6 + 0x44,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar7 = iVar7 + 1;
		    } while (iVar7 < *(int *)(iVar5 + 0xc));
		  }
		  return;
		}
		*/

}

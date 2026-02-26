using System;
using AssetContent;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B80 RID: 2944
	[Token(Token = "0x2000B80")]
	public class BossTeamCaptainView : MonoBehaviour
	{
		// Token: 0x0600477E RID: 18302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600477E")]
		[Address(RVA = "0x960E", Offset = "0x960E", VA = "0x960E")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_CaptainTab_BossTeamCaptainView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a51 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossTeamCaptainView_ClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a51 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossTeamCaptainView_ClickHandlerOnOnClickEvent__,0
		            );
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600477F RID: 18303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600477F")]
		[Address(RVA = "0x960F", Offset = "0x960F", VA = "0x960F")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Boss_View_CaptainTab_BossTeamCaptainView__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param3_00;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57a52 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_ContextMenu_BossMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ContextMenu_ContextMenuController_Show_IBossMenuContext__UserContextMenu___
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    DAT_ram_00a57a52 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = Google_Protobuf_Reflection_EnumValueDescriptor__get_Name(uVar1,0);
		    param3_00 = unnamed_function_1417(Gameplay_Boss_Model_ContextMenu_BossMenuContext_TypeInfo);
		    *(undefined4 *)(param3_00 + 8) = *(undefined4 *)(param1 + 0x18);
		    if (DAT_ram_00a5a202 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Pointer_TypeInfo);
		      DAT_ram_00a5a202 = '\x01';
		    }
		    UnityEngine_InputSystem_InputControl_Vector2___ReadUnprocessedValue
		              (&local_8,*(undefined4 *)
		                         (**(int **)(UnityEngine_InputSystem_Pointer_TypeInfo + 0x5c) + 0xe8),
		               Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    local_10 = local_8;
		    UI_ContextMenu_ContextMenuController___Show_b__13_0___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		              (uVar1,1,param3_00,&local_10,
		               Method_UI_ContextMenu_ContextMenuController_Show_IBossMenuContext__UserContextMenu___
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004780 RID: 18304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004780")]
		[Address(RVA = "0x9610", Offset = "0x9610", VA = "0x9610")]
		private void ClickHandlerOnOnClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06004781 RID: 18305 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004782 RID: 18306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4C")]
		public TeamData.TeamCaptainData CaptainData
		{
			[Token(Token = "0x6004781")]
			[Address(RVA = "0x9611", Offset = "0x9611", VA = "0x9611")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004782")]
			[Address(RVA = "0x9612", Offset = "0x9612", VA = "0x9612")]
			set
			{
			}
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004783")]
		[Address(RVA = "0x9613", Offset = "0x9613", VA = "0x9613")]
		public BossTeamCaptainView()
		{
		}

		// Token: 0x0400274A RID: 10058
		[Token(Token = "0x400274A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x0400274C RID: 10060
		[Token(Token = "0x400274C")]
		[FieldOffset(Offset = "0x18")]
		private TeamData.TeamCaptainData _captainData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CaptainData ---
		void Gameplay_Boss_View_CaptainTab_BossTeamCaptainView__get_CaptainData
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57a53 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a57a53 = '\x01';
		  }
		  *(int **)(param1 + 0x18) = param2;
		  if (param2 != (int *)0x0) {
		    param1_00 = *(undefined4 *)(param1 + 0x10);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0xe4));
		    param2_00 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId
		                          (*(undefined4 *)(*(int *)(iVar1 + 0x38) + 0x10),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,param2_00,0);
		  }
		  return;
		}
		*/

}

using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core;
using Gameplay.Tutorial.Guide.Control;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Gameplay.Tutorial.Guide.View.Components;
using Gameplay.TutorialV2.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x02000460 RID: 1120
	[Token(Token = "0x2000460")]
	public class GuideView : MonoBehaviour
	{
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A4")]
		public Transform GraphicPointer
		{
			[Token(Token = "0x6001A97")]
			[Address(RVA = "0x6C2A", Offset = "0x6C2A", VA = "0x6C2A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A5")]
		public ShapePointer ShapePointer
		{
			[Token(Token = "0x6001A98")]
			[Address(RVA = "0x6C2B", Offset = "0x6C2B", VA = "0x6C2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A6")]
		public DevGuideStepEditorToolView EditStepTool
		{
			[Token(Token = "0x6001A99")]
			[Address(RVA = "0x6C2C", Offset = "0x6C2C", VA = "0x6C2C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x6C2D", Offset = "0x6C2D", VA = "0x6C2D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Tutorial_Guide_View_GuideView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 param4;
		  int iVar7;
		  
		  if (DAT_ram_00a58453 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Control_GuideViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_GuideView_HandleOverlapClickEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58453 = '\x01';
		  }
		  AssetContent_GameAssetViewRawImage__get_Interactable(*(undefined4 *)(param1 + 0x14),0,0);
		  iVar4 = *(int *)(param1 + 0x10);
		  *(int *)(iVar4 + 0x20) = param1;
		  uVar5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_Tutorial_Guide_View_GuideView_HandleOverlapClickEvent__,0)
		  ;
		  Gameplay_Tutorial_Guide_View_Components_Description___ctor(uVar5,uVar2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar6;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1e8);
		        goto code_r0x80eed9d0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x80eed9d0:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = **(int **)(iVar4 + 0x10);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (*(int **)(iVar4 + 0x10),*(undefined4 *)(iVar7 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar6;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1e8);
		        goto code_r0x80eeda95;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x80eeda95:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  iVar7 = **(int **)(iVar4 + 0x10);
		  uVar5 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x110) * 4))
		                    (*(int **)(iVar4 + 0x10),*(undefined4 *)(iVar7 + 0x114));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar6;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1e8);
		        goto code_r0x80eedb5a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x80eedb5a:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x10);
		  piVar6 = (int *)unnamed_function_1417(Gameplay_Tutorial_Guide_Control_GuideViewMediator_TypeInfo);
		  Gameplay_Tutorial_Guide_Control_GuideViewMediator__Dispose(piVar6,uVar2,uVar5,param4,0);
		  *(int **)(param1 + 0x28) = piVar6;
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (piVar6,param1,*(undefined4 *)(*piVar6 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x6C2E", Offset = "0x6C2E", VA = "0x6C2E")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Tutorial_Guide_View_GuideView__Start(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  undefined8 uVar2;
		  float fVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  float fVar6;
		  float fVar7;
		  undefined8 uVar8;
		  int iVar9;
		  uint uVar10;
		  float4 local_8;
		  float4 local_10;
		  undefined8 local_20;
		  undefined8 local_18;
		  
		  uVar10 = 0;
		  if (DAT_ram_00a58454 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    DAT_ram_00a58454 = '\x01';
		  }
		  if (*(char *)(param1 + 0x38) != '\0') {
		    param1_00 = *(int **)(param1 + 0x34);
		    uVar4 = Utils_Cam_FlickerFixer___ctor(0);
		    iVar9 = *param1_00;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 0xd8);
		          goto code_r0x80eedc5e;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo
		                                  ,3);
		code_r0x80eedc5e:
		    (**(code **)((ulonglong)*puVar5 * 4))(&local_20,param1_00,uVar4,puVar5[1]);
		    _local_8 = local_18;
		    uVar2 = _local_8;
		    _local_10 = local_20;
		    uVar8 = _local_10;
		    local_10 = (float4)((ulonglong)local_20 >> 0x20);
		    fVar1 = (float)local_10;
		    local_8 = (float4)((ulonglong)local_18 >> 0x20);
		    fVar3 = (float)local_8;
		    local_10 = (float4)local_20;
		    local_8 = (float4)local_18;
		    fVar7 = (float)local_8 * 0.5;
		    fVar6 = (float)local_10 + fVar7;
		    _local_10 = uVar8;
		    _local_8 = uVar2;
		    iVar9 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x30),0);
		    uVar8 = *(undefined8 *)(*(int *)(iVar9 + 0x24) + 0x10);
		    _local_10 = CONCAT44((fVar1 + fVar3 * 0.5 + (float)((ulonglong)uVar8 >> 0x20)) - fVar3 * 0.5,
		                         (fVar6 + (float)uVar8) - fVar7);
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__set_OverlapType
		              (*(undefined4 *)(param1 + 0x10),&local_10,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x6C2F", Offset = "0x6C2F", VA = "0x6C2F")]
		private void LateUpdate()
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A7")]
		public GuideConfig Config
		{
			[Token(Token = "0x6001A9D")]
			[Address(RVA = "0x6C30", Offset = "0x6C30", VA = "0x6C30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A9E")]
			[Address(RVA = "0x6C31", Offset = "0x6C31", VA = "0x6C31")]
			private set
			{
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A8")]
		public IGuideTarget Target
		{
			[Token(Token = "0x6001A9F")]
			[Address(RVA = "0x6C32", Offset = "0x6C32", VA = "0x6C32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AA0")]
			[Address(RVA = "0x6C33", Offset = "0x6C33", VA = "0x6C33")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x6C34", Offset = "0x6C34", VA = "0x6C34")]
		public void Run([NotNull] IGuideTarget target, [NotNull] GuideConfig config)
		{
		/* --- GHIDRA: Run ---
		void Gameplay_Tutorial_Guide_View_GuideView__Run(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  if (*(int *)(iVar1 + 8) < 1) {
		    Gameplay_Tutorial_Guide_View_GuideView__UpdateShapePointerDraw(param1,param1);
		    return;
		  }
		  Gameplay_Tutorial_Guide_View_GuideView__HandleOldRevision(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x6C35", Offset = "0x6C35", VA = "0x6C35")]
		private void UpdateMessageBubble()
		{
		/* --- GHIDRA: UpdateMessageBubble ---
		void Gameplay_Tutorial_Guide_View_GuideView__UpdateMessageBubble(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a58456 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_GuideView_GraphicPointerOnReadyEvent__);
		    DAT_ram_00a58456 = '\x01';
		  }
		  if (*(char *)(param1 + 0x38) != '\0') {
		    uVar2 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Tutorial_Guide_View_GuideView_GraphicPointerOnReadyEvent__,0);
		    AssetContent_GameAssetViewRawImage__add_ReadyEvent(uVar2,uVar1,0);
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__StopDraw
		              (*(undefined4 *)(param1 + 0x10),0.0,0);
		    *(undefined4 *)(param1 + 0x34) = 0;
		    param1_00 = *(int *)(param1 + 0x30);
		    if (param1_00 != 0) {
		      *(undefined4 *)(param1 + 0x30) = 0;
		      if (DAT_ram_00a58457 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        Mono_Security_ASN1__get_Item
		                  (&Method_Gameplay_Tutorial_Guide_View_GuideView_HandleStepLayoutConfigChanged__);
		        DAT_ram_00a58457 = '\x01';
		      }
		      uVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor(param1_00,0);
		      uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar2,param1,
		                 Method_Gameplay_Tutorial_Guide_View_GuideView_HandleStepLayoutConfigChanged__,0);
		      Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__add_ChangedEvent(uVar1,uVar2,0);
		    }
		    *(undefined1 *)(param1 + 0x38) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x6C36", Offset = "0x6C36", VA = "0x6C36")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Gameplay_Tutorial_Guide_View_GuideView__Stop(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined1 auStack_50 [8];
		  undefined8 local_48;
		  undefined4 local_40;
		  undefined8 local_38 [2];
		  undefined8 local_28;
		  float local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_c;
		  float4 local_4;
		  
		  Gameplay_Tutorial_Guide_View_GuideView__Complete(param1,auStack_50);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  local_20 = *(float *)(*(int *)(iVar2 + 0x28) + 0xc) * 0.017453292;
		  local_28 = 0;
		  local_c = 0;
		  local_4 = (float4)local_20;
		  UnityEngine_Quaternion__Lerp(&local_1c,&local_28,0);
		  local_38[0] = local_1c;
		  UnityEngine_Transform__get_localRotation(uVar1,local_38,0);
		  Gameplay_Tutorial_Guide_View_GuideView__SetupGraphicPointerScale(param1,auStack_50);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  local_48 = *(undefined8 *)(*(int *)(iVar2 + 0x28) + 0x18);
		  local_14 = 0;
		  local_40 = 0;
		  local_1c = local_48;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_48,0);
		  iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  if (*(int *)(iVar2 + 8) < 1) {
		    Gameplay_Tutorial_Guide_View_GuideView__UpdateShapePointerDraw(param1,auStack_50);
		  }
		  else {
		    Gameplay_Tutorial_Guide_View_GuideView__HandleOldRevision(param1,auStack_50);
		  }
		  Gameplay_Tutorial_Guide_View_Components_Description__HandleConfigChanged
		            (*(undefined4 *)(param1 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x6C37", Offset = "0x6C37", VA = "0x6C37")]
		public void HandleStepLayoutConfigChanged()
		{
		/* --- GHIDRA: HandleStepLayoutConfigChanged ---
		void Gameplay_Tutorial_Guide_View_GuideView__HandleStepLayoutConfigChanged
		               (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58457 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_GuideView_HandleStepLayoutConfigChanged__);
		    DAT_ram_00a58457 = '\x01';
		  }
		  if (param3 != 0) {
		    uVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor(param3,0);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_GuideView_HandleStepLayoutConfigChanged__,0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig__get_StepLayoutConfig(uVar1,uVar2,0);
		  }
		  if (param2 != 0) {
		    uVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor(param2,0);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Tutorial_Guide_View_GuideView_HandleStepLayoutConfigChanged__,0);
		    Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__add_ChangedEvent(uVar1,uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x6C38", Offset = "0x6C38", VA = "0x6C38")]
		private void HandleConfigChanged(GuideConfig from, GuideConfig to)
		{
		/* --- GHIDRA: HandleConfigChanged ---
		void Gameplay_Tutorial_Guide_View_GuideView__HandleConfigChanged(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  if ((*(int *)(*(int *)(iVar1 + 0x24) + 0xc) == 2) && (iVar1 = *(int *)(param1 + 0x2c), iVar1 != 0)
		     ) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x30),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x6C39", Offset = "0x6C39", VA = "0x6C39")]
		private void HandleOverlapClickEvent()
		{
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x6C3A", Offset = "0x6C3A", VA = "0x6C3A")]
		public void Complete(GuideConfig config)
		{
		/* --- GHIDRA: Complete ---
		void Gameplay_Tutorial_Guide_View_GuideView__Complete(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  undefined8 uVar2;
		  float fVar3;
		  uint uVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 param1_00;
		  float fVar9;
		  float fVar10;
		  undefined8 uVar11;
		  int iVar12;
		  float4 local_8;
		  float4 local_10;
		  undefined8 local_24;
		  undefined8 local_1c;
		  int *local_14;
		  
		  if (DAT_ram_00a58458 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideShapePointer___
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_View_IOverrideGuideShapePointer_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_Model_Shapes_RuntimeGeneratedShape_TypeInfo);
		    DAT_ram_00a58458 = '\x01';
		  }
		  local_14 = (int *)0x0;
		  piVar8 = *(int **)(param1 + 0x34);
		  uVar5 = Utils_Cam_FlickerFixer___ctor(0);
		  iVar12 = *piVar8;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar4 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar4 * 8 + 4) * 8 + iVar12 + 0xd8);
		        goto code_r0x80eee6a4;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar4);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,3);
		code_r0x80eee6a4:
		  (**(code **)((ulonglong)*puVar6 * 4))(&local_24,piVar8,uVar5,puVar6[1]);
		  _local_8 = local_1c;
		  uVar2 = _local_8;
		  _local_10 = local_24;
		  uVar11 = _local_10;
		  local_10 = (float4)((ulonglong)local_24 >> 0x20);
		  fVar1 = (float)local_10;
		  local_8 = (float4)((ulonglong)local_1c >> 0x20);
		  fVar3 = (float)local_8;
		  uVar4 = 0;
		  local_10 = (float4)local_24;
		  local_8 = (float4)local_1c;
		  fVar10 = (float)local_8 * 0.5;
		  fVar9 = (float)local_10 + fVar10;
		  _local_10 = uVar11;
		  _local_8 = uVar2;
		  iVar7 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  iVar12 = 
		  Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideShapePointer___
		  ;
		  uVar11 = *(undefined8 *)(*(int *)(iVar7 + 0x24) + 0x10);
		  _local_10 = CONCAT44((fVar1 + fVar3 * 0.5 + (float)((ulonglong)uVar11 >> 0x20)) - fVar3 * 0.5,
		                       (fVar9 + (float)uVar11) - fVar10);
		  piVar8 = *(int **)(param1 + 0x34);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (*(int *)(
		                  Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideShapePointer___
		                  + 0x10) == *(int *)(*(int *)(iVar7 + 0x58) + uVar4 * 8)) {
		        iVar7 = iVar7 + (*(int *)(*(int *)(iVar7 + 0x58) + uVar4 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideShapePointer___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x80eee7a7;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar4);
		  }
		  iVar7 = func_ii_1080(piVar8,*(int *)(
		                                      Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideShapePointer___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideShapePointer___
		                              + 0x2c));
		code_r0x80eee7a7:
		  iVar12 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                     (*(undefined4 *)(iVar7 + 4),iVar12);
		  iVar12 = (**(code **)((ulonglong)*(uint *)(iVar12 + 4) * 4))(piVar8,&local_14,iVar12);
		  if (iVar12 == 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x10);
		    uVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x30),0);
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__SetRect(param1_00,uVar5,&local_10,0);
		  }
		  else {
		    uVar4 = 0;
		    uVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x30),0);
		    iVar12 = Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__ToString(uVar5,0);
		    piVar8 = local_14;
		    *(undefined1 *)(*(int *)(iVar12 + 0x24) + 0x28) = 1;
		    iVar7 = *local_14;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_View_IOverrideGuideShapePointer_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar4 * 8)) {
		          puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar4 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80eee855;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar4);
		    }
		    puVar6 = (uint *)func_ii_1080(local_14,
		                                  Gameplay_Tutorial_Guide_View_IOverrideGuideShapePointer_TypeInfo,0
		                                 );
		code_r0x80eee855:
		    uVar5 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		    iVar7 = unnamed_function_1417
		                      (Gameplay_Tutorial_Guide_Model_Shapes_RuntimeGeneratedShape_TypeInfo);
		    Unity_Services_Core_Registration_CorePackageInitializer__get_MetricsFactory(iVar7,uVar5,0);
		    *(int *)(iVar7 + 8) = iVar12;
		    Gameplay_Tutorial_Guide_View_Components_ShapePointer__StartDraw
		              (*(undefined4 *)(param1 + 0x10),iVar7,&local_10,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x6C3B", Offset = "0x6C3B", VA = "0x6C3B")]
		public void UpdateShapePointerDraw()
		{
		/* --- GHIDRA: UpdateShapePointerDraw ---
		void Gameplay_Tutorial_Guide_View_GuideView__UpdateShapePointerDraw(int param1,undefined4 param2)
		
		{
		  float4 fVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  int iVar3;
		  float fVar4;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined1 auStack_10 [8];
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a58459 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a58459 = '\x01';
		  }
		  Gameplay_Tutorial_Guide_View_Components_Description__get_GuideConfig
		            (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x30),0);
		  uVar2 = func_ii_5677(*(undefined4 *)(param1 + 0x1c),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  param2_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  UnityEngine_Transform___ctor(auStack_10,uVar2,0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_10,param2_00,0);
		  fVar1 = local_4;
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_10,uVar2,0);
		  iVar3 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  fVar4 = *(float *)(iVar3 + 0x1c);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_10,uVar2,0);
		  iVar3 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  local_20 = CONCAT44(fVar4 * -((float)fVar1 - (float)local_4),
		                      (float)local_8 * *(float *)(iVar3 + 0x20));
		  local_18 = local_20;
		  DG_Tweening_DOTweenModuleUI__DOScale(uVar2,&local_20,0.5,0,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x6C3C", Offset = "0x6C3C", VA = "0x6C3C")]
		private void HandleOldRevision()
		{
		/* --- GHIDRA: HandleOldRevision ---
		void Gameplay_Tutorial_Guide_View_GuideView__HandleOldRevision(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined1 auStack_30 [8];
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  float4 local_14;
		  undefined4 local_10;
		  float4 local_c;
		  undefined4 local_8 [2];
		  
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  Gameplay_TutorialV2_View_MessageBubbleView__SetPosition
		            (uVar3,*(undefined4 *)(iVar1 + 0x18),auStack_30);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  iVar1 = *(int *)(param1 + 0x20);
		  uVar3 = Core_Extensions_Dict_TriggerDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1 + 0x30) + 0x10),0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(iVar1 + 0x1c),uVar3,0);
		  iVar4 = **(int **)(iVar1 + 0x1c);
		  fVar2 = (float)(**(code **)((ulonglong)*(uint *)(iVar4 + 0x368) * 4))
		                           (*(int **)(iVar1 + 0x1c),*(undefined4 *)(iVar4 + 0x36c));
		  iVar4 = *(int *)(iVar1 + 0x2c);
		  uVar3 = *(undefined4 *)(iVar1 + 0x20);
		  UnityEngine_RectTransform__set_anchoredPosition(local_8,uVar3,0);
		  local_10 = local_8[0];
		  if (fVar2 <= (float)iVar4) {
		    fVar2 = (float)iVar4;
		  }
		  local_20 = CONCAT44(fVar2,local_8[0]);
		  local_c = (float4)fVar2;
		  UnityEngine_RectTransform__get_sizeDelta(uVar3,&local_20,0);
		  uVar3 = *(undefined4 *)(iVar1 + 0x28);
		  UnityEngine_RectTransform__set_anchoredPosition(local_8,uVar3,0);
		  local_14 = (float4)(fVar2 * 0.5);
		  if (64.0 <= (float)local_14) {
		    local_14 = 64.0;
		  }
		  local_18 = local_8[0];
		  local_28 = CONCAT44(local_14,local_8[0]);
		  UnityEngine_RectTransform__get_sizeDelta(uVar3,&local_28,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x6C3D", Offset = "0x6C3D", VA = "0x6C3D")]
		private void HandleNewRevision()
		{
		/* --- GHIDRA: HandleNewRevision ---
		void Gameplay_Tutorial_Guide_View_GuideView__HandleNewRevision(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  float local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined8 local_c;
		  float4 local_4;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x14),0);
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  local_20 = *(float *)(*(int *)(iVar1 + 0x28) + 0xc) * 0.017453292;
		  local_28 = 0;
		  local_c = 0;
		  local_4 = (float4)local_20;
		  UnityEngine_Quaternion__Lerp(&local_1c,&local_28,0);
		  local_30 = local_14;
		  local_38 = local_1c;
		  UnityEngine_Transform__get_localRotation(param1_00,&local_38,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAB")]
		[Address(RVA = "0x6C3E", Offset = "0x6C3E", VA = "0x6C3E")]
		private void SetupGraphicPointerAngle()
		{
		/* --- GHIDRA: SetupGraphicPointerAngle ---
		void Gameplay_Tutorial_Guide_View_GuideView__SetupGraphicPointerAngle(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x14),0);
		  iVar1 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  local_18 = *(undefined8 *)(*(int *)(iVar1 + 0x28) + 0x18);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = local_18;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(param1_00,&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAC")]
		[Address(RVA = "0x6C3F", Offset = "0x6C3F", VA = "0x6C3F")]
		private void SetupGraphicPointerScale()
		{
		/* --- GHIDRA: SetupGraphicPointerScale ---
		void Gameplay_Tutorial_Guide_View_GuideView__SetupGraphicPointerScale(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param1_00;
		  int iVar7;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  int *local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5845a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_GuideView_GraphicPointerOnReadyEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideGraphicPointerAnimationState___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_IOverrideGuideGraphicPointerAnimationState_TypeInfo);
		    DAT_ram_00a5845a = '\x01';
		  }
		  local_10 = (int *)0x0;
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80eee39b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eee39b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  iVar6 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetPortalStagesCount
		                    (uVar3,*(undefined4 *)(*(int *)(iVar6 + 0x28) + 8),0);
		  uVar3 = Core_Extensions_Dict_TutorialStepDicExt__GetDialog(uVar3,0);
		  iVar6 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                    (uVar4,uVar3,0);
		  if (iVar6 != 0) {
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x14),0);
		    local_28 = 0;
		    local_4 = 0;
		    local_30 = 0;
		    local_c = 0;
		    UnityEngine_Quaternion__Lerp(&local_20,&local_30,0);
		    local_38 = local_18;
		    local_40 = local_20;
		    UnityEngine_Transform__get_localRotation(uVar4,&local_40,0);
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Tutorial_Guide_View_GuideView_GraphicPointerOnReadyEvent__,0);
		    AssetContent_GameAssetViewRawImage__get_IsReady(param1_00,uVar4,0);
		  }
		  iVar6 = 
		  Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideGraphicPointerAnimationState___
		  ;
		  piVar5 = *(int **)(param1 + 0x34);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (*(int *)(
		                  Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideGraphicPointerAnimationState___
		                  + 0x10) == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        iVar7 = iVar7 + (*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) +
		                        (uint)*(ushort *)
		                               (
		                               Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideGraphicPointerAnimationState___
		                               + 0x2c)) * 8 + 0xc0;
		        goto code_r0x80eee4e2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  iVar7 = func_ii_1080(piVar5,*(int *)(
		                                      Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideGraphicPointerAnimationState___
		                                      + 0x10),
		                       (uint)*(ushort *)
		                              (
		                              Method_Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TryGetOverrides_IOverrideGuideGraphicPointerAnimationState___
		                              + 0x2c));
		code_r0x80eee4e2:
		  iVar6 = System_Runtime_CompilerServices_AsyncTaskMethodBuilder_SerializableProjectConfiguration___AwaitUnsafeOnCompleted_TaskAwaiter_object___StreamingAssetsConfigurationLoader__GetConfigAsync_d__2_
		                    (*(undefined4 *)(iVar7 + 4),iVar6);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 4) * 4))(piVar5,&local_10,iVar6);
		  if (iVar6 == 0) {
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(param1 + 0x14),0,0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(param1 + 0x14),uVar3,0);
		  }
		  else {
		    uVar1 = 0;
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(param1 + 0x14),uVar3,0);
		    piVar5 = local_10;
		    uVar4 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0x18);
		    iVar6 = *local_10;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_View_IOverrideGuideGraphicPointerAnimationState_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80eee594;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(local_10,
		                                  Gameplay_Tutorial_Guide_View_IOverrideGuideGraphicPointerAnimationState_TypeInfo
		                                  ,0);
		code_r0x80eee594:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    AssetContent_GameAnimationView__OnDestroy(uVar4,uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAD")]
		[Address(RVA = "0x6C40", Offset = "0x6C40", VA = "0x6C40")]
		private void SetupGraphicPointerView()
		{
		/* --- GHIDRA: SetupGraphicPointerView ---
		void Gameplay_Tutorial_Guide_View_GuideView__SetupGraphicPointerView
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  float local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined8 local_c;
		  float4 local_4;
		  
		  if (DAT_ram_00a5845b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_GuideView_GraphicPointerOnReadyEvent__);
		    Mono_Security_ASN1__get_Item(&Core_IAsyncLoadableContent_TypeInfo);
		    DAT_ram_00a5845b = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Tutorial_Guide_View_GuideView_GraphicPointerOnReadyEvent__
		             ,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IAsyncLoadableContent_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80eeed10;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_IAsyncLoadableContent_TypeInfo,2);
		code_r0x80eeed10:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  iVar4 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  local_20 = *(float *)(*(int *)(iVar4 + 0x28) + 0xc) * 0.017453292;
		  local_28 = 0;
		  local_c = 0;
		  local_4 = (float4)local_20;
		  UnityEngine_Quaternion__Lerp(&local_1c,&local_28,0);
		  local_30 = local_14;
		  local_38 = local_1c;
		  UnityEngine_Transform__get_localRotation(uVar2,&local_38,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAE")]
		[Address(RVA = "0x6C41", Offset = "0x6C41", VA = "0x6C41")]
		private void GraphicPointerOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AAF")]
		[Address(RVA = "0x6C42", Offset = "0x6C42", VA = "0x6C42")]
		public GuideView()
		{
		}

		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ShapePointer _shapePointer;

		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAssetViewRawImage _graphicPointer;

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _graphicPointerMoveRoot;

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Description _description;

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MessageBubbleView _messageBubble;

		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DevGuideStepEditorToolView _editStepTool;

		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		[FieldOffset(Offset = "0x28")]
		private GuideViewMediator _mediator;

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0x2C")]
		public Action<GuideConfig> ResolveCompleteEvent;

		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x30")]
		private GuideConfig _config;

		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000E5F")]
		[FieldOffset(Offset = "0x38")]
		private bool _isRun;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_EditStepTool ---
		void Gameplay_Tutorial_Guide_View_GuideView__get_EditStepTool(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a58452 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tutorial_Guide_View_GuideView_HandleOverlapClickEvent__);
		    DAT_ram_00a58452 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Tutorial_Guide_View_GuideView_HandleOverlapClickEvent__,0);
		  Gameplay_Tutorial_Guide_View_Components_Overlap__add_ClickEvent(param1_01,param1_00,0);
		  iVar1 = **(int **)(param1 + 0x28);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x28),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x28) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: get_Config ---
		void Gameplay_Tutorial_Guide_View_GuideView__get_Config(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  param2_00 = *(int *)(param1 + 0x30);
		  if (param2 != param2_00) {
		    *(int *)(param1 + 0x30) = param2;
		    Gameplay_Tutorial_Guide_View_GuideView__HandleStepLayoutConfigChanged
		              (param1,param2_00,param2,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Target ---
		void Gameplay_Tutorial_Guide_View_GuideView__set_Target
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined1 auStack_50 [8];
		  undefined8 local_48;
		  undefined4 local_40;
		  undefined8 local_38 [2];
		  undefined8 local_28;
		  float local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_c;
		  float4 local_4;
		  
		  if (DAT_ram_00a58455 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTarget__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_GuideView___c__DisplayClass26_0__Run_g__HandleResolveTargetEvent_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_GuideView___c__DisplayClass26_0_TypeInfo);
		    DAT_ram_00a58455 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_Tutorial_Guide_View_GuideView___c__DisplayClass26_0_TypeInfo);
		  *(int *)(iVar2 + 0xc) = param3;
		  *(int *)(iVar2 + 8) = param1;
		  *(undefined4 *)(param1 + 0x34) = param2;
		  iVar5 = *(int *)(param1 + 0x30);
		  if (param3 != iVar5) {
		    *(int *)(param1 + 0x30) = param3;
		    Gameplay_Tutorial_Guide_View_GuideView__HandleStepLayoutConfigChanged
		              (param1,iVar5,param3,auStack_50);
		    param3 = *(int *)(param1 + 0x30);
		  }
		  uVar3 = Core_Extensions_Dict_TriggerDicExt__GetDescription(*(undefined4 *)(param3 + 0x10),0);
		  iVar5 = func_ii_4769(uVar3,0);
		  if (iVar5 == 0) {
		    iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                      (*(undefined4 *)(param1 + 0x30),0);
		    if (*(int *)(iVar5 + 8) < 1) {
		      Gameplay_Tutorial_Guide_View_GuideView__UpdateShapePointerDraw(param1,auStack_50);
		    }
		    else {
		      Gameplay_Tutorial_Guide_View_GuideView__HandleOldRevision(param1,auStack_50);
		    }
		  }
		  else {
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		  }
		  iVar5 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  if (*(int *)(*(int *)(iVar5 + 0x24) + 0xc) == 1) {
		    param1_00 = *(int **)(param1 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_IGuideTarget__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,iVar2,
		               Method_Gameplay_Tutorial_Guide_View_GuideView___c__DisplayClass26_0__Run_g__HandleResolveTargetEvent_0__
		               ,0);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80eedf50;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo
		                                  ,0);
		code_r0x80eedf50:
		    (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,puVar4[1]);
		  }
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  local_20 = *(float *)(*(int *)(iVar2 + 0x28) + 0xc) * 0.017453292;
		  local_28 = 0;
		  local_c = 0;
		  local_4 = (float4)local_20;
		  UnityEngine_Quaternion__Lerp(&local_1c,&local_28,0);
		  local_38[0] = local_1c;
		  UnityEngine_Transform__get_localRotation(uVar3,local_38,0);
		  Gameplay_Tutorial_Guide_View_GuideView__SetupGraphicPointerScale(param1,auStack_50);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x14),0);
		  iVar2 = Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor
		                    (*(undefined4 *)(param1 + 0x30),0);
		  local_48 = *(undefined8 *)(*(int *)(iVar2 + 0x28) + 0x18);
		  local_14 = 0;
		  local_40 = 0;
		  local_1c = local_48;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar3,&local_48,0);
		  Gameplay_Tutorial_Guide_View_GuideView__Complete(param1,auStack_50);
		  *(undefined1 *)(param1 + 0x38) = 1;
		  return;
		}
		*/

}

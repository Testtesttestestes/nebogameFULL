using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F8 RID: 1528
	[Token(Token = "0x20005F8")]
	public class MedalView : AbstractDataRenderer<MedalDicWrapper>, IPointerClickHandler, IEventSystemHandler, IToolTipDataProvider
	{
		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000070E0 File Offset: 0x000052E0
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F0")]
		public InteractiveBehavior Mode
		{
			[Token(Token = "0x6002511")]
			[Address(RVA = "0x765B", Offset = "0x765B", VA = "0x765B")]
			[CompilerGenerated]
			get
			{
				return InteractiveBehavior.Default;
			}
			[Token(Token = "0x6002512")]
			[Address(RVA = "0x765C", Offset = "0x765C", VA = "0x765C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F1")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6002513")]
			[Address(RVA = "0x765D", Offset = "0x765D", VA = "0x765D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F2")]
		public MedalData MedalData
		{
			[Token(Token = "0x6002514")]
			[Address(RVA = "0x765E", Offset = "0x765E", VA = "0x765E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002515")]
			[Address(RVA = "0x765F", Offset = "0x765F", VA = "0x765F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F3")]
		private MedalDic MedalDic
		{
			[Token(Token = "0x6002516")]
			[Address(RVA = "0x7660", Offset = "0x7660", VA = "0x7660")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400014D RID: 333
		// (add) Token: 0x06002517 RID: 9495 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002518 RID: 9496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014D")]
		public event Action<MedalView> ClickEvent
		{
			[Token(Token = "0x6002517")]
			[Address(RVA = "0x7661", Offset = "0x7661", VA = "0x7661")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002518")]
			[Address(RVA = "0x7662", Offset = "0x7662", VA = "0x7662")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x000070F8 File Offset: 0x000052F8
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F4")]
		public bool Achieved
		{
			[Token(Token = "0x6002519")]
			[Address(RVA = "0x7663", Offset = "0x7663", VA = "0x7663")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600251A")]
			[Address(RVA = "0x7664", Offset = "0x7664", VA = "0x7664")]
			set
			{
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F5")]
		public bool SaleEnabled
		{
			[Token(Token = "0x600251B")]
			[Address(RVA = "0x7665", Offset = "0x7665", VA = "0x7665")]
			set
			{
			}
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251C")]
		[Address(RVA = "0x1C12", Offset = "0x1C12", VA = "0x1C12")]
		private void ValidateRankAndAchievement()
		{
		/* --- GHIDRA: ValidateRankAndAchievement ---
		int * Gameplay_Medals_View_MedalView__ValidateRankAndAchievement(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600251D RID: 9501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251D")]
		[Address(RVA = "0x7666", Offset = "0x7666", VA = "0x7666")]
		private void HandleAchievedChanged(bool fromValue, bool toValue)
		{
		/* --- GHIDRA: HandleAchievedChanged ---
		void Gameplay_Medals_View_MedalView__HandleAchievedChanged
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57d8e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d8e = '\x01';
		  }
		  if (param1[0x10] != 0) {
		    if ((param1[0x10] == 1) && (iVar3 = param1[0x13], iVar3 != 0)) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),param1,*(undefined4 *)(iVar3 + 0x14));
		    }
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x130);
		        goto code_r0x80e5956f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e5956f:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  Core_Gameplay_Managers_MedalsManager__Deinit(param1_00,*(undefined4 *)(iVar3 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x7667", Offset = "0x7667", VA = "0x7667", Slot = "20")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		int Gameplay_Medals_View_MedalView__OnPointerClick(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  int iVar7;
		  undefined4 param4;
		  
		  if (DAT_ram_00a57d8f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Implementations_VO_MedalToolTipVO_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_MedalToolTipVO___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_MedalToolTipVO__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_MedalToolTipVO__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12538);
		    DAT_ram_00a57d8f = '\x01';
		  }
		  iVar2 = unnamed_function_1417(UI_ToolTip_Implementations_VO_MedalToolTipVO_TypeInfo);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  *(undefined4 *)(iVar2 + 8) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e596db;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e596db:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  uVar3 = Core_Extensions_Dict_DictExt__TryGetArtikulDismantleInfoDic
		                    (uVar3,*(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x20),0);
		  *(undefined4 *)(iVar2 + 0xc) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x80e597b2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e597b2:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x80e59864;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e59864:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  param4 = *(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x2c);
		  param1_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		            (param1_00,uVar3,uVar5,param4,0);
		  *(undefined4 *)(iVar2 + 0x10) = param1_00;
		  if (param1[0x12] != 0) {
		    *(undefined4 *)(iVar2 + 0x14) = *(undefined4 *)(param1[0x12] + 0x1c);
		  }
		  iVar7 = unnamed_function_1417(UI_ToolTip_ToolTipData_MedalToolTipVO__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (iVar7,StringLiteral_12538,Method_UI_ToolTip_ToolTipData_MedalToolTipVO___ctor__);
		  *(int *)(iVar7 + 0x1c) = iVar2;
		  return iVar7;
		}
		*/

		}

		// Token: 0x0600251F RID: 9503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x7668", Offset = "0x7668", VA = "0x7668", Slot = "21")]
		public BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_Medals_View_MedalView__GetData(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 param2_00;
		  int iVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a57d90 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    DAT_ram_00a57d90 = '\x01';
		  }
		  iVar5 = param1[9];
		  if (DAT_ram_00a57d8a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a57d8a = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  uVar3 = Core_Extensions_Dict_LocalNotificationDicExt__GetBody(*(undefined4 *)(iVar2 + 0x10),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(iVar5,uVar3,0);
		  UI_RawImageWithGrayscale__SetGrayscale(param1,iVar5);
		  if (param1[0x10] != 2) {
		    if (DAT_ram_00a57d89 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		      DAT_ram_00a57d89 = '\x01';
		    }
		    piVar6 = (int *)param1[0x11];
		    if (piVar6 == (int *)0x0) {
		      piVar6 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___)
		      ;
		    }
		    param1[0x11] = (int)piVar6;
		    uVar1 = 0;
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80e59a32;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4)
		    ;
		code_r0x80e59a32:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    if (DAT_ram_00a57d89 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		      DAT_ram_00a57d89 = '\x01';
		    }
		    piVar6 = (int *)param1[0x11];
		    if (piVar6 == (int *)0x0) {
		      piVar6 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___)
		      ;
		    }
		    param1[0x11] = (int)piVar6;
		    iVar5 = Mono_Security_ASN1Convert__ToOid(long___TypeInfo,1);
		    if (DAT_ram_00a57d8a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__)
		      ;
		      DAT_ram_00a57d8a = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    *(ulonglong *)(iVar5 + 0x10) = (ulonglong)*(uint *)(*(int *)(iVar2 + 0x10) + 0xc);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe8);
		          goto code_r0x80e59b42;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,5)
		    ;
		code_r0x80e59b42:
		    param2_00 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,iVar5,puVar4[1]);
		    UnityEngine_Object__op_Implicit(uVar3,param2_00,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002520")]
		[Address(RVA = "0x7669", Offset = "0x7669", VA = "0x7669", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Medals_View_MedalView__HandleDataChanged(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d91 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_MedalDicWrapper___ctor__);
		    DAT_ram_00a57d91 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x50) = 1;
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_MedalDicWrapper___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002521")]
		[Address(RVA = "0x766A", Offset = "0x766A", VA = "0x766A")]
		public MedalView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Medals_MedalView___ctor
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a5a27d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MedalDicWrapper__get_Content__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_MedalView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_Milestone_StageContentData_MedalDicWrapper__get_InteractiveMode__
		              );
		    DAT_ram_00a5a27d = '\x01';
		  }
		  if ((param3 != 0) && (iVar2 = *(int *)(param3 + 8), 0 < *(int *)(iVar2 + 0xc))) {
		    do {
		      iVar3 = *(int *)(iVar2 + iVar6 * 4 + 0x10);
		      uVar4 = *(undefined4 *)(param1 + 0x14);
		      param1_00 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar1 = func_ii_6805(param1_00,uVar4,Method_UnityEngine_Object_Instantiate_MedalView___);
		      piVar5 = *(int **)(iVar1 + 0x10);
		      uVar4 = func_ii_14054(*(undefined4 *)(iVar3 + 0x10),0);
		      iVar7 = *piVar5;
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		                (piVar5,uVar4,*(undefined4 *)(iVar7 + 0x2d4));
		      iVar7 = **(int **)(iVar1 + 0x14);
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0x138) * 4))
		                (*(int **)(iVar1 + 0x14),iVar3,*(undefined4 *)(iVar7 + 0x13c));
		      iVar3 = *(int *)(iVar1 + 0x14);
		      uVar4 = Gameplay_GdEvents_Model_Milestone_StageContentData___Il2CppFullySharedGenericType____ctor
		                        (param3,
		                         Method_Gameplay_GdEvents_Model_Milestone_StageContentData_MedalDicWrapper__get_InteractiveMode__
		                        );
		      *(undefined4 *)(iVar3 + 0x40) = uVar4;
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Medals_View_MedalView___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57d92 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalViewSelectable__TypeInfo);
		    DAT_ram_00a57d92 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MedalViewSelectable__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MedalViewSelectable__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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

		}

		// Token: 0x04001443 RID: 5187
		[Token(Token = "0x4001443")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameRawImage _icon;

		// Token: 0x04001444 RID: 5188
		[Token(Token = "0x4001444")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameRawImage _bg;

		// Token: 0x04001445 RID: 5189
		[Token(Token = "0x4001445")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected RawImageWithGrayscale _rankBg;

		// Token: 0x04001446 RID: 5190
		[Token(Token = "0x4001446")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected TextMeshProUGUI _rankLabel;

		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected Texture _rankBgTexture;

		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Texture _noRankBgTexture;

		// Token: 0x04001449 RID: 5193
		[Token(Token = "0x4001449")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected GameObject _saleIcon;

		// Token: 0x0400144B RID: 5195
		[Token(Token = "0x400144B")]
		[FieldOffset(Offset = "0x44")]
		private IGuideTarget _guideTarget;

		// Token: 0x0400144E RID: 5198
		[Token(Token = "0x400144E")]
		[FieldOffset(Offset = "0x50")]
		private bool _achieved;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Mode ---
		int Gameplay_Medals_View_MedalView__set_Mode(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57d89 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a57d89 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  *(int *)(param1 + 0x44) = iVar1;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: set_MedalData ---
		undefined4 Gameplay_Medals_View_MedalView__set_MedalData(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57d8a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a57d8a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  return *(undefined4 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_MedalDic ---
		void Gameplay_Medals_View_MedalView__get_MedalDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57d8b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    DAT_ram_00a57d8b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MedalView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MedalView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
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


		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Medals_View_MedalView__add_ClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57d8c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    DAT_ram_00a57d8c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MedalView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MedalView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
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


		/* --- GHIDRA: get_Achieved ---
		void Gameplay_Medals_View_MedalView__get_Achieved(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  float param2_00;
		  
		  *(char *)(param1 + 0x14) = (char)param2;
		  param2_00 = 0.0;
		  if (param2 == 0) {
		    param2_00 = 1.0;
		  }
		  Core_Data_MedalData__IsMedalAchieved(param1[9],param2_00,0);
		  Core_Data_MedalData__IsMedalAchieved(param1[10],param2_00,0);
		  Core_Data_MedalData__IsMedalAchieved(param1[0xb],param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    UI_RawImageWithGrayscale__SetGrayscale(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Achieved ---
		void Gameplay_Medals_View_MedalView__set_Achieved(int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x3c),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_SaleEnabled ---
		void Gameplay_Medals_View_MedalView__set_SaleEnabled
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  float param2_00;
		  
		  param2_00 = 0.0;
		  if (param3 == 0) {
		    param2_00 = 1.0;
		  }
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x24),param2_00,0);
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x28),param2_00,0);
		  Core_Data_MedalData__IsMedalAchieved(*(undefined4 *)(param1 + 0x2c),param2_00,0);
		  return;
		}
		*/

}

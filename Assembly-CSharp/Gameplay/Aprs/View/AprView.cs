using System;
using System.Runtime.CompilerServices;
using AssetContent;
using AssetContent.Loaders;
using Core;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay;
using Gameplay.Aprs.Model;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D52 RID: 3410
	[Token(Token = "0x2000D52")]
	public class AprView : AbstractDataRenderer<AprDicWrapper>, IAprView, IToolTipDataProvider, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x140001FD RID: 509
		// (add) Token: 0x06005384 RID: 21380 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005385 RID: 21381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FD")]
		public event Action<AprView> ClickEvent
		{
			[Token(Token = "0x6005384")]
			[Address(RVA = "0xA143", Offset = "0xA143", VA = "0xA143")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005385")]
			[Address(RVA = "0xA144", Offset = "0xA144", VA = "0xA144")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001FE RID: 510
		// (add) Token: 0x06005386 RID: 21382 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005387 RID: 21383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FE")]
		public static event Action RequestNotifyStencilStateChangedEvent
		{
			[Token(Token = "0x6005386")]
			[Address(RVA = "0xA145", Offset = "0xA145", VA = "0xA145")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005387")]
			[Address(RVA = "0xA146", Offset = "0xA146", VA = "0xA146")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06005388 RID: 21384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010FA")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6005388")]
			[Address(RVA = "0xA147", Offset = "0xA147", VA = "0xA147")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06005389 RID: 21385 RVA: 0x0000F180 File Offset: 0x0000D380
		// (set) Token: 0x0600538A RID: 21386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FB")]
		public InteractiveBehavior Mode
		{
			[Token(Token = "0x6005389")]
			[Address(RVA = "0xA148", Offset = "0xA148", VA = "0xA148")]
			[CompilerGenerated]
			get
			{
				return InteractiveBehavior.Default;
			}
			[Token(Token = "0x600538A")]
			[Address(RVA = "0xA149", Offset = "0xA149", VA = "0xA149")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x0600538B RID: 21387 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600538C RID: 21388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FC")]
		public AprGridView AprGridView
		{
			[Token(Token = "0x600538B")]
			[Address(RVA = "0xA14A", Offset = "0xA14A", VA = "0xA14A")]
			get
			{
				return null;
			}
			[Token(Token = "0x600538C")]
			[Address(RVA = "0xA14B", Offset = "0xA14B", VA = "0xA14B")]
			set
			{
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x0600538D RID: 21389 RVA: 0x0000F198 File Offset: 0x0000D398
		// (set) Token: 0x0600538E RID: 21390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FD")]
		public bool Achieved
		{
			[Token(Token = "0x600538D")]
			[Address(RVA = "0xA14C", Offset = "0xA14C", VA = "0xA14C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600538E")]
			[Address(RVA = "0xA14D", Offset = "0xA14D", VA = "0xA14D")]
			set
			{
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x0600538F RID: 21391 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		// (set) Token: 0x06005390 RID: 21392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FE")]
		private bool IsPointerOver
		{
			[Token(Token = "0x600538F")]
			[Address(RVA = "0xA14E", Offset = "0xA14E", VA = "0xA14E")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005390")]
			[Address(RVA = "0xA14F", Offset = "0xA14F", VA = "0xA14F")]
			set
			{
			}
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005391")]
		[Address(RVA = "0xA150", Offset = "0xA150", VA = "0xA150")]
		private void HandleAchievedChanged()
		{
		/* --- GHIDRA: HandleAchievedChanged ---
		void Gameplay_Aprs_View_AprView__HandleAchievedChanged(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Aprs_View_AprView__HandleIsPointerOverChanged(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005392 RID: 21394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005392")]
		[Address(RVA = "0xA151", Offset = "0xA151", VA = "0xA151")]
		private void HandleIsPointerOverChanged()
		{
		/* --- GHIDRA: HandleIsPointerOverChanged ---
		void Gameplay_Aprs_View_AprView__HandleIsPointerOverChanged(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  char cVar2;
		  int iVar3;
		  float param2_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a593fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a593fb = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar3 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar1 = Core_Extensions_Dict_AprDicExt__IsIndividual(*(undefined4 *)(iVar1 + 0x10),0);
		  }
		  cVar2 = '\x01';
		  if ((char)param1[0x15] == '\0') {
		    cVar2 = *(char *)((int)param1 + 0x55);
		  }
		  if (DAT_ram_00a59409 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59409 = '\x01';
		  }
		  iVar3 = param1[9];
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = UnityEngine_Component__GetComponent_object_(iVar3,0);
		  if (iVar3 != 0) {
		    param2_00 = 0.0;
		    if (iVar1 == 0 && cVar2 == '\0') {
		      param2_00 = 1.0;
		    }
		    AssetContent_GameAssetViewRawImage__get_AssetPath(param1[9],param2_00,0.0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005393")]
		[Address(RVA = "0xA152", Offset = "0xA152", VA = "0xA152")]
		private void ValidateGrayScale()
		{
		/* --- GHIDRA: ValidateGrayScale ---
		void Gameplay_Aprs_View_AprView__ValidateGrayScale(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a593fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a593fc = '\x01';
		  }
		  iVar4 = param1[10];
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar4 = func_ii_3812(iVar4,0,0);
		  if (iVar4 == 0) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar4 = *(int *)(*(int *)(iVar4 + 0x10) + 0x24);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[10],0);
		    if (iVar4 != 0) {
		      uVar1 = 0;
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      iVar4 = param1[10];
		      param1_00 = (int *)param1[0x14];
		      iVar5 = *param1_00;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		            goto code_r0x80ffdf1f;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ffdf1f:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		      uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      uVar2 = Core_Extensions_Dict_DictExt__GetEventTagDic
		                        (uVar2,*(undefined4 *)(*(int *)(iVar5 + 0x10) + 0x28),0);
		      uVar2 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetAprRibbonAssetId(uVar2,0);
		      Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		                (iVar4,uVar2,
		                 Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                );
		      return;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005394")]
		[Address(RVA = "0xA153", Offset = "0xA153", VA = "0xA153")]
		private void DrawRibbon()
		{
		/* --- GHIDRA: DrawRibbon ---
		void Gameplay_Aprs_View_AprView__DrawRibbon(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a593fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    DAT_ram_00a593fd = '\x01';
		  }
		  iVar6 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x130) * 4))
		                    (param1,*(undefined4 *)(iVar6 + 0x134));
		  if (iVar2 != 0) {
		    Gameplay_Aprs_View_AprView__ValidateGrayScale(param1,iVar6);
		    iVar6 = param1[0xb];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar2 = Core_Extensions_Dict_AprDicExt__IsSpecial(*(undefined4 *)(iVar2 + 0x10),0);
		    if (iVar2 == 0) {
		      piVar5 = param1 + 0xc;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      if (*(char *)(*(int *)(iVar2 + 0x10) + 0x20) != '\0') {
		        piVar5 = param1 + 0xd;
		      }
		    }
		    else {
		      piVar5 = param1 + 0xe;
		    }
		    func_ii_7050(iVar6,*piVar5,0);
		    if (DAT_ram_00a593f9 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		      DAT_ram_00a593f9 = '\x01';
		    }
		    piVar5 = (int *)param1[0x12];
		    if (piVar5 == (int *)0x0) {
		      piVar5 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___)
		      ;
		    }
		    param1[0x12] = (int)piVar5;
		    uVar1 = 0;
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x80ffe0e1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4)
		    ;
		code_r0x80ffe0e1:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    if (DAT_ram_00a593f9 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		      DAT_ram_00a593f9 = '\x01';
		    }
		    piVar5 = (int *)param1[0x12];
		    if (piVar5 == (int *)0x0) {
		      piVar5 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___)
		      ;
		    }
		    param1[0x12] = (int)piVar5;
		    uVar1 = 0;
		    iVar2 = Mono_Security_ASN1Convert__ToOid(long___TypeInfo,1);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    *(ulonglong *)(iVar2 + 0x10) = (ulonglong)*(uint *)(*(int *)(iVar6 + 0x10) + 0xc);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		          goto code_r0x80ffe1d1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,5)
		    ;
		code_r0x80ffe1d1:
		    param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,iVar2,puVar3[1]);
		    UnityEngine_Object__op_Implicit(uVar4,param2_00,0);
		    Gameplay_Aprs_View_AprView__SetAsset(param1,puVar3);
		  }
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  iVar2 = *param1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 400) * 4))(param1,uVar4,*(undefined4 *)(iVar2 + 0x194));
		  Gameplay_Aprs_View_AprView__HandleIsPointerOverChanged(param1,iVar2);
		  return;
		}
		*/

		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005395")]
		[Address(RVA = "0xA154", Offset = "0xA154", VA = "0xA154", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Aprs_View_AprView__HandleDataChanged(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a593fe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a593fe = '\x01';
		  }
		  if (param2 == 0) {
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1[9],0,0);
		    return;
		  }
		  param1_00 = param1[9];
		  iVar1 = param1[0x10];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if ((char)iVar1 != '\0') {
		    uVar3 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(iVar2 + 0x10),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar3,0);
		    return;
		  }
		  uVar3 = Core_Extensions_Dict_AprDicExt__Get128AssetId(*(undefined4 *)(iVar2 + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005396")]
		[Address(RVA = "0xA155", Offset = "0xA155", VA = "0xA155", Slot = "26")]
		protected virtual void SetAsset(AprDicWrapper data)
		{
		/* --- GHIDRA: SetAsset ---
		void Gameplay_Aprs_View_AprView__SetAsset(undefined4 param1,undefined4 param2)
		
		{
		  int *param1_00;
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *local_4;
		  
		  if (DAT_ram_00a593ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_IAprDiscountWidget___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_DiscountWidget_IAprDiscountWidget_TypeInfo);
		    DAT_ram_00a593ff = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar2 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (param1,&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_IAprDiscountWidget___);
		  param1_00 = local_4;
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    uVar3 = Gameplay_Aprs_View_AprView__OnPointerExit(param1,0);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Aprs_View_DiscountWidget_IAprDiscountWidget_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80ffe2f2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Aprs_View_DiscountWidget_IAprDiscountWidget_TypeInfo,0);
		code_r0x80ffe2f2:
		    (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,puVar4[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005397")]
		[Address(RVA = "0xA156", Offset = "0xA156", VA = "0xA156")]
		private void HandleDiscountWidget()
		{
		/* --- GHIDRA: HandleDiscountWidget ---
		void Gameplay_Aprs_View_AprView__HandleDiscountWidget(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x50) = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  return;
		}
		*/

		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005398")]
		[Address(RVA = "0xA157", Offset = "0xA157", VA = "0xA157", Slot = "9")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Aprs_View_AprView__Awake(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59400 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprDicWrapper__OnDisable__);
		    DAT_ram_00a59400 = '\x01';
		  }
		  UI_AbstractDataRenderer_object___OnDataInvalidated
		            (param1,Method_UI_AbstractDataRenderer_AprDicWrapper__OnDisable__);
		  if (*(char *)(param1 + 0x54) != '\0') {
		    *(undefined1 *)(param1 + 0x54) = 0;
		    Gameplay_Aprs_View_AprView__HandleIsPointerOverChanged(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005399")]
		[Address(RVA = "0xA158", Offset = "0xA158", VA = "0xA158", Slot = "7")]
		protected override void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_Aprs_View_AprView__OnDisable(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59401 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprDicWrapper__Dispose__);
		    DAT_ram_00a59401 = '\x01';
		  }
		  UI_AbstractDataRenderer_object___CommitProperties
		            (param1,Method_UI_AbstractDataRenderer_AprDicWrapper__Dispose__);
		  *(undefined4 *)(param1 + 0x50) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600539A RID: 21402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539A")]
		[Address(RVA = "0xA159", Offset = "0xA159", VA = "0xA159", Slot = "10")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Aprs_View_AprView__Dispose(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a59402 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59402 = '\x01';
		  }
		  if (param1[0x16] != 0) {
		    if ((param1[0x16] == 1) && (iVar3 = param1[0x11], iVar3 != 0)) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),param1,*(undefined4 *)(iVar3 + 0x14));
		    }
		    return;
		  }
		  uVar1 = 0;
		  param1_01 = (int *)param1[0x14];
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x138);
		        goto code_r0x80ffe881;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x80ffe881:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  Core_Gameplay_Managers_AprsManager__ShowOwnAprInfoWindow
		            (param1_00,*(undefined4 *)(iVar3 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x0600539B RID: 21403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539B")]
		[Address(RVA = "0xA15A", Offset = "0xA15A", VA = "0xA15A", Slot = "27")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Aprs_View_AprView__OnPointerClick(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59403 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprView_TypeInfo);
		    DAT_ram_00a59403 = '\x01';
		  }
		  if (*(char *)(param1 + 0x54) == '\0') {
		    *(undefined1 *)(param1 + 0x54) = 1;
		    Gameplay_Aprs_View_AprView__HandleIsPointerOverChanged(param1,param1);
		  }
		  iVar1 = **(int **)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539C")]
		[Address(RVA = "0xA15B", Offset = "0xA15B", VA = "0xA15B", Slot = "24")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		void Gameplay_Aprs_View_AprView__OnPointerEnter(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59404 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprView_TypeInfo);
		    DAT_ram_00a59404 = '\x01';
		  }
		  if (*(char *)(param1 + 0x54) != '\0') {
		    *(undefined1 *)(param1 + 0x54) = 0;
		    Gameplay_Aprs_View_AprView__HandleIsPointerOverChanged(param1,param1);
		  }
		  iVar1 = **(int **)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539D")]
		[Address(RVA = "0xA15C", Offset = "0xA15C", VA = "0xA15C", Slot = "25")]
		public void OnPointerExit(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerExit ---
		undefined4 Gameplay_Aprs_View_AprView__OnPointerExit(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined4 uVar5;
		  int param4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59405 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59405 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[0x13],0);
		  if ((iVar2 == 0) ||
		     (iVar2 = *(int *)param1[0x13],
		     iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		                       ((int *)param1[0x13],*(undefined4 *)(iVar2 + 0x134)), iVar2 == 0)) {
		    uVar1 = 0;
		    param1_00 = (int *)param1[0x14];
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x138);
		          goto code_r0x80ffe405;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x80ffe405:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    param4 = *param1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(param4 + 0x130) * 4))
		                      (param1,*(undefined4 *)(param4 + 0x134));
		    iVar2 = Gameplay_Aprs_Model_AprsModel___ctor
		                      (uVar5,*(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xc),&local_4,param4);
		    if (iVar2 == 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      unnamed_function_2232
		                (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		      local_8 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xc);
		      uVar5 = func_ii_1081(DAT_ram_00a66958,&local_8);
		      uVar4 = unnamed_function_2232(&StringLiteral_3183);
		      uVar5 = func_ii_4419(uVar4,uVar5,0);
		      uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar4 = unnamed_function_1417(uVar4);
		      System_String__Concat(uVar4,uVar5,0);
		      uVar5 = unnamed_function_2232(&Method_Gameplay_Aprs_View_AprView_GetAprData__);
		      func_ii_1050(uVar4,uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    iVar2 = *(int *)param1[0x13];
		    local_4 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		                        ((int *)param1[0x13],*(undefined4 *)(iVar2 + 0x134));
		  }
		  return local_4;
		}
		*/

		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600539E")]
		[Address(RVA = "0xA15D", Offset = "0xA15D", VA = "0xA15D")]
		public AprData GetAprData()
		{
		/* --- GHIDRA: GetAprData ---
		int Gameplay_Aprs_View_AprView__GetAprData(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  undefined4 param3;
		  undefined4 param2_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a59406 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Implementations_VO_AprToolTipVO_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_AprToolTipVO___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_AprToolTipVO__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_AprToolTipVO__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12522);
		    DAT_ram_00a59406 = '\x01';
		  }
		  iVar1 = Gameplay_Aprs_View_AprView__OnPointerExit(param1,param1);
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_AprToolTipVO__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12522,Method_UI_ToolTip_ToolTipData_AprToolTipVO___ctor__);
		  iVar2 = unnamed_function_1417(UI_ToolTip_Implementations_VO_AprToolTipVO_TypeInfo);
		  *(int *)(iVar2 + 8) = iVar1;
		  param3 = *(undefined4 *)(iVar1 + 0x20);
		  param2_00 = *(undefined4 *)(iVar1 + 0x24);
		  param4 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x10) + 0x2c);
		  param1_01 = unnamed_function_1417
		                        (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		            (param1_01,param2_00,param3,param4,0);
		  *(undefined4 *)(iVar2 + 0xc) = param1_01;
		  *(int *)(param1_00 + 0x1c) = iVar2;
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600539F")]
		[Address(RVA = "0xA15E", Offset = "0xA15E", VA = "0xA15E", Slot = "22")]
		public BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_Aprs_View_AprView__GetData(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59407 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprDicWrapper__StartListenEvents__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__add_DataChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprView_DataOnDataChangedEvent__);
		    DAT_ram_00a59407 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Aprs_View_AprView_DataOnDataChangedEvent__,0);
		  Core_Dict_DictWrappers_Base_AbstractDictWrapper_object__uint___Dispose
		            (param2,param1_00,
		             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__add_DataChangedEvent__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A0")]
		[Address(RVA = "0xA15F", Offset = "0xA15F", VA = "0xA15F", Slot = "17")]
		protected override void StartListenEvents(AprDicWrapper data)
		{
		/* --- GHIDRA: StartListenEvents ---
		void Gameplay_Aprs_View_AprView__StartListenEvents
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59408 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprDicWrapper__StopListenEvents__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__remove_DataChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprView_DataOnDataChangedEvent__);
		    DAT_ram_00a59408 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Aprs_View_AprView_DataOnDataChangedEvent__,0);
		  Core_Dict_DictWrappers_Base_AbstractDictWrapper_object__uint___get_Id
		            (param2,param1_00,
		             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__remove_DataChangedEvent__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A1")]
		[Address(RVA = "0xA160", Offset = "0xA160", VA = "0xA160", Slot = "18")]
		protected override void StopListenEvents(AprDicWrapper data)
		{
		/* --- GHIDRA: StopListenEvents ---
		void Gameplay_Aprs_View_AprView__StopListenEvents(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Aprs_View_AprView__SetAsset(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A2")]
		[Address(RVA = "0xA161", Offset = "0xA161", VA = "0xA161")]
		private void DataOnDataChangedEvent()
		{
		/* --- GHIDRA: DataOnDataChangedEvent ---
		void Gameplay_Aprs_View_AprView__DataOnDataChangedEvent
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59409 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59409 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 != 0) {
		    AssetContent_GameAssetViewRawImage__get_AssetPath
		              (*(undefined4 *)(param1 + 0x24),param2,param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A3")]
		[Address(RVA = "0xA162", Offset = "0xA162", VA = "0xA162")]
		public void SetGrayscale(float value, float duration)
		{
		/* --- GHIDRA: SetGrayscale ---
		void Gameplay_Aprs_View_AprView__SetGrayscale(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5940a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprDicWrapper___ctor__);
		    DAT_ram_00a5940a = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x55) = 1;
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_AprDicWrapper___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A4")]
		[Address(RVA = "0xA163", Offset = "0xA163", VA = "0xA163")]
		public AprView()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Aprs_View_AprView___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  undefined4 param4;
		  int iVar6;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a5940b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Implementations_VO_AprToolTipVO_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_AprToolTipVO___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_AprToolTipVO__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_AprToolTipVO__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12522);
		    DAT_ram_00a5940b = '\x01';
		  }
		  local_4 = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x138);
		        goto code_r0x80ffecb3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x80ffecb3:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar4 = *(undefined4 *)(iVar3 + 0x14);
		  iVar6 = *param1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x130) * 4))
		                    (param1,*(undefined4 *)(iVar6 + 0x134));
		  iVar3 = Gameplay_Aprs_Model_AprsModel___ctor
		                    (uVar4,*(undefined4 *)(*(int *)(iVar3 + 0x10) + 0xc),&local_4,iVar6);
		  if (iVar3 == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    unnamed_function_2232
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    local_8 = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0xc);
		    uVar4 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar5 = unnamed_function_2232(&StringLiteral_3183);
		    uVar4 = func_ii_4419(uVar5,uVar4,0);
		    uVar5 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar5 = unnamed_function_1417(uVar5);
		    System_String__Concat(uVar5,uVar4,0);
		    uVar4 = unnamed_function_2232(&Method_Gameplay_Aprs_View_AprViewSmall_GetData__);
		    func_ii_1050(uVar5,uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = unnamed_function_1417(UI_ToolTip_ToolTipData_AprToolTipVO__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (iVar3,StringLiteral_12522,Method_UI_ToolTip_ToolTipData_AprToolTipVO___ctor__);
		  iVar6 = unnamed_function_1417(UI_ToolTip_Implementations_VO_AprToolTipVO_TypeInfo);
		  *(int *)(iVar6 + 8) = local_4;
		  uVar5 = *(undefined4 *)(local_4 + 0x20);
		  param2_00 = *(undefined4 *)(local_4 + 0x24);
		  param4 = *(undefined4 *)(*(int *)(*(int *)(local_4 + 0x14) + 0x10) + 0x2c);
		  uVar4 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		            (uVar4,param2_00,uVar5,param4,0);
		  *(undefined4 *)(iVar6 + 0xc) = uVar4;
		  *(int *)(iVar3 + 0x1c) = iVar6;
		  return iVar3;
		}
		*/

		}

		// Token: 0x04002D45 RID: 11589
		[Token(Token = "0x4002D45")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameAssetViewRawImage _gameAssetView;

		// Token: 0x04002D46 RID: 11590
		[Token(Token = "0x4002D46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameRawImageLoader _ribbon;

		// Token: 0x04002D47 RID: 11591
		[Token(Token = "0x4002D47")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04002D48 RID: 11592
		[Token(Token = "0x4002D48")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _bgDefaultSprite;

		// Token: 0x04002D49 RID: 11593
		[Token(Token = "0x4002D49")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Sprite _bgSilverSprite;

		// Token: 0x04002D4A RID: 11594
		[Token(Token = "0x4002D4A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _bgGoldSprite;

		// Token: 0x04002D4B RID: 11595
		[Token(Token = "0x4002D4B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04002D4C RID: 11596
		[Token(Token = "0x4002D4C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _use128Asset;

		// Token: 0x04002D4F RID: 11599
		[Token(Token = "0x4002D4F")]
		[FieldOffset(Offset = "0x48")]
		private IGuideTarget _guideTarget;

		// Token: 0x04002D50 RID: 11600
		[Token(Token = "0x4002D50")]
		[FieldOffset(Offset = "0x4C")]
		private AprGridView _aprGridView;

		// Token: 0x04002D51 RID: 11601
		[Token(Token = "0x4002D51")]
		[FieldOffset(Offset = "0x50")]
		protected IGame _game;

		// Token: 0x04002D52 RID: 11602
		[Token(Token = "0x4002D52")]
		[FieldOffset(Offset = "0x54")]
		private bool _isPointerOver;

		// Token: 0x04002D53 RID: 11603
		[Token(Token = "0x4002D53")]
		[FieldOffset(Offset = "0x55")]
		private bool _achieved;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Aprs_View_AprView__add_ClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a593f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprView__TypeInfo);
		    DAT_ram_00a593f6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_AprView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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
		void Gameplay_Aprs_View_AprView__remove_ClickEvent(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a593f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprView_TypeInfo);
		    DAT_ram_00a593f7 = '\x01';
		  }
		  param1_00 = **(int **)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param1,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(*(undefined4 *)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c),param1_01,
		                         param1_00);
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


		/* --- GHIDRA: add_RequestNotifyStencilStateChangedEvent ---
		void Gameplay_Aprs_View_AprView__add_RequestNotifyStencilStateChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a593f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprView_TypeInfo);
		    DAT_ram_00a593f8 = '\x01';
		  }
		  param1_00 = **(int **)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param1,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(*(undefined4 *)(Gameplay_Aprs_View_AprView_TypeInfo + 0x5c),param1_01,
		                         param1_00);
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


		/* --- GHIDRA: remove_RequestNotifyStencilStateChangedEvent ---
		int Gameplay_Aprs_View_AprView__remove_RequestNotifyStencilStateChangedEvent
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a593f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a593f9 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x48);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  *(int *)(param1 + 0x48) = iVar1;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_AprGridView ---
		void Gameplay_Aprs_View_AprView__get_AprGridView(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a593fa == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a593fa = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x4c) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x3c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param2_00 = UnityEngine_Component__GetComponent_object_(param2,0);
		  UI_ToolTip_ToolTip__get_enabled(param1_00,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Achieved ---
		void Gameplay_Aprs_View_AprView__get_Achieved(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(param1 + 0x55) = (undefined1)param2;
		  Gameplay_Aprs_View_AprView__HandleIsPointerOverChanged(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: get_IsPointerOver ---
		void Gameplay_Aprs_View_AprView__get_IsPointerOver(int param1,uint param2,undefined4 param3)
		
		{
		  if (param2 != *(byte *)(param1 + 0x54)) {
		    *(char *)(param1 + 0x54) = (char)param2;
		    Gameplay_Aprs_View_AprView__HandleIsPointerOverChanged(param1,param1);
		  }
		  return;
		}
		*/

}

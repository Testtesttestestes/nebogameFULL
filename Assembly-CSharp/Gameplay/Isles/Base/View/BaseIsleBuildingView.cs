using System;
using System.Runtime.CompilerServices;
using AssetContent;
using CloudsFly;
using Core;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.Base.View
{
	// Token: 0x02000CFA RID: 3322
	[Token(Token = "0x2000CFA")]
	public abstract class BaseIsleBuildingView : BaseWorldObjectRenderer
	{
		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x060050F4 RID: 20724 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001063")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x60050F4")]
			[Address(RVA = "0x1E1F", Offset = "0x1E1F", VA = "0x1E1F")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001E9 RID: 489
		// (add) Token: 0x060050F5 RID: 20725 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060050F6 RID: 20726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E9")]
		public event Action<uint> ClickedEvent
		{
			[Token(Token = "0x60050F5")]
			[Address(RVA = "0x3027", Offset = "0x3027", VA = "0x3027")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60050F6")]
			[Address(RVA = "0x3024", Offset = "0x3024", VA = "0x3024")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x060050F7 RID: 20727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001064")]
		public GameAssetViewSpriteRenderer AssetViewSpriteRenderer
		{
			[Token(Token = "0x60050F7")]
			[Address(RVA = "0x9EEB", Offset = "0x9EEB", VA = "0x9EEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x060050F8 RID: 20728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001065")]
		private string UpgradeAnimationAssetId
		{
			[Token(Token = "0x60050F8")]
			[Address(RVA = "0x9EEC", Offset = "0x9EEC", VA = "0x9EEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x060050F9 RID: 20729
		[Token(Token = "0x17001066")]
		public abstract uint Type { [Token(Token = "0x60050F9")] get; }

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		// (set) Token: 0x060050FB RID: 20731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001067")]
		public bool Interactable
		{
			[Token(Token = "0x60050FA")]
			[Address(RVA = "0x9EED", Offset = "0x9EED", VA = "0x9EED")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60050FB")]
			[Address(RVA = "0x1E21", Offset = "0x1E21", VA = "0x1E21")]
			set
			{
			}
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FC")]
		[Address(RVA = "0x9EEE", Offset = "0x9EEE", VA = "0x9EEE", Slot = "11")]
		protected virtual void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Isles_Base_View_BaseIsleBuildingView__Awake
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Isles_Base_View_BaseIsleBuildingView__HandleBuildingDataChanged(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060050FD RID: 20733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FD")]
		[Address(RVA = "0x9EEF", Offset = "0x9EEF", VA = "0x9EEF")]
		private void AssetViewSpriteRendererOnReadyEvent(IAsyncLoadableContent obj)
		{
		/* --- GHIDRA: AssetViewSpriteRendererOnReadyEvent ---
		void Gameplay_Isles_Base_View_BaseIsleBuildingView__AssetViewSpriteRendererOnReadyEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = param1[0xc];
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050FE RID: 20734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FE")]
		[Address(RVA = "0x9EF0", Offset = "0x9EF0", VA = "0x9EF0")]
		private void AssetViewSpriteRendererOnClickedEvent(GameAssetViewSpriteRenderer gameAssetViewSpriteRenderer)
		{
		/* --- GHIDRA: AssetViewSpriteRendererOnClickedEvent ---
		void Gameplay_Isles_Base_View_BaseIsleBuildingView__AssetViewSpriteRendererOnClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58cdd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_View_BaseIsleBuildingView_AssetViewSpriteRendererOnClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_View_BaseIsleBuildingView_AssetViewSpriteRendererOnReadyEvent__
		              );
		    DAT_ram_00a58cdd = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Base_View_BaseIsleBuildingView_AssetViewSpriteRendererOnClickedEvent__
		             ,0);
		  AssetContent_GameAssetViewSpriteRenderer__add_ClickedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Base_View_BaseIsleBuildingView_AssetViewSpriteRendererOnReadyEvent__
		             ,0);
		  AssetContent_GameAssetViewSpriteRenderer__add_ReadyEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060050FF RID: 20735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FF")]
		[Address(RVA = "0x9EF1", Offset = "0x9EF1", VA = "0x9EF1", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005101 RID: 20737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001068")]
		public BaseBuildingData BuildingData
		{
			[Token(Token = "0x6005100")]
			[Address(RVA = "0x9EF2", Offset = "0x9EF2", VA = "0x9EF2")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005101")]
			[Address(RVA = "0x3025", Offset = "0x3025", VA = "0x3025")]
			set
			{
			}
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005102")]
		[Address(RVA = "0x9EF3", Offset = "0x9EF3", VA = "0x9EF3", Slot = "13")]
		protected virtual void HandleBuildingDataChanged()
		{
		/* --- GHIDRA: HandleBuildingDataChanged ---
		void Gameplay_Isles_Base_View_BaseIsleBuildingView__HandleBuildingDataChanged
		               (int param1,undefined4 param2)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  float fVar4;
		  uint uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 uVar9;
		  undefined4 param1_00;
		  uint uVar10;
		  float *pfVar11;
		  float fVar12;
		  float fVar13;
		  float fVar14;
		  float *pfVar15;
		  float fVar16;
		  float fVar17;
		  undefined8 local_18;
		  undefined4 local_10;
		  float4 local_c;
		  float4 local_8;
		  undefined4 local_4;
		  
		  fVar4 = 0.0;
		  if (DAT_ram_00a58cde == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentsInChildren_PolygonCollider2D___);
		    DAT_ram_00a58cde = '\x01';
		  }
		  if (((*(int *)(param1 + 0x38) == 0) ||
		      (iVar6 = func_ii_8742(*(int *)(param1 + 0x38),0), iVar6 == 0)) ||
		     (iVar6 = AssetContent_GameAssetViewSpriteRenderer__remove_ClickedEvent
		                        (*(undefined4 *)(param1 + 0x24),0), iVar6 == 0)) {
		    AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(param1 + 0x28),0,0);
		    uVar9 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x28),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar9,0,0);
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0x28);
		    iVar6 = 0;
		    uVar9 = Gameplay_Isles_Base_View_BaseIsleBuildingView__get_AssetViewSpriteRenderer(param1,0);
		    AssetContent_GameAssetViewSpriteRenderer__get_AssetId(param1_00,uVar9,0);
		    uVar9 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x28),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar9,1,0);
		    iVar7 = UnityEngine_Component__GetComponents___Il2CppFullySharedGenericType_
		                      (*(undefined4 *)(param1 + 0x24),
		                       Method_UnityEngine_Component_GetComponentsInChildren_PolygonCollider2D___);
		    if (0 < *(int *)(iVar7 + 0xc)) {
		      do {
		        uVar9 = *(undefined4 *)(iVar7 + iVar6 * 4 + 0x10);
		        iVar8 = UnityEngine_BoxCollider2D__set_size_Injected(uVar9,0);
		        if (*(int *)(iVar8 + 0xc) != 0) {
		          iVar6 = UnityEngine_BoxCollider2D__set_size_Injected(uVar9,0);
		          uVar10 = *(uint *)(iVar6 + 0xc);
		          if ((int)uVar10 < 1) {
		            fVar3 = 0.0;
		          }
		          else {
		            if (uVar10 == 1) {
		              fVar4 = -3.4028235e+38;
		              fVar2 = 3.4028235e+38;
		              iVar7 = 0;
		              fVar1 = 3.4028235e+38;
		              fVar3 = -3.4028235e+38;
		            }
		            else {
		              fVar4 = -3.4028235e+38;
		              fVar2 = 3.4028235e+38;
		              iVar7 = 0;
		              fVar1 = 3.4028235e+38;
		              fVar3 = -3.4028235e+38;
		              uVar5 = 0;
		              do {
		                pfVar11 = (float *)(iVar6 + 0x10 + (iVar7 * 8 | 8U));
		                fVar12 = pfVar11[1];
		                pfVar15 = (float *)(iVar6 + 0x10 + iVar7 * 8);
		                fVar16 = pfVar15[1];
		                fVar14 = fVar16;
		                if (fVar2 <= fVar16) {
		                  fVar14 = fVar2;
		                }
		                fVar2 = fVar12;
		                if (fVar14 <= fVar12) {
		                  fVar2 = fVar14;
		                }
		                fVar13 = *pfVar11;
		                fVar17 = *pfVar15;
		                fVar14 = fVar17;
		                if (fVar1 <= fVar17) {
		                  fVar14 = fVar1;
		                }
		                fVar1 = fVar13;
		                if (fVar14 <= fVar13) {
		                  fVar1 = fVar14;
		                }
		                if (fVar16 <= fVar4) {
		                  fVar16 = fVar4;
		                }
		                fVar4 = fVar12;
		                if (fVar12 <= fVar16) {
		                  fVar4 = fVar16;
		                }
		                if (fVar17 <= fVar3) {
		                  fVar17 = fVar3;
		                }
		                fVar3 = fVar13;
		                if (fVar13 <= fVar17) {
		                  fVar3 = fVar17;
		                }
		                iVar7 = iVar7 + 2;
		                uVar5 = uVar5 + 2;
		              } while (uVar5 != (uVar10 & 0xfffffffe));
		            }
		            fVar14 = fVar4;
		            if ((uVar10 & 1) != 0) {
		              iVar6 = iVar6 + iVar7 * 8;
		              fVar14 = *(float *)(iVar6 + 0x14);
		              fVar16 = fVar14;
		              if (fVar2 <= fVar14) {
		                fVar16 = fVar2;
		              }
		              fVar2 = fVar16;
		              fVar16 = *(float *)(iVar6 + 0x10);
		              fVar12 = fVar16;
		              if (fVar1 <= fVar16) {
		                fVar12 = fVar1;
		              }
		              fVar1 = fVar12;
		              if (fVar16 <= fVar3) {
		                fVar16 = fVar3;
		              }
		              fVar3 = fVar16;
		              if (fVar14 <= fVar4) {
		                fVar14 = fVar4;
		              }
		            }
		            fVar4 = (fVar14 + fVar2) * 0.5;
		            fVar3 = (fVar3 + fVar1) * 0.5;
		          }
		          uVar9 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(param1 + 0x28),0);
		          local_4 = 0;
		          local_10 = 0;
		          local_18 = CONCAT44(fVar4,fVar3);
		          local_c = (float4)fVar3;
		          local_8 = (float4)fVar4;
		          Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar9,&local_18,0);
		          return;
		        }
		        iVar6 = iVar6 + 1;
		      } while (iVar6 < *(int *)(iVar7 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005103 RID: 20739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005103")]
		[Address(RVA = "0x9EF4", Offset = "0x9EF4", VA = "0x9EF4")]
		protected void ValidateUpgradingAnimation()
		{
		/* --- GHIDRA: ValidateUpgradingAnimation ---
		void Gameplay_Isles_Base_View_BaseIsleBuildingView__ValidateUpgradingAnimation
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = func_ii_4075(param1,0);
		  CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta(param1_00,uVar1,0);
		  uVar1 = *(undefined4 *)(param1 + 0x28);
		  iVar2 = func_ii_4075(param1,0);
		  CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta(uVar1,iVar2 + 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005104 RID: 20740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005104")]
		[Address(RVA = "0x9EF5", Offset = "0x9EF5", VA = "0x9EF5", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Isles_Base_View_BaseIsleBuildingView__ApplySortingOrder(int param1,undefined4 param2)
		
		{
		  func_ii_7665(*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x18),0);
		  func_ii_7665(*(undefined4 *)(param1 + 0x28),*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005105")]
		[Address(RVA = "0x9EF6", Offset = "0x9EF6", VA = "0x9EF6", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005106")]
		[Address(RVA = "0x9EF7", Offset = "0x9EF7", VA = "0x9EF7")]
		protected BaseIsleBuildingView()
		{
		}

		// Token: 0x04002C1E RID: 11294
		[Token(Token = "0x4002C1E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _assetViewSpriteRenderer;

		// Token: 0x04002C1F RID: 11295
		[Token(Token = "0x4002C1F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _upgradeAnimation;

		// Token: 0x04002C20 RID: 11296
		[Token(Token = "0x4002C20")]
		[FieldOffset(Offset = "0x2C")]
		private IGuideTarget _guideTarget;

		// Token: 0x04002C22 RID: 11298
		[Token(Token = "0x4002C22")]
		[FieldOffset(Offset = "0x34")]
		private string _upgradeAnimationAssetId;

		// Token: 0x04002C23 RID: 11299
		[Token(Token = "0x4002C23")]
		[FieldOffset(Offset = "0x38")]
		private BaseBuildingData _buildingData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: remove_ClickedEvent ---
		void Gameplay_Isles_Base_View_BaseIsleBuildingView__remove_ClickedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  param1[0xe] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,*(undefined4 *)(*param1 + 300));
		  return;
		}
		*/


		/* --- GHIDRA: get_AssetViewSpriteRenderer ---
		undefined4
		Gameplay_Isles_Base_View_BaseIsleBuildingView__get_AssetViewSpriteRenderer
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a58cdb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3705);
		    DAT_ram_00a58cdb = '\x01';
		  }
		  iVar2 = func_ii_4769(*(undefined4 *)(param1 + 0x34),0);
		  if (iVar2 == 0) {
		    return *(undefined4 *)(param1 + 0x34);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80f9a507;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f9a507:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar4,StringLiteral_3705,0);
		  *(undefined4 *)(param1 + 0x34) = uVar4;
		  return uVar4;
		}
		*/


		/* --- GHIDRA: get_UpgradeAnimationAssetId ---
		uint Gameplay_Isles_Base_View_BaseIsleBuildingView__get_UpgradeAnimationAssetId
		               (int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 0x24) + 0x38);
		}
		*/


		/* --- GHIDRA: get_Interactable ---
		void Gameplay_Isles_Base_View_BaseIsleBuildingView__get_Interactable(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58cdc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_View_BaseIsleBuildingView_AssetViewSpriteRendererOnClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_View_BaseIsleBuildingView_AssetViewSpriteRendererOnReadyEvent__
		              );
		    DAT_ram_00a58cdc = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Base_View_BaseIsleBuildingView_AssetViewSpriteRendererOnClickedEvent__
		             ,0);
		  AssetContent_GameAssetViewSpriteRenderer__get_SpriteRenderer(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_IAsyncLoadableContent__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Base_View_BaseIsleBuildingView_AssetViewSpriteRendererOnReadyEvent__
		             ,0);
		  AssetContent_GameAssetViewSpriteRenderer__get_IsReady(uVar2,uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_BuildingData ---
		void Gameplay_Isles_Base_View_BaseIsleBuildingView__get_BuildingData(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  iVar2 = *(int *)(param1 + 0x38);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  if (iVar2 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(param1 + 0x24),0,0);
		    Gameplay_Isles_Base_View_BaseIsleBuildingView__HandleBuildingDataChanged(param1,param1);
		    return;
		  }
		  iVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                    (*(undefined4 *)(param1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(iVar2 != 0),0);
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  iVar2 = **(int **)(param1 + 0x38);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    (*(int **)(param1 + 0x38),*(undefined4 *)(iVar2 + 0x104));
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(param1_00,uVar1,0);
		  Gameplay_Isles_Base_View_BaseIsleBuildingView__HandleBuildingDataChanged(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_BuildingData ---
		int * Gameplay_Isles_Base_View_BaseIsleBuildingView__set_BuildingData(int *param1)
		
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

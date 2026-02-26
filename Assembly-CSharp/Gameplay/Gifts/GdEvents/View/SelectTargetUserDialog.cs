using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using frame8.Logic.Misc.Visual.UI.MonoBehaviours;
using Gameplay.Gifts.GdEvents.Control;
using Gameplay.Gifts.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Price;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Gifts.GdEvents.View
{
	// Token: 0x02000710 RID: 1808
	[Token(Token = "0x2000710")]
	public class SelectTargetUserDialog : BaseDialogWindow<SelectTargetUserDialog.SelectTargetUserDialogArgs>
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700083F")]
		public override string WindowId
		{
			[Token(Token = "0x6002B40")]
			[Address(RVA = "0x7BDB", Offset = "0x7BDB", VA = "0x7BDB", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400015D RID: 349
		// (add) Token: 0x06002B41 RID: 11073 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002B42 RID: 11074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015D")]
		public event Action<UserData> SelectEvent
		{
			[Token(Token = "0x6002B41")]
			[Address(RVA = "0x7BDC", Offset = "0x7BDC", VA = "0x7BDC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002B42")]
			[Address(RVA = "0x7BDD", Offset = "0x7BDD", VA = "0x7BDD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000840")]
		public TextMeshProUGUI GiftsLeftField
		{
			[Token(Token = "0x6002B43")]
			[Address(RVA = "0x7BDE", Offset = "0x7BDE", VA = "0x7BDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000841")]
		public TextMeshProUGUI GiftsMaxField
		{
			[Token(Token = "0x6002B44")]
			[Address(RVA = "0x7BDF", Offset = "0x7BDF", VA = "0x7BDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000842")]
		public TextMeshProUGUI ReasonDescription
		{
			[Token(Token = "0x6002B45")]
			[Address(RVA = "0x7BE0", Offset = "0x7BE0", VA = "0x7BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000843")]
		public Transform UsersList
		{
			[Token(Token = "0x6002B46")]
			[Address(RVA = "0x7BE1", Offset = "0x7BE1", VA = "0x7BE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000844")]
		public Transform ReasonDescriptionGroup
		{
			[Token(Token = "0x6002B47")]
			[Address(RVA = "0x7BE2", Offset = "0x7BE2", VA = "0x7BE2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000845")]
		public UserItemView[] Renderers
		{
			[Token(Token = "0x6002B48")]
			[Address(RVA = "0x7BE3", Offset = "0x7BE3", VA = "0x7BE3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B49")]
		[Address(RVA = "0x7BE4", Offset = "0x7BE4", VA = "0x7BE4", Slot = "22")]
		protected override void OnShow(SelectTargetUserDialog.SelectTargetUserDialogArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog__OnShow(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5a230 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_UserItemView___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog_ItemRenderOnSelectEvent__
		              );
		    DAT_ram_00a5a230 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__OnClose__
		            );
		  iVar3 = *(int *)(param1 + 0x88);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar3 + iVar5 * 4 + 0x10);
		      param1_01 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_01,param1,
		                 Method_Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog_ItemRenderOnSelectEvent__
		                 ,0);
		      if (DAT_ram_00a5a235 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		        DAT_ram_00a5a235 = '\x01';
		      }
		      param1_00 = *(int *)(iVar4 + 0x20);
		      do {
		        iVar2 = 0;
		        param1_02 = func_ii_7048(param1_00,param1_01,0);
		        param2_00 = System_Action_UserData__TypeInfo;
		        if ((param1_02 != 0) &&
		           (iVar2 = func_ii_1082(param1_02,System_Action_UserData__TypeInfo), iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_02,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar4 + 0x20,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  iVar5 = Method_System_Array_Empty_UserItemView___;
		  iVar3 = *(int *)(Method_System_Array_Empty_UserItemView___ + 0x1c);
		  if (iVar3 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_UserItemView___);
		    iVar3 = *(int *)(iVar5 + 0x1c);
		  }
		  iVar3 = *(int *)(iVar3 + 8);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  if (*(int *)(iVar3 + 0x74) == 0) {
		    func_ii_306000(iVar3);
		  }
		  iVar5 = *(int *)(*(int *)(iVar5 + 0x1c) + 8);
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  *(undefined4 *)(param1 + 0x88) = **(undefined4 **)(iVar5 + 0x5c);
		  iVar5 = **(int **)(param1 + 0x8c);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x130) * 4))
		            (*(int **)(param1 + 0x8c),*(undefined4 *)(iVar5 + 0x134));
		  return;
		}
		*/

		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0x7BE5", Offset = "0x7BE5", VA = "0x7BE5", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog__OnClose(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  undefined4 in_register_20000014;
		  undefined8 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int param1_00;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  int *piVar13;
		  int iVar14;
		  
		  iVar11 = 0;
		  if (DAT_ram_00a5a231 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_DescriptionField__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_UserData___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_UserItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog_ItemRenderOnSelectEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_GdEvents_View_UserItemView___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8378);
		    DAT_ram_00a5a231 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__HandleContent__
		            );
		  iVar4 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  uVar5 = func_ii_6330(*(undefined4 *)(iVar4 + 0x34),Method_System_Linq_Enumerable_Count_UserData___
		                      );
		  uVar5 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Gifts_GdEvents_View_UserItemView___TypeInfo,uVar5);
		  *(undefined4 *)(param1 + 0x88) = uVar5;
		  uVar7 = *(undefined4 *)(param1 + 0x50);
		  iVar4 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  iVar12 = **(int **)(iVar4 + 0x30);
		  uVar3 = CONCAT44(in_register_20000014,*(undefined4 *)(iVar12 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar12 + 0x100) * 4))(*(int **)(iVar4 + 0x30),uVar3);
		  uVar8 = *(undefined4 *)(iVar4 + 8);
		  uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  iVar4 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  Gameplay_Gifts_View_GiftView__OnDestroy(uVar7,*(undefined4 *)(iVar4 + 0x2c),uVar8,uVar7);
		  uVar7 = *(undefined4 *)(param1 + 0x68);
		  iVar4 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  iVar12 = **(int **)(iVar4 + 0x30);
		  uVar3 = CONCAT44(uVar5,*(undefined4 *)(iVar12 + 0x104));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar12 + 0x100) * 4))(*(int **)(iVar4 + 0x30),uVar3);
		  uVar8 = *(undefined4 *)(iVar4 + 8);
		  uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  iVar4 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  uVar9 = *(undefined4 *)(*(int *)(iVar4 + 0x2c) + 0x10);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar9 = Core_Money_Money__op_Explicit(uVar9,0);
		  UI_Price_Price__SetColor(uVar7,uVar8,uVar9,0);
		  piVar10 = *(int **)(param1 + 0x54);
		  iVar4 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  uVar7 = Core_Extensions_Dict_SocialGiftDicExt__GetIconAssetId(*(undefined4 *)(iVar4 + 0x2c),0);
		  iVar4 = *piVar10;
		  uVar3 = CONCAT44(uVar5,uVar7);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar10,uVar3,*(undefined4 *)(iVar4 + 0x2d4));
		  uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  piVar10 = *(int **)(param1 + 0x60);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar7 = func_ii_7508(StringLiteral_8378,1,0,1,0,0,0,0);
		  iVar4 = *piVar10;
		  uVar3 = CONCAT44(uVar5,uVar7);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (piVar10,uVar3,*(undefined4 *)(iVar4 + 0x2d4));
		  do {
		    uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    iVar4 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                        );
		    piVar10 = *(int **)(iVar4 + 0x34);
		    iVar4 = *piVar10;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_ICollection_UserData__TypeInfo == *piVar13) {
		          puVar6 = (uint *)(iVar4 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x811ea5ca;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar10,System_Collections_Generic_ICollection_UserData__TypeInfo,
		                                  0);
		code_r0x811ea5ca:
		    uVar3 = CONCAT44(uVar5,puVar6[1]);
		    iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar10,uVar3);
		    if (iVar4 <= iVar11) {
		      uVar5 = TMPro_TMP_Text__set_isUsingLegacyAnimationComponent(*(undefined4 *)(param1 + 0x3c),0);
		      UnityEngine_Transform__GetParent(uVar5,*(undefined4 *)(param1 + 0x78),0);
		      frame8_Logic_Misc_Visual_UI_MonoBehaviours_ScrollbarFixer8__remove_ScrollPositionChanged
		                (*(undefined4 *)(param1 + 0x80),1.0,0);
		      return;
		    }
		    uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    iVar4 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                        );
		    piVar10 = *(int **)(iVar4 + 0x34);
		    iVar4 = *piVar10;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IList_UserData__TypeInfo == *piVar13) {
		          puVar6 = (uint *)(iVar4 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x811ea65e;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar10,System_Collections_Generic_IList_UserData__TypeInfo,0);
		code_r0x811ea65e:
		    uVar3 = CONCAT44(uVar5,iVar11);
		    iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar10,uVar3,puVar6[1]);
		    uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    uVar7 = *(undefined4 *)(param1 + 0x6c);
		    uVar8 = *(undefined4 *)(param1 + 0x7c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar12 = func_ii_6805(uVar8,uVar7,Method_UnityEngine_Object_Instantiate_UserItemView___);
		    uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (iVar12,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar7,1,0);
		    if (DAT_ram_00a5a236 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                );
		      DAT_ram_00a5a236 = '\x01';
		    }
		    *(int *)(iVar12 + 0x24) = iVar4;
		    iVar14 = **(int **)(iVar12 + 0x10);
		    uVar3 = CONCAT44(uVar5,*(undefined4 *)(iVar4 + 0x38));
		    (**(code **)((ulonglong)*(uint *)(iVar14 + 0x138) * 4))
		              (*(int **)(iVar12 + 0x10),uVar3,*(undefined4 *)(iVar14 + 0x13c));
		    piVar10 = *(int **)(iVar12 + 0x14);
		    uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    uVar7 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(iVar4,0);
		    iVar14 = *piVar10;
		    uVar3 = CONCAT44(uVar5,uVar7);
		    (**(code **)((ulonglong)*(uint *)(iVar14 + 0x2d0) * 4))
		              (piVar10,uVar3,*(undefined4 *)(iVar14 + 0x2d4));
		    uVar8 = *(undefined4 *)(iVar12 + 0x18);
		    uVar5 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    uVar7 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                      (*(undefined4 *)(iVar4 + 0x4c),0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (uVar8,uVar7,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    uVar7 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		    uVar3 = CONCAT44(uVar5,param1);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar7,param1,
		               Method_Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog_ItemRenderOnSelectEvent__,
		               0);
		    if (DAT_ram_00a5a234 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		      DAT_ram_00a5a234 = '\x01';
		    }
		    iVar4 = *(int *)(iVar12 + 0x20);
		    do {
		      iVar14 = 0;
		      uVar8 = (undefined4)((ulonglong)uVar3 >> 0x20);
		      param1_00 = UnityEngine_UI_Image__set_sprite(iVar4,uVar7,0);
		      uVar5 = System_Action_UserData__TypeInfo;
		      if ((param1_00 != 0) &&
		         (iVar14 = func_ii_1082(param1_00,System_Action_UserData__TypeInfo), iVar14 == 0)) {
		        System_Activator__CreateInstance(param1_00,uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar3 = CONCAT44(uVar8,iVar14);
		      iVar14 = func_ii_4329(iVar12 + 0x20,iVar14,iVar4);
		      bVar1 = iVar14 != iVar4;
		      iVar4 = iVar14;
		    } while (bVar1);
		    piVar10 = *(int **)(param1 + 0x88);
		    if (iVar12 != 0) {
		      uVar5 = *(undefined4 *)(*piVar10 + 0x20);
		      uVar3 = CONCAT44((int)((ulonglong)uVar3 >> 0x20),uVar5);
		      iVar4 = func_ii_1082(iVar12,uVar5);
		      if (iVar4 == 0) {
		        uVar5 = func_ii_1083();
		        func_ii_1050(uVar5,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    piVar10[iVar11 + 4] = iVar12;
		    iVar11 = iVar11 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x7BE6", Offset = "0x7BE6", VA = "0x7BE6", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog__HandleContent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x84);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x7BE7", Offset = "0x7BE7", VA = "0x7BE7")]
		private void ItemRenderOnSelectEvent(UserData user)
		{
		/* --- GHIDRA: ItemRenderOnSelectEvent ---
		void Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog__ItemRenderOnSelectEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a232 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_UserItemView___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs___ctor__
		              );
		    DAT_ram_00a5a232 = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_UserItemView___;
		  iVar1 = *(int *)(Method_System_Array_Empty_UserItemView___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_UserItemView___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  *(undefined4 *)(param1 + 0x88) = **(undefined4 **)(iVar2 + 0x5c);
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x7BE8", Offset = "0x7BE8", VA = "0x7BE8")]
		public SelectTargetUserDialog()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a234 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a5a234 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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

		// Token: 0x040017A7 RID: 6055
		[Token(Token = "0x40017A7")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Gifts/GdEvents/SelectTargetUserDialogWindow";

		// Token: 0x040017A8 RID: 6056
		[Token(Token = "0x40017A8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GiftView _gift;

		// Token: 0x040017A9 RID: 6057
		[Token(Token = "0x40017A9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _giftTitle;

		// Token: 0x040017AA RID: 6058
		[Token(Token = "0x40017AA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _giftsLeftField;

		// Token: 0x040017AB RID: 6059
		[Token(Token = "0x40017AB")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _giftsMaxField;

		// Token: 0x040017AC RID: 6060
		[Token(Token = "0x40017AC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _priceField;

		// Token: 0x040017AD RID: 6061
		[Token(Token = "0x40017AD")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private TextMeshProUGUI _reasonDescription;

		// Token: 0x040017AE RID: 6062
		[Token(Token = "0x40017AE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Price _price;

		// Token: 0x040017AF RID: 6063
		[Token(Token = "0x40017AF")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Transform _scrollContentOwner;

		// Token: 0x040017B0 RID: 6064
		[Token(Token = "0x40017B0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _usersList;

		// Token: 0x040017B1 RID: 6065
		[Token(Token = "0x40017B1")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Transform _reasonDescriptionGroup;

		// Token: 0x040017B2 RID: 6066
		[Token(Token = "0x40017B2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _bottom;

		// Token: 0x040017B3 RID: 6067
		[Token(Token = "0x40017B3")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private UserItemView _userItemRenderPrefab;

		// Token: 0x040017B4 RID: 6068
		[Token(Token = "0x40017B4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ScrollbarFixer8 _scrollbar;

		// Token: 0x040017B6 RID: 6070
		[Token(Token = "0x40017B6")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		private UserItemView[] _renderers;

		// Token: 0x040017B7 RID: 6071
		[Token(Token = "0x40017B7")]
		[FieldOffset(Offset = "0x8C")]
		private SelectTargetUserDialogMediator _mediator;

		// Token: 0x02000711 RID: 1809
		[Token(Token = "0x2000711")]
		public class SelectTargetUserDialogArgs : BaseDialogWindow<SelectTargetUserDialog.SelectTargetUserDialogArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06002B4E RID: 11086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B4E")]
			[Address(RVA = "0x2181", Offset = "0x2181", VA = "0x2181")]
			public SelectTargetUserDialogArgs(SocialGiftDic gift, GiftController controller, IList<UserData> users)
			{
			}

			// Token: 0x040017B8 RID: 6072
			[Token(Token = "0x40017B8")]
			[FieldOffset(Offset = "0x2C")]
			public readonly SocialGiftDic Gift;

			// Token: 0x040017B9 RID: 6073
			[Token(Token = "0x40017B9")]
			[FieldOffset(Offset = "0x30")]
			public readonly GiftController Controller;

			// Token: 0x040017BA RID: 6074
			[Token(Token = "0x40017BA")]
			[FieldOffset(Offset = "0x34")]
			public readonly IList<UserData> Users;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a22d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a5a22d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x84);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x84,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectEvent ---
		void Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog__add_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a22e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a5a22e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x84);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x84,iVar2,param1_00);
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


		/* --- GHIDRA: get_Renderers ---
		void Gameplay_Gifts_GdEvents_View_SelectTargetUserDialog__get_Renderers
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param4;
		  int iVar2;
		  
		  if (DAT_ram_00a5a22f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_TypeInfo);
		    DAT_ram_00a5a22f = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___OnDestroy
		            (param1,param2,
		             Method_UI_Windows_BaseDialogWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__OnShow__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  iVar2 = **(int **)(iVar1 + 0x30);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                        (*(int **)(iVar1 + 0x30),*(undefined4 *)(iVar2 + 0x104));
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  iVar2 = **(int **)(iVar1 + 0x30);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                        (*(int **)(iVar1 + 0x30),*(undefined4 *)(iVar2 + 0x114));
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  param4 = *(undefined4 *)(iVar1 + 0x30);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_TypeInfo
		                               );
		  if (DAT_ram_00a5a249 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftController__SelectTargetUserDialog___ctor__
		              );
		    DAT_ram_00a5a249 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftController__SelectTargetUserDialog___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x8c) = param1_00;
		  return;
		}
		*/

}

using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.GenericList;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.DailyQuests.View
{
	// Token: 0x02000873 RID: 2163
	[Token(Token = "0x2000873")]
	public class DailyQuestsListElement : SelectedGenericListElement<DailyQuestsListElementArgs>
	{
		// Token: 0x060032C9 RID: 13001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032C9")]
		[Address(RVA = "0x831B", Offset = "0x831B", VA = "0x831B")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__Awake
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57c24 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_View_DailyQuestsListElement_ResolveState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__set_args__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c24 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    piVar4 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		    uVar1 = 0;
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,Method_Gameplay_DailyQuests_View_DailyQuestsListElement_ResolveState__,0
		              );
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x80e3797f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_DailyQuests_Model_IQuest_TypeInfo,1);
		code_r0x80e3797f:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  }
		  *(int *)(param1 + 0x18) = param2;
		  if (param2 != 0) {
		    piVar4 = *(int **)(param2 + 0xc);
		    uVar1 = 0;
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,Method_Gameplay_DailyQuests_View_DailyQuestsListElement_ResolveState__,0
		              );
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e37a2d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0);
		code_r0x80e37a2d:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000A02 RID: 2562
		// (set) Token: 0x060032CA RID: 13002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A02")]
		private DailyQuestsListElementArgs Args
		{
			[Token(Token = "0x60032CA")]
			[Address(RVA = "0x831C", Offset = "0x831C", VA = "0x831C")]
			set
			{
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060032CB RID: 13003 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060032CC RID: 13004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A03")]
		public DailyQuestsListElementArgs Data
		{
			[Token(Token = "0x60032CB")]
			[Address(RVA = "0x831D", Offset = "0x831D", VA = "0x831D")]
			get
			{
				return null;
			}
			[Token(Token = "0x60032CC")]
			[Address(RVA = "0x831E", Offset = "0x831E", VA = "0x831E")]
			set
			{
			}
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CD")]
		[Address(RVA = "0x831F", Offset = "0x831F", VA = "0x831F")]
		public void Release()
		{
		/* --- GHIDRA: Release ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__Release
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *param2_00;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57c27 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_View_DailyQuestsListElement_ResolveState__);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c27 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  param1_00 = *(int **)(param2 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_DailyQuests_View_DailyQuestsListElement_ResolveState__,0);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        param2_00 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e38653;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_00,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0);
		code_r0x80e38653:
		  (**(code **)((ulonglong)*param2_00 * 4))(param1_00,uVar2,param2_00[1]);
		  Gameplay_DailyQuests_View_DailyQuestsListElement__OnInit(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x060032CE RID: 13006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CE")]
		[Address(RVA = "0x8320", Offset = "0x8320", VA = "0x8320", Slot = "4")]
		protected override void OnInit(DailyQuestsListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__OnInit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a57c28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c28 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x20);
		  param1_00 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x80e37ba0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_DailyQuests_Model_IQuest_TypeInfo,10);
		code_r0x80e37ba0:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar4,uVar3,*(undefined4 *)(iVar5 + 0x2d4));
		  uVar1 = 0;
		  uVar3 = *(undefined4 *)(param1 + 0x2c);
		  piVar4 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x118);
		        goto code_r0x80e37c43;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xb);
		code_r0x80e37c43:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar3,param2_00,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  Gameplay_DailyQuests_View_DailyQuestsListElement__ApplyArgs(param1,puVar2);
		  Gameplay_DailyQuests_View_DailyQuestsListElement__ResolveState(param1,puVar2);
		  Gameplay_DailyQuests_View_DailyQuestsListElement__DrawBackgroundImage(param1,puVar2);
		  return;
		}
		*/

		}

		// Token: 0x060032CF RID: 13007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032CF")]
		[Address(RVA = "0x8321", Offset = "0x8321", VA = "0x8321")]
		private void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__ApplyArgs(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  uint uVar4;
		  undefined4 param2_00;
		  undefined4 uVar5;
		  int *piVar6;
		  
		  if (DAT_ram_00a57c29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57c29 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar5,0);
		  if (iVar2 != 0) {
		    uVar5 = *(undefined4 *)(param1 + 0x24);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_Component__GetComponent_object_(uVar5,0);
		    if (iVar2 != 0) {
		      piVar6 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar4 = 0;
		        do {
		          if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar4 * 8 + 4) * 8 + iVar2 + 0x120);
		            goto code_r0x80e37f82;
		          }
		          uVar4 = uVar4 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar4);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xc);
		code_r0x80e37f82:
		      uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      uVar4 = func_ii_4769(uVar5,0);
		      uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x28),0);
		      if (uVar4 == 0) {
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar5,0,0);
		        uVar5 = *(undefined4 *)(param1 + 0x24);
		        piVar6 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		        iVar2 = *piVar6;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		                *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120
		                               );
		              goto code_r0x80e38041;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xc);
		code_r0x80e38041:
		        param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		        Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		                  (uVar5,param2_00,
		                   Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__
		                  );
		      }
		      else {
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar5,1,0);
		      }
		      uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x24),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar5,uVar4 ^ 1,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D0")]
		[Address(RVA = "0x8322", Offset = "0x8322", VA = "0x8322")]
		private void DrawBackgroundImage()
		{
		/* --- GHIDRA: DrawBackgroundImage ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__DrawBackgroundImage
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57c2a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    DAT_ram_00a57c2a = '\x01';
		  }
		  piVar5 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xf0);
		        goto code_r0x80e38304;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,6);
		code_r0x80e38304:
		  uVar1 = 0;
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  piVar5 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80e3838c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,4);
		code_r0x80e3838c:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,iVar6,0);
		  if (iVar6 != 0) {
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x34),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x48),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		    return;
		  }
		  piVar5 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0x150);
		        goto code_r0x80e38466;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0x12);
		code_r0x80e38466:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,uVar1,0);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,uVar1 ^ 1,0);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x48),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uVar1 ^ 1) & (uint)(iVar6 == 1),0);
		  if (uVar1 == 0) {
		    uVar4 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0x10);
		    piVar5 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x138);
		          goto code_r0x80e38540;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xf);
		code_r0x80e38540:
		    param4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    param1_00 = unnamed_function_1417
		                          (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor
		              (param1_00,uVar4,uVar4,param4,0);
		    UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x30),param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D1")]
		[Address(RVA = "0x8323", Offset = "0x8323", VA = "0x8323")]
		private void ResolveState()
		{
		/* --- GHIDRA: ResolveState ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__ResolveState(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  uint *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57c2b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_View_DailyQuestsListElement_FormatBackTime__);
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c2b = '\x01';
		  }
		  piVar2 = (int *)func_ii_1082(*(undefined4 *)(*(int *)(param1 + 0x18) + 0xc),
		                               Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  if (piVar2 != (int *)0x0) {
		    uVar1 = 0;
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,1,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x44),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    iVar5 = *(int *)(param1 + 0x3c);
		    uVar3 = unnamed_function_1417(UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    UI_AbstractBacktimeView___ctor
		              (uVar3,param1,Method_Gameplay_DailyQuests_View_DailyQuestsListElement_FormatBackTime__
		               ,0);
		    *(undefined4 *)(iVar5 + 0x14) = uVar3;
		    uVar3 = *(undefined4 *)(param1 + 0x3c);
		    iVar5 = *piVar2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e3819e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar2,Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo,0);
		code_r0x80e3819e:
		    param2_00 = (**(code **)((ulonglong)*puVar4 * 4))(piVar2,puVar4[1]);
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar3,param2_00,0);
		    return;
		  }
		  uVar1 = 0;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x44),0);
		  piVar2 = *(int **)(*(int *)(param1 + 0x18) + 0xc);
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)
		         ) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80e3823f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar2,Gameplay_DailyQuests_Model_IQuest_TypeInfo,4);
		code_r0x80e3823f:
		  uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar2,puVar4[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar1 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D2")]
		[Address(RVA = "0x8324", Offset = "0x8324", VA = "0x8324")]
		private void ResolveQuestType()
		{
		/* --- GHIDRA: ResolveQuestType ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__ResolveQuestType
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57c2c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_BeginButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_View_DailyQuestsListElement_OnClickEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_QuestionButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_TakeButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_WatchButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__RegisterEvents__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UnityEngine_Events_UnityAction_DailyQuestsListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_DailyQuestsListElementArgs__AddListener__);
		    DAT_ram_00a57c2c = '\x01';
		  }
		  UI_Elements_GenericList_GenericListElement_object___OnDestroy
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__RegisterEvents__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_DailyQuests_View_DailyQuestsListElement_QuestionButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_DailyQuests_View_DailyQuestsListElement_TakeButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_DailyQuests_View_DailyQuestsListElement_BeginButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x48) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_DailyQuests_View_DailyQuestsListElement_WatchButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_DailyQuestsListElementArgs__TypeInfo)
		  ;
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_OnClickEventHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,
		             Method_UnityEngine_Events_UnityEvent_DailyQuestsListElementArgs__AddListener__);
		  return;
		}
		*/

		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D3")]
		[Address(RVA = "0x8325", Offset = "0x8325", VA = "0x8325", Slot = "5")]
		protected override void RegisterEvents()
		{
		/* --- GHIDRA: RegisterEvents ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__RegisterEvents(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57c2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_BeginButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_View_DailyQuestsListElement_OnClickEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_QuestionButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_TakeButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_WatchButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__UnregisterEvents__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UnityEngine_Events_UnityAction_DailyQuestsListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_DailyQuestsListElementArgs__RemoveListener__);
		    DAT_ram_00a57c2d = '\x01';
		  }
		  Core_Dict_Controller_Android_DictController__PruneOldDictionaries
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__UnregisterEvents__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_DailyQuests_View_DailyQuestsListElement_QuestionButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_DailyQuests_View_DailyQuestsListElement_TakeButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x44) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_DailyQuests_View_DailyQuestsListElement_BeginButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x48) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_DailyQuests_View_DailyQuestsListElement_WatchButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_DailyQuestsListElementArgs__TypeInfo)
		  ;
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_DailyQuests_View_DailyQuestsListElement_OnClickEventHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,
		             Method_UnityEngine_Events_UnityEvent_DailyQuestsListElementArgs__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D4")]
		[Address(RVA = "0x8326", Offset = "0x8326", VA = "0x8326", Slot = "6")]
		protected override void UnregisterEvents()
		{
		/* --- GHIDRA: UnregisterEvents ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__UnregisterEvents
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57c2e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    DAT_ram_00a57c2e = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(*(int *)(param1 + 0x18) + 0xc),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D5")]
		[Address(RVA = "0x8327", Offset = "0x8327", VA = "0x8327")]
		private void OnClickEventHandler(DailyQuestsListElementArgs args)
		{
		/* --- GHIDRA: OnClickEventHandler ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__OnClickEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57c2e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    DAT_ram_00a57c2e = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(*(int *)(param1 + 0x18) + 0xc),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D6")]
		[Address(RVA = "0x8328", Offset = "0x8328", VA = "0x8328")]
		private void TakeButtonClickedEventHandler()
		{
		/* --- GHIDRA: TakeButtonClickedEventHandler ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__TakeButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_DailyQuests_View_DailyQuestsListElement__Awake(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D7")]
		[Address(RVA = "0x8329", Offset = "0x8329", VA = "0x8329")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__OnDestroy(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c2f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_DailyQuestsListElementArgs__Invoke__);
		    DAT_ram_00a57c2f = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    func_ii_16397(*(int *)(param1 + 0x14),*(undefined4 *)(param1 + 0x18),
		                  Method_UnityEngine_Events_UnityEvent_DailyQuestsListElementArgs__Invoke__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D8")]
		[Address(RVA = "0x832A", Offset = "0x832A", VA = "0x832A")]
		private void QuestionButtonClickedEventHandler()
		{
		/* --- GHIDRA: QuestionButtonClickedEventHandler ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__QuestionButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57c30 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    DAT_ram_00a57c30 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(*(int *)(param1 + 0x18) + 0xc),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D9")]
		[Address(RVA = "0x832B", Offset = "0x832B", VA = "0x832B")]
		private void BeginButtonClickedEventHandler()
		{
		/* --- GHIDRA: BeginButtonClickedEventHandler ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__BeginButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57c31 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    DAT_ram_00a57c31 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(*(int *)(param1 + 0x18) + 0xc),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032DA")]
		[Address(RVA = "0x832C", Offset = "0x832C", VA = "0x832C")]
		private void WatchButtonClickedEventHandler()
		{
		/* --- GHIDRA: WatchButtonClickedEventHandler ---
		undefined4
		Gameplay_DailyQuests_View_DailyQuestsListElement__WatchButtonClickedEventHandler
		          (undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57c32 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2004);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6086);
		    DAT_ram_00a57c32 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_6086,1,0,1,0,0,0,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param3_00 = Utils_TimeUtils__DateFormat((double)param2,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_2004,param3_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060032DB RID: 13019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60032DB")]
		[Address(RVA = "0x832D", Offset = "0x832D", VA = "0x832D")]
		private string FormatBackTime(float backtime)
		{
		/* --- GHIDRA: FormatBackTime ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__FormatBackTime
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c33 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListElement_DailyQuestsListElementArgs___ctor__
		              );
		    DAT_ram_00a57c33 = '\x01';
		  }
		  UI_Elements_GenericList_SelectedGenericListArgs_object____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectedGenericListElement_DailyQuestsListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032DC")]
		[Address(RVA = "0x832E", Offset = "0x832E", VA = "0x832E")]
		public DailyQuestsListElement()
		{
		}

		// Token: 0x04001BC8 RID: 7112
		[Token(Token = "0x4001BC8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _name;

		// Token: 0x04001BC9 RID: 7113
		[Token(Token = "0x4001BC9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameImageLoader _backgroundImageLoader;

		// Token: 0x04001BCA RID: 7114
		[Token(Token = "0x4001BCA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _defaultBackground;

		// Token: 0x04001BCB RID: 7115
		[Token(Token = "0x4001BCB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameRawImageLoader _someImageLoader;

		// Token: 0x04001BCC RID: 7116
		[Token(Token = "0x4001BCC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04001BCD RID: 7117
		[Token(Token = "0x4001BCD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _takeButton;

		// Token: 0x04001BCE RID: 7118
		[Token(Token = "0x4001BCE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _taskComplete;

		// Token: 0x04001BCF RID: 7119
		[Token(Token = "0x4001BCF")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04001BD0 RID: 7120
		[Token(Token = "0x4001BD0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _questionButton;

		// Token: 0x04001BD1 RID: 7121
		[Token(Token = "0x4001BD1")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _beginButton;

		// Token: 0x04001BD2 RID: 7122
		[Token(Token = "0x4001BD2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _watchButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Args ---
		undefined4 Gameplay_DailyQuests_View_DailyQuestsListElement__set_Args(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c25 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_args__
		              );
		    DAT_ram_00a57c25 = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0x18);
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_DailyQuests_View_DailyQuestsListElement__get_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57c26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__get_Initted__
		              );
		    DAT_ram_00a57c26 = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1,param2,
		               Method_UI_Elements_GenericList_GenericListElement_DailyQuestsListElementArgs__Init__)
		    ;
		    return;
		  }
		  Gameplay_DailyQuests_View_DailyQuestsListElement__Awake(param1,param2,param1);
		  Gameplay_DailyQuests_View_DailyQuestsListElement__OnInit(param1,param1);
		  return;
		}
		*/

}

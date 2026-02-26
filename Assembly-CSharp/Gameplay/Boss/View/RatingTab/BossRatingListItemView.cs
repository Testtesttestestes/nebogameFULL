using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Boss.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.RatingTab
{
	// Token: 0x02000B65 RID: 2917
	[Token(Token = "0x2000B65")]
	public class BossRatingListItemView : MonoBehaviour
	{
		// Token: 0x140001B9 RID: 441
		// (add) Token: 0x060046B9 RID: 18105 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046BA RID: 18106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B9")]
		public event Action<BossCaptainRatingData> ClickEvent
		{
			[Token(Token = "0x60046B9")]
			[Address(RVA = "0x954F", Offset = "0x954F", VA = "0x954F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046BA")]
			[Address(RVA = "0x9550", Offset = "0x9550", VA = "0x9550")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x060046BB RID: 18107 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046BC RID: 18108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E05")]
		public BossCaptainRatingData CaptainRating
		{
			[Token(Token = "0x60046BB")]
			[Address(RVA = "0x9551", Offset = "0x9551", VA = "0x9551")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046BC")]
			[Address(RVA = "0x9552", Offset = "0x9552", VA = "0x9552")]
			set
			{
			}
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BD")]
		[Address(RVA = "0x9553", Offset = "0x9553", VA = "0x9553")]
		private void DataOnCaptainUserDataChangedEvent()
		{
		/* --- GHIDRA: DataOnCaptainUserDataChangedEvent ---
		void Gameplay_Boss_View_RatingTab_BossRatingListItemView__DataOnCaptainUserDataChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a579f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_RatingTab_BossRatingListItemView_MonoPointerClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a579f4 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x34);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_RatingTab_BossRatingListItemView_MonoPointerClickHandlerOnOnClickEvent__
		             ,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060046BE RID: 18110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x9554", Offset = "0x9554", VA = "0x9554")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_RatingTab_BossRatingListItemView__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x3c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x38),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060046BF RID: 18111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BF")]
		[Address(RVA = "0x9555", Offset = "0x9555", VA = "0x9555")]
		private void MonoPointerClickHandlerOnOnClickEvent(PointerEventData data)
		{
		/* --- GHIDRA: MonoPointerClickHandlerOnOnClickEvent ---
		void Gameplay_Boss_View_RatingTab_BossRatingListItemView__MonoPointerClickHandlerOnOnClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a579f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_RatingTab_BossRatingListItemView_MonoPointerClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a579f5 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x34);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_RatingTab_BossRatingListItemView_MonoPointerClickHandlerOnOnClickEvent__
		             ,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  Gameplay_Boss_View_RatingTab_BossRatingListItemView__get_CaptainRating(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046C0")]
		[Address(RVA = "0x9556", Offset = "0x9556", VA = "0x9556")]
		private void OnDestroy()
		{
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046C1")]
		[Address(RVA = "0x9557", Offset = "0x9557", VA = "0x9557")]
		public BossRatingListItemView()
		{
		}

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _top;

		// Token: 0x040026B4 RID: 9908
		[Token(Token = "0x40026B4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _topBG;

		// Token: 0x040026B5 RID: 9909
		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _myCaptainMarker;

		// Token: 0x040026B6 RID: 9910
		[Token(Token = "0x40026B6")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private UserView _avatar;

		// Token: 0x040026B7 RID: 9911
		[Token(Token = "0x40026B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _cult;

		// Token: 0x040026B8 RID: 9912
		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _nicname;

		// Token: 0x040026B9 RID: 9913
		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _score;

		// Token: 0x040026BA RID: 9914
		[Token(Token = "0x40026BA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private List<Sprite> _scoreBGList;

		// Token: 0x040026BB RID: 9915
		[Token(Token = "0x40026BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _meScoreBG;

		// Token: 0x040026BC RID: 9916
		[Token(Token = "0x40026BC")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MonoPointerClickHandler _monoPointerClickHandler;

		// Token: 0x040026BD RID: 9917
		[Token(Token = "0x40026BD")]
		[FieldOffset(Offset = "0x38")]
		private BossCaptainRatingData _captainRating;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Boss_View_RatingTab_BossRatingListItemView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossCaptainRatingData__TypeInfo);
		    DAT_ram_00a579f2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossCaptainRatingData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossCaptainRatingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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


		/* --- GHIDRA: get_CaptainRating ---
		void Gameplay_Boss_View_RatingTab_BossRatingListItemView__get_CaptainRating
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  uint *puVar5;
		  longlong lVar6;
		  int iVar7;
		  ulonglong uVar8;
		  uint uVar9;
		  int iVar10;
		  undefined4 uVar11;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a579f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_RatingTab_BossRatingListItemView_DataOnCaptainUserDataChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Sprite__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Sprite__get_Item__);
		    DAT_ram_00a579f3 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x38);
		  if (iVar7 != 0) {
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Boss_View_RatingTab_BossRatingListItemView_DataOnCaptainUserDataChangedEvent__
		               ,0);
		    if (DAT_ram_00a57a75 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57a75 = '\x01';
		    }
		    iVar4 = *(int *)(iVar7 + 0x18);
		    do {
		      piVar3 = (int *)func_ii_7048(iVar4,uVar2,0);
		      if ((piVar3 != (int *)0x0) && (System_Action_TypeInfo != *piVar3)) {
		        System_Activator__CreateInstance(piVar3,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar10 = func_ii_4329(iVar7 + 0x18,piVar3,iVar4);
		      bVar1 = iVar10 != iVar4;
		      iVar4 = iVar10;
		    } while (bVar1);
		  }
		  *(int *)(param1 + 0x38) = param2;
		  if (param2 != 0) {
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Boss_View_RatingTab_BossRatingListItemView_DataOnCaptainUserDataChangedEvent__
		               ,0);
		    if (DAT_ram_00a57a74 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57a74 = '\x01';
		    }
		    iVar7 = *(int *)(param2 + 0x18);
		    do {
		      piVar3 = (int *)UnityEngine_UI_Image__set_sprite(iVar7,uVar2,0);
		      if ((piVar3 != (int *)0x0) && (System_Action_TypeInfo != *piVar3)) {
		        System_Activator__CreateInstance(piVar3,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(param2 + 0x18,piVar3,iVar7);
		      bVar1 = iVar4 != iVar7;
		      iVar7 = iVar4;
		    } while (bVar1);
		    iVar7 = *(int *)(param1 + 0x38);
		    if (*(int *)(iVar7 + 0x14) != 0) {
		      piVar3 = *(int **)(param1 + 0x24);
		      uVar2 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                        (*(int *)(iVar7 + 0x14),0);
		      iVar7 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		                (piVar3,uVar2,*(undefined4 *)(iVar7 + 0x2d4));
		      Gameplay_Rating_View_UserView__get_UserData
		                (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(*(int *)(param1 + 0x38) + 0x14),0);
		      uVar11 = *(undefined4 *)(param1 + 0x20);
		      uVar2 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                        (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x38) + 0x14) + 0x4c),0);
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar11,uVar2,0);
		      iVar7 = *(int *)(param1 + 0x38);
		    }
		    piVar3 = *(int **)(param1 + 0x10);
		    local_8 = *(undefined8 *)(*(int *)(iVar7 + 8) + 0x20);
		    uVar2 = func_ii_8783(&local_8,0);
		    iVar7 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		              (piVar3,uVar2,*(undefined4 *)(iVar7 + 0x2d4));
		    piVar3 = *(int **)(param1 + 0x28);
		    local_8 = *(undefined8 *)(*(int *)(*(int *)(param1 + 0x38) + 8) + 0x18);
		    uVar2 = func_ii_8783(&local_8,0);
		    iVar7 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		              (piVar3,uVar2,*(undefined4 *)(iVar7 + 0x2d4));
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar3;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0x140);
		          goto code_r0x80e12fc6;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e12fc6:
		    uVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar3,puVar5[1]);
		    uVar2 = func_ii_7112(uVar2,0);
		    lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar2,0);
		    iVar7 = *(int *)(*(int *)(param1 + 0x38) + 8);
		    uVar8 = *(ulonglong *)(iVar7 + 0x20);
		    uVar2 = *(undefined4 *)(param1 + 0x14);
		    if (*(longlong *)(iVar7 + 0x10) == lVar6 && 2 < uVar8) {
		      uVar11 = *(undefined4 *)(param1 + 0x30);
		    }
		    else {
		      iVar4 = *(int *)(param1 + 0x2c);
		      iVar10 = *(int *)(iVar4 + 0xc) + -1;
		      iVar7 = (int)uVar8;
		      if (iVar10 < iVar7) {
		        uVar11 = System_Linq_Enumerable__ToList_object_
		                           (iVar4,iVar10,Method_System_Collections_Generic_List_Sprite__get_Item__);
		      }
		      else {
		        uVar11 = System_Linq_Enumerable__ToList_object_
		                           (iVar4,iVar7 + -1,
		                            Method_System_Collections_Generic_List_Sprite__get_Item__);
		      }
		    }
		    func_ii_7050(uVar2,uVar11,0);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    iVar7 = *(int *)(param1 + 0x38);
		    if (DAT_ram_00a57a73 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Count__);
		      DAT_ram_00a57a73 = '\x01';
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,(uint)(0 < *(int *)(*(int *)(iVar7 + 0xc) + 0xc)),0);
		    uVar2 = *(undefined4 *)(param1 + 0x34);
		    iVar7 = *(int *)(param1 + 0x38);
		    if (*(char *)(iVar7 + 0x10) == '\0') {
		      if (DAT_ram_00a57a73 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Count__);
		        DAT_ram_00a57a73 = '\x01';
		      }
		      uVar9 = (uint)(0 < *(int *)(*(int *)(iVar7 + 0xc) + 0xc));
		    }
		    else {
		      uVar9 = 0;
		    }
		    UnityEngine_Object__op_Implicit(uVar2,uVar9,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_CaptainRating ---
		void Gameplay_Boss_View_RatingTab_BossRatingListItemView__set_CaptainRating
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 param1_00;
		  
		  iVar2 = *(int *)(*(int *)(param1 + 0x38) + 0x14);
		  if (iVar2 != 0) {
		    piVar3 = *(int **)(param1 + 0x24);
		    uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(iVar2,0);
		    iVar2 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		    Gameplay_Rating_View_UserView__get_UserData
		              (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(*(int *)(param1 + 0x38) + 0x14),0);
		    param1_00 = *(undefined4 *)(param1 + 0x20);
		    uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x38) + 0x14) + 0x4c),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar1,0);
		  }
		  return;
		}
		*/

}

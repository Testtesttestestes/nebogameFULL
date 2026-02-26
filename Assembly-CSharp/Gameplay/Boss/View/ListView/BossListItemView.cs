using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Counters;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.ListView
{
	// Token: 0x02000B6A RID: 2922
	[Token(Token = "0x2000B6A")]
	public class BossListItemView : MonoBehaviour
	{
		// Token: 0x140001BC RID: 444
		// (add) Token: 0x060046E9 RID: 18153 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046EA RID: 18154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BC")]
		public event Action<BossInstance> SelectedEvent
		{
			[Token(Token = "0x60046E9")]
			[Address(RVA = "0x957F", Offset = "0x957F", VA = "0x957F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046EA")]
			[Address(RVA = "0x9580", Offset = "0x9580", VA = "0x9580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001BD RID: 445
		// (add) Token: 0x060046EB RID: 18155 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046EC RID: 18156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BD")]
		public event Action<BossInstance> QuestionClickedEvent
		{
			[Token(Token = "0x60046EB")]
			[Address(RVA = "0x9581", Offset = "0x9581", VA = "0x9581")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046EC")]
			[Address(RVA = "0x9582", Offset = "0x9582", VA = "0x9582")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046ED")]
		[Address(RVA = "0x9583", Offset = "0x9583", VA = "0x9583")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Boss_View_ListView_BossListItemView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a0c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_ListView_BossListItemView_MonoPointerClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a0c = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x2c);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_ListView_BossListItemView_MonoPointerClickHandlerOnOnClickEvent__
		             ,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060046EE RID: 18158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x9584", Offset = "0x9584", VA = "0x9584")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_ListView_BossListItemView__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x54);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x58),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060046EF RID: 18159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046EF")]
		[Address(RVA = "0x9585", Offset = "0x9585", VA = "0x9585")]
		private void QuestionButtonClickHandler()
		{
		/* --- GHIDRA: QuestionButtonClickHandler ---
		void Gameplay_Boss_View_ListView_BossListItemView__QuestionButtonClickHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x50);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x58),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046F0")]
		[Address(RVA = "0x9586", Offset = "0x9586", VA = "0x9586")]
		private void MonoPointerClickHandlerOnOnClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046F2 RID: 18162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E14")]
		public BossInstance BossInstance
		{
			[Token(Token = "0x60046F1")]
			[Address(RVA = "0x9587", Offset = "0x9587", VA = "0x9587")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046F2")]
			[Address(RVA = "0x9588", Offset = "0x9588", VA = "0x9588")]
			set
			{
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (set) Token: 0x060046F3 RID: 18163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E15")]
		public bool Selected
		{
			[Token(Token = "0x60046F3")]
			[Address(RVA = "0x9589", Offset = "0x9589", VA = "0x9589")]
			set
			{
			}
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046F4")]
		[Address(RVA = "0x958A", Offset = "0x958A", VA = "0x958A")]
		public BossListItemView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Boss_View_ListView_BossListItemView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a0e == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12578);
		    DAT_ram_00a57a0e = '\x01';
		  }
		  return StringLiteral_12578;
		}
		*/

		}

		// Token: 0x040026D2 RID: 9938
		[Token(Token = "0x40026D2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040026D3 RID: 9939
		[Token(Token = "0x40026D3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _healthValue;

		// Token: 0x040026D4 RID: 9940
		[Token(Token = "0x40026D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;

		// Token: 0x040026D5 RID: 9941
		[Token(Token = "0x40026D5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x040026D6 RID: 9942
		[Token(Token = "0x40026D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _bgAlive;

		// Token: 0x040026D7 RID: 9943
		[Token(Token = "0x40026D7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _bgAliveNa;

		// Token: 0x040026D8 RID: 9944
		[Token(Token = "0x40026D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _bgDefault;

		// Token: 0x040026D9 RID: 9945
		[Token(Token = "0x40026D9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private MonoPointerClickHandler _monoPointerClickHandler;

		// Token: 0x040026DA RID: 9946
		[Token(Token = "0x40026DA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressBar _progressBar;

		// Token: 0x040026DB RID: 9947
		[Token(Token = "0x40026DB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewUGUI;

		// Token: 0x040026DC RID: 9948
		[Token(Token = "0x40026DC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameAssetViewRawImage _gameAssetViewRawImage;

		// Token: 0x040026DD RID: 9949
		[Token(Token = "0x40026DD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x040026DE RID: 9950
		[Token(Token = "0x40026DE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LevelCounter _level;

		// Token: 0x040026DF RID: 9951
		[Token(Token = "0x40026DF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Image _heartIcon;

		// Token: 0x040026E0 RID: 9952
		[Token(Token = "0x40026E0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _giftIcon;

		// Token: 0x040026E1 RID: 9953
		[Token(Token = "0x40026E1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Image _swordsGiftIcon;

		// Token: 0x040026E4 RID: 9956
		[Token(Token = "0x40026E4")]
		[FieldOffset(Offset = "0x58")]
		private BossInstance _bossInstance;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectedEvent ---
		void Gameplay_Boss_View_ListView_BossListItemView__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a08 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a57a08 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossInstance__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInstance__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SelectedEvent ---
		void Gameplay_Boss_View_ListView_BossListItemView__remove_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a09 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a57a09 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossInstance__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInstance__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x54,iVar2,param1_00);
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


		/* --- GHIDRA: add_QuestionClickedEvent ---
		void Gameplay_Boss_View_ListView_BossListItemView__add_QuestionClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a0a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a57a0a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossInstance__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInstance__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x54,iVar2,param1_00);
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


		/* --- GHIDRA: remove_QuestionClickedEvent ---
		void Gameplay_Boss_View_ListView_BossListItemView__remove_QuestionClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a0b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_ListView_BossListItemView_MonoPointerClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a0b = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x2c);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_ListView_BossListItemView_MonoPointerClickHandlerOnOnClickEvent__
		             ,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_BossInstance ---
		void Gameplay_Boss_View_ListView_BossListItemView__get_BossInstance
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  float fVar3;
		  undefined4 param3_00;
		  ulonglong uVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  double param1_00;
		  undefined4 *puVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a57a0d == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a57a0d = '\x01';
		  }
		  *(int *)(param1 + 0x58) = param2;
		  piVar5 = *(int **)(param1 + 0x10);
		  uVar2 = AssetContent_GameAssetViewRawImage__set_AssetId
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 8) + 0x30) + 0x14),0);
		  iVar8 = *piVar5;
		  uVar1 = CONCAT44(in_register_20000004,piVar5);
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))(uVar1,uVar2,*(undefined4 *)(iVar8 + 0x2d4))
		  ;
		  uVar6 = *(undefined4 *)(param1 + 0x18);
		  puVar7 = (undefined4 *)(param1 + 0x28);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar8 = Gameplay_Boss_Model_BossInstance__Dispose(*(undefined4 *)(*(int *)(param1 + 0x58) + 8),0);
		  if (iVar8 != 0) {
		    puVar7 = (undefined4 *)(param1 + 0x24);
		    iVar8 = Gameplay_Boss_Model_BossInstanceModel__get_IsEnded
		                      (*(undefined4 *)(*(int *)(param1 + 0x58) + 8),0);
		    if (iVar8 != 0) {
		      puVar7 = (undefined4 *)(param1 + 0x20);
		    }
		  }
		  func_ii_7050(uVar6,*puVar7,0);
		  piVar5 = *(int **)(param1 + 0x30);
		  fVar3 = Gameplay_Boss_Model_BossInstanceModel__set_CurrentHealth
		                    (*(undefined4 *)(*(int *)(param1 + 0x58) + 8),0);
		  iVar8 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x108) * 4))
		            (CONCAT44(uVar2,piVar5),fVar3,*(undefined4 *)(iVar8 + 0x10c));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(param1 + 0x34),
		             *(undefined4 *)(*(int *)(*(int *)(param1 + 0x58) + 8) + 0x34),0);
		  uVar6 = *(undefined4 *)(param1 + 0x38);
		  uVar2 = Core_Extensions_Dict_AprDicExt__Get256х128ImageAssetId
		                    (*(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x58) + 8) + 0x30) + 8),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar6,uVar2,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x44),0);
		  uVar6 = Gameplay_Boss_Model_BossInstance__Dispose(*(undefined4 *)(*(int *)(param1 + 0x58) + 8),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar6,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x48),0);
		  uVar6 = Gameplay_Boss_Model_BossInstanceModel__get_Allowed
		                    (*(undefined4 *)(*(int *)(param1 + 0x58) + 8),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar6,0);
		  piVar5 = *(int **)(param1 + 0x14);
		  uVar4 = Gameplay_Boss_Model_BossInstanceModel__set_InstanceState
		                    (*(undefined4 *)(*(int *)(param1 + 0x58) + 8),0);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar6 = UI_SimpleIconValue__set_IconAssetId((double)uVar4,StringLiteral_28780,0);
		  uVar4 = Gameplay_Boss_Model_BossInfo__get_HasLossReward
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x58) + 8) + 0x30),0);
		  param1_00 = (double)uVar4;
		  param3_00 = func_ii_8614(param1_00,0,0);
		  uVar2 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  uVar6 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar6,StringLiteral_1618,param3_00,0);
		  iVar8 = *piVar5;
		  uVar1 = CONCAT44(uVar2,piVar5);
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))(uVar1,uVar6,*(undefined4 *)(iVar8 + 0x2d4))
		  ;
		  piVar5 = *(int **)(param1 + 0x14);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar6 = Gameplay_Boss_Model_BossInstanceModel__get_CurrentHealthPercent
		                    (*(undefined4 *)(*(int *)(param1 + 0x58) + 8),0);
		  iVar8 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		            (CONCAT44(uVar2,piVar5),uVar6,*(undefined4 *)(iVar8 + 0x2d4));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x4c),0);
		  uVar6 = Gameplay_Boss_Model_BossInfo__get_LicenceCountMax
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x58) + 8) + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar6,0);
		  uVar6 = *(undefined4 *)(param1 + 0x3c);
		  uVar2 = Gameplay_Boss_Model_BossInstanceModel__get_NumInvites
		                    (*(undefined4 *)(*(int *)(param1 + 0x58) + 8),0);
		  System_Collections_Generic_Dictionary_int__object___get_Count(uVar6,uVar2,0);
		  UI_Elements_Counters_CounterAutoHide___ctor
		            (*(undefined4 *)(param1 + 0x40),
		             *(undefined4 *)
		              (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x58) + 8) + 0x30) + 0x14) + 0x14),0);
		  return;
		}
		*/

}

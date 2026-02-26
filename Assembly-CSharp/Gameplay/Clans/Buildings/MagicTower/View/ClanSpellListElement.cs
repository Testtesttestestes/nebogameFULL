using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Gameplay.Discounts.Model;
using Gameplay.School.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using UI;
using UI.Elements.Buttons;
using UI.Elements.Counters;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Buildings.MagicTower.View
{
	// Token: 0x02000AAF RID: 2735
	[Token(Token = "0x2000AAF")]
	public class ClanSpellListElement : MonoBehaviourWithStates<ClanSpellListElement.State>, IDiscountTarget
	{
		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060041FD RID: 16893 RVA: 0x0000CA50 File Offset: 0x0000AC50
		// (set) Token: 0x060041FE RID: 16894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D01")]
		public bool Selected
		{
			[Token(Token = "0x60041FD")]
			[Address(RVA = "0x90B1", Offset = "0x90B1", VA = "0x90B1")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041FE")]
			[Address(RVA = "0x90B2", Offset = "0x90B2", VA = "0x90B2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004200 RID: 16896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D02")]
		public SchoolSpellData Spell
		{
			[Token(Token = "0x60041FF")]
			[Address(RVA = "0x90B3", Offset = "0x90B3", VA = "0x90B3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004200")]
			[Address(RVA = "0x90B4", Offset = "0x90B4", VA = "0x90B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400019D RID: 413
		// (add) Token: 0x06004201 RID: 16897 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004202 RID: 16898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019D")]
		public event Action<ClanSpellListElement> SelectEvent
		{
			[Token(Token = "0x6004201")]
			[Address(RVA = "0x90B5", Offset = "0x90B5", VA = "0x90B5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004202")]
			[Address(RVA = "0x90B6", Offset = "0x90B6", VA = "0x90B6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400019E RID: 414
		// (add) Token: 0x06004203 RID: 16899 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004204 RID: 16900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019E")]
		public event Action<ClanSpellListElement> UseButtonClickedEvent
		{
			[Token(Token = "0x6004203")]
			[Address(RVA = "0x90B7", Offset = "0x90B7", VA = "0x90B7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004204")]
			[Address(RVA = "0x90B8", Offset = "0x90B8", VA = "0x90B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004205")]
		[Address(RVA = "0x90B9", Offset = "0x90B9", VA = "0x90B9")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__Awake
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a577f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement_ToggleSelect__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement_UseButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a577f6 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement_ToggleSelect__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement_UseButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004206 RID: 16902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004206")]
		[Address(RVA = "0x90BA", Offset = "0x90BA", VA = "0x90BA")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__OnDestroy
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  undefined8 uVar7;
		  
		  if (DAT_ram_00a577f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanSpellListElement_State__set_CurrentState__);
		    DAT_ram_00a577f7 = '\x01';
		  }
		  *(int **)(param1 + 0x40) = param2;
		  uVar5 = *(undefined4 *)(param1 + 0x20);
		  uVar2 = Gameplay_School_Model_SchoolSpellData__get_Level(param2,0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar5,uVar2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  uVar6 = *(undefined4 *)(param1 + 0x28);
		  uVar7 = CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0xf4));
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))(param2,uVar7);
		  uVar2 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  UI_Elements_Counters_CounterAutoHide___ctor(uVar6,uVar5,0);
		  iVar3 = Gameplay_School_Model_SchoolSpellData__set_ActionBacktime(param2,0);
		  if (iVar3 == 0) {
		    UnityEngine_ParticleSystem__Stop(*(undefined4 *)(param1 + 0x2c),0);
		  }
		  else {
		    UnityEngine_ParticleSystem__Play(*(undefined4 *)(param1 + 0x2c),0);
		  }
		  uVar7 = CONCAT44(uVar2,*(undefined4 *)(*param2 + 0xf4));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))(param2,uVar7);
		  if (iVar3 == 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,3,
		               Method_UI_MonoBehaviourWithStates_ClanSpellListElement_State__set_CurrentState__);
		    return;
		  }
		  uVar2 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  iVar3 = Gameplay_School_Model_SchoolSpellData__set_BackTime(param2,0);
		  if (iVar3 != 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x34);
		    iVar3 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                      (param2[6],3,
		                       Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    uVar7 = *(undefined8 *)(iVar3 + 0x10);
		    uVar1 = Gameplay_School_Model_SchoolSpellData__set_BackTime(param2,0);
		    UI_Elements_ProgressBars_ProgressBarWithTimer__TimerComplete(uVar2,uVar7,(ulonglong)uVar1,0);
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,2,
		               Method_UI_MonoBehaviourWithStates_ClanSpellListElement_State__set_CurrentState__);
		    return;
		  }
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0xb8);
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
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80de2019;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de2019:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,CONCAT44(uVar2,puVar4[1]));
		  uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0x18);
		  uVar2 = func_ii_10810(param2,0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(uVar5,uVar6,uVar2,0);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,
		             Method_UI_MonoBehaviourWithStates_ClanSpellListElement_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004207")]
		[Address(RVA = "0x90BB", Offset = "0x90BB", VA = "0x90BB")]
		public void Init(SchoolSpellData spell)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(char *)(param1 + 0x3c) = (char)param2;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x24),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004208 RID: 16904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004208")]
		[Address(RVA = "0x90BC", Offset = "0x90BC", VA = "0x90BC")]
		public void SelectSilent(bool select)
		{
		/* --- GHIDRA: SelectSilent ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__SelectSilent
		               (int param1,undefined4 param2)
		
		{
		  byte bVar1;
		  int iVar2;
		  
		  bVar1 = *(byte *)(param1 + 0x3c);
		  *(byte *)(param1 + 0x3c) = bVar1 ^ 1;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x24),(uint)(bVar1 == 0),0);
		  iVar2 = *(int *)(param1 + 0x44);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004209")]
		[Address(RVA = "0x90BD", Offset = "0x90BD", VA = "0x90BD")]
		private void ToggleSelect()
		{
		/* --- GHIDRA: ToggleSelect ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__ToggleSelect
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x48);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420A")]
		[Address(RVA = "0x90BE", Offset = "0x90BE", VA = "0x90BE")]
		private void UseButtonClickedEventHandler()
		{
		/* --- GHIDRA: UseButtonClickedEventHandler ---
		int Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__UseButtonClickedEventHandler
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a577f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_DiscountTargets___TypeInfo);
		    DAT_ram_00a577f8 = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_DiscountTargets___TypeInfo,1);
		  *(undefined4 *)(iVar1 + 0x10) = 6;
		  return iVar1;
		}
		*/

		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D03")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x600420B")]
			[Address(RVA = "0x90BF", Offset = "0x90BF", VA = "0x90BF", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420C")]
		[Address(RVA = "0x90C0", Offset = "0x90C0", VA = "0x90C0", Slot = "6")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		/* --- GHIDRA: Setup ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__Setup
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a577fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanSpellListElement_State___ctor__);
		    DAT_ram_00a577fa = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ClanSpellListElement_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600420D RID: 16909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600420D")]
		[Address(RVA = "0x90C1", Offset = "0x90C1", VA = "0x90C1")]
		public ClanSpellListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_Clans_Buildings_MagicTower_View_ClanSpellUpgradeRequirementsTitledListElement__OnInit
		            (param1,*(undefined4 *)(param2 + 8),*(undefined4 *)(param2 + 0xc),
		             *(undefined4 *)(param2 + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x04002463 RID: 9315
		[Token(Token = "0x4002463")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _selectButton;

		// Token: 0x04002464 RID: 9316
		[Token(Token = "0x4002464")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImageLoader _spellGameRawImageLoader;

		// Token: 0x04002465 RID: 9317
		[Token(Token = "0x4002465")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x04002466 RID: 9318
		[Token(Token = "0x4002466")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LevelCounter _levelCounter;

		// Token: 0x04002467 RID: 9319
		[Token(Token = "0x4002467")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ParticleSystem _learningEffect;

		// Token: 0x04002468 RID: 9320
		[Token(Token = "0x4002468")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ButtonWithCost _costButton;

		// Token: 0x04002469 RID: 9321
		[Token(Token = "0x4002469")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ProgressBarWithTimer _progressBar;

		// Token: 0x0400246A RID: 9322
		[Token(Token = "0x400246A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _discountWidget;

		// Token: 0x02000AB0 RID: 2736
		[Token(Token = "0x2000AB0")]
		public enum State
		{
			// Token: 0x04002470 RID: 9328
			[Token(Token = "0x4002470")]
			UNKNOWN_STATE,
			// Token: 0x04002471 RID: 9329
			[Token(Token = "0x4002471")]
			IDLE,
			// Token: 0x04002472 RID: 9330
			[Token(Token = "0x4002472")]
			ACTIVE,
			// Token: 0x04002473 RID: 9331
			[Token(Token = "0x4002473")]
			NOT_LEARNED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Spell ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__set_Spell
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a577f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClanSpellListElement__TypeInfo);
		    DAT_ram_00a577f1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ClanSpellListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ClanSpellListElement__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_SelectEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__add_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a577f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClanSpellListElement__TypeInfo);
		    DAT_ram_00a577f2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ClanSpellListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ClanSpellListElement__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_SelectEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__remove_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a577f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClanSpellListElement__TypeInfo);
		    DAT_ram_00a577f3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ClanSpellListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ClanSpellListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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


		/* --- GHIDRA: add_UseButtonClickedEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__add_UseButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a577f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClanSpellListElement__TypeInfo);
		    DAT_ram_00a577f4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ClanSpellListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ClanSpellListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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


		/* --- GHIDRA: remove_UseButtonClickedEvent ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__remove_UseButtonClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a577f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement_ToggleSelect__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement_UseButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a577f5 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement_ToggleSelect__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement_UseButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_DiscountTargets ---
		void Gameplay_Clans_Buildings_MagicTower_View_ClanSpellListElement__get_DiscountTargets
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a577f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		    DAT_ram_00a577f9 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x38),0);
		  param2_00 = System_Linq_Enumerable__OrderBy_object__ulong_
		                        (param2,Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

}

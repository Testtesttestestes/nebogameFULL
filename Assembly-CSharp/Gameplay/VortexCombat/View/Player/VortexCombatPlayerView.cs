using System;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Gameplay.Aprs.View;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Players.Pet;
using Gameplay.Sound.Control;
using Gameplay.UserInterface.View;
using Gameplay.VortexCombat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexCombat.View.Player
{
	// Token: 0x020003AD RID: 941
	[Token(Token = "0x20003AD")]
	public class VortexCombatPlayerView : MonoBehaviour, ICombatPLayerView, IToolTipDataProvider
	{
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003A0")]
		public Transform AnimationParent
		{
			[Token(Token = "0x60015F1")]
			[Address(RVA = "0x67B3", Offset = "0x67B3", VA = "0x67B3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A1")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x60015F2")]
			[Address(RVA = "0x67B4", Offset = "0x67B4", VA = "0x67B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F3")]
			[Address(RVA = "0x67B5", Offset = "0x67B5", VA = "0x67B5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A2")]
		public UserSkillDic CurrentManaUserSkillDic
		{
			[Token(Token = "0x60015F4")]
			[Address(RVA = "0x67B6", Offset = "0x67B6", VA = "0x67B6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F5")]
			[Address(RVA = "0x67B7", Offset = "0x67B7", VA = "0x67B7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A3")]
		public CombatPlayer Player
		{
			[Token(Token = "0x60015F6")]
			[Address(RVA = "0x67B8", Offset = "0x67B8", VA = "0x67B8", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015F7")]
			[Address(RVA = "0x67B9", Offset = "0x67B9", VA = "0x67B9", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003A4")]
		public VortexCombatPlayer VortexCombatPlayer
		{
			[Token(Token = "0x60015F8")]
			[Address(RVA = "0x67BA", Offset = "0x67BA", VA = "0x67BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A5")]
		public CombatAnimation CombatAnimation
		{
			[Token(Token = "0x60015F9")]
			[Address(RVA = "0x67BB", Offset = "0x67BB", VA = "0x67BB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60015FA")]
			[Address(RVA = "0x67BC", Offset = "0x67BC", VA = "0x67BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x67BD", Offset = "0x67BD", VA = "0x67BD")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58226 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a58226 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  func_ii_8007(*(undefined4 *)(param1 + 0x24),0,0);
		  return;
		}
		*/

		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x67BE", Offset = "0x67BE", VA = "0x67BE")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__OnDisable
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 0x14) + 0x58) = 2;
		  return;
		}
		*/

		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x67BF", Offset = "0x67BF", VA = "0x67BF")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		int Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__Awake
		              (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 in_register_20000024;
		  undefined4 uVar1;
		  undefined8 uVar2;
		  undefined8 uVar3;
		  int *param1_00;
		  int param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a58220 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		    DAT_ram_00a58220 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_int__object___get_Item(param4,4,0);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___get_Item(param4,5,0);
		  *(int *)(param1 + 0x44) = param2;
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  iVar4 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),
		             CONCAT44(in_register_20000014,
		                      *(undefined4 *)(*(int *)(*(int *)(param2 + 8) + 0xc) + 0x18)),
		             CONCAT44(in_register_20000024,*(undefined4 *)(iVar4 + 0x2d4)));
		  iVar4 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(*(int *)(param2 + 0x14) + 0x38),
		             *(undefined4 *)(iVar4 + 0x13c));
		  iVar4 = *(int *)(*(int *)(param2 + 8) + 0x30);
		  param1_01 = *(int *)(param1 + 0x30);
		  if (iVar4 != *(int *)(param1_01 + 0x40)) {
		    *(int *)(param1_01 + 0x40) = iVar4;
		    Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__Gameplay_Combat_View_Players_ICombatPLayerView_get_gameObject
		              (param1_01,param1);
		  }
		  param1_00 = *(int **)(param1 + 0x44);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8) * 4
		                + -4) != Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(param1_00,0);
		  uVar3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x44),0);
		  Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__Init(param1,uVar2,uVar3,param1);
		  uVar2 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x44),0);
		  uVar3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x44),0);
		  Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__SetHealth(param1,uVar2,uVar3,param1);
		  uVar2 = Gameplay_Combat_Model_CombatPlayer__get_TotalExtraHealth(param1_00,0);
		  uVar3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentManaBoost(param1_00,0);
		  Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__SetMana(param1,uVar2,uVar3,param1);
		  func_ii_7342(param1,param1);
		  *(undefined1 *)(param1 + 0x4c) = 1;
		  return param1;
		}
		*/

		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x67C0", Offset = "0x67C0", VA = "0x67C0", Slot = "4")]
		public ICombatPLayerView Init(CombatPlayer player, IGameAudio gameAudio, Dictionaries dictionaries)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__Init
		               (int param1,longlong param2,longlong param3,undefined4 param4)
		
		{
		  bool bVar1;
		  longlong lVar2;
		  undefined4 in_register_20000004;
		  longlong lVar3;
		  float fVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param3_00;
		  undefined4 uVar8;
		  int iVar9;
		  int *piVar10;
		  double param1_00;
		  double param2_00;
		  undefined8 local_18;
		  longlong local_10;
		  longlong local_8;
		  
		  lVar3 = param2;
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a58221 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a58221 = '\x01';
		  }
		  uVar8 = (undefined4)((ulonglong)lVar3 >> 0x20);
		  fVar4 = UnityEngine_Camera__set_orthographicSize((float)param2,(float)param3,0);
		  iVar9 = *(int *)(*(int *)(param1 + 0x2c) + 0x18);
		  uVar5 = Core_Extensions_Dict_UserSkillDicExt__GetDescription(*(undefined4 *)(param1 + 0x3c),0);
		  iVar6 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar7 = UnityEngine_GameObject__SetActive(&local_8,0);
		  param3_00 = UnityEngine_GameObject__SetActive(&local_10,0);
		  uVar7 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar7,StringLiteral_1618,param3_00,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28217,uVar7,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar6 + 0x10) = local_18;
		  uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar5,iVar6,0);
		  lVar2 = local_8;
		  lVar3 = local_10;
		  *(undefined4 *)(iVar9 + 0x28) = uVar5;
		  piVar10 = *(int **)(param1 + 0x2c);
		  if (*(char *)(*(int *)(param1 + 0x44) + 0x50) == '\0') {
		    uVar5 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  else {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    param1_00 = (double)lVar2;
		    param2_00 = (double)lVar3;
		    uVar5 = Utils_StringUtils__GetRomanNumber(param1_00,param2_00,0);
		    uVar8 = (undefined4)((ulonglong)param2_00 >> 0x20);
		    in_register_20000004 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  }
		  iVar6 = *piVar10;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x118) * 4))
		            (CONCAT44(in_register_20000004,piVar10),CONCAT44(uVar8,uVar5),
		             *(undefined4 *)(iVar6 + 0x11c));
		  iVar6 = **(int **)(param1 + 0x2c);
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x108) * 4))
		            (*(int **)(param1 + 0x2c),fVar4,*(undefined4 *)(iVar6 + 0x10c));
		  fVar4 = 1.0;
		  bVar1 = local_8 < 1;
		  if (bVar1 == 0) {
		    fVar4 = 0.0;
		  }
		  Gameplay_Aprs_View_AprView__DataOnDataChangedEvent(*(undefined4 *)(param1 + 0x14),fVar4,0.0,0);
		  uVar8 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar8,(uint)bVar1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x67C1", Offset = "0x67C1", VA = "0x67C1")]
		private void SetHealth(long current, long total)
		{
		/* --- GHIDRA: SetHealth ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__SetHealth
		               (int param1,longlong param2,longlong param3,undefined4 param4)
		
		{
		  longlong lVar1;
		  undefined4 in_register_20000004;
		  longlong lVar2;
		  undefined4 uVar3;
		  float fVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param3_00;
		  int iVar8;
		  int *piVar9;
		  double param1_00;
		  double param2_00;
		  undefined8 local_18;
		  longlong local_10;
		  longlong local_8;
		  
		  lVar2 = param2;
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a58222 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a58222 = '\x01';
		  }
		  uVar3 = (undefined4)((ulonglong)lVar2 >> 0x20);
		  fVar4 = UnityEngine_Camera__set_orthographicSize((float)param2,(float)param3,0);
		  iVar8 = *(int *)(*(int *)(param1 + 0x30) + 0x18);
		  uVar5 = Core_Extensions_Dict_UserSkillDicExt__GetDescription(*(undefined4 *)(param1 + 0x40),0);
		  iVar6 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar7 = UnityEngine_GameObject__SetActive(&local_8,0);
		  param3_00 = UnityEngine_GameObject__SetActive(&local_10,0);
		  uVar7 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar7,StringLiteral_1618,param3_00,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28217,uVar7,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar6 + 0x10) = local_18;
		  uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar5,iVar6,0);
		  lVar1 = local_8;
		  lVar2 = local_10;
		  *(undefined4 *)(iVar8 + 0x28) = uVar5;
		  piVar9 = *(int **)(param1 + 0x30);
		  if (*(char *)(*(int *)(param1 + 0x44) + 0x50) == '\0') {
		    uVar5 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  else {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    param1_00 = (double)lVar1;
		    param2_00 = (double)lVar2;
		    uVar5 = Utils_StringUtils__GetRomanNumber(param1_00,param2_00,0);
		    uVar3 = (undefined4)((ulonglong)param2_00 >> 0x20);
		    in_register_20000004 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  }
		  iVar6 = *piVar9;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x118) * 4))
		            (CONCAT44(in_register_20000004,piVar9),CONCAT44(uVar3,uVar5),
		             *(undefined4 *)(iVar6 + 0x11c));
		  iVar6 = **(int **)(param1 + 0x30);
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x108) * 4))
		            (*(int **)(param1 + 0x30),fVar4,*(undefined4 *)(iVar6 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x67C2", Offset = "0x67C2", VA = "0x67C2")]
		private void SetMana(long current, long total)
		{
		/* --- GHIDRA: SetMana ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__SetMana
		               (int param1,longlong param2,longlong param3,undefined4 param4)
		
		{
		  longlong lVar1;
		  undefined4 in_register_20000004;
		  longlong lVar2;
		  undefined4 uVar3;
		  float fVar4;
		  undefined4 uVar5;
		  int param2_00;
		  undefined4 uVar6;
		  undefined4 param3_00;
		  int iVar7;
		  int *piVar8;
		  double param1_00;
		  double param2_01;
		  undefined8 local_18;
		  longlong local_10;
		  longlong local_8;
		  
		  lVar2 = param2;
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a58223 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15125);
		    DAT_ram_00a58223 = '\x01';
		  }
		  uVar3 = (undefined4)((ulonglong)lVar2 >> 0x20);
		  fVar4 = UnityEngine_Camera__set_orthographicSize((float)param2,(float)param3,0);
		  iVar7 = *(int *)(*(int *)(param1 + 0x34) + 0x18);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = func_ii_7508(StringLiteral_15125,1,0,1,0,0,0,0);
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar6 = UnityEngine_GameObject__SetActive(&local_8,0);
		  param3_00 = UnityEngine_GameObject__SetActive(&local_10,0);
		  uVar6 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar6,StringLiteral_1618,param3_00,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28217,uVar6,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x10) = local_18;
		  uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar5,param2_00,0);
		  lVar1 = local_8;
		  lVar2 = local_10;
		  *(undefined4 *)(iVar7 + 0x28) = uVar5;
		  piVar8 = *(int **)(param1 + 0x34);
		  if (*(char *)(*(int *)(param1 + 0x44) + 0x50) == '\0') {
		    uVar5 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  else {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    param1_00 = (double)lVar1;
		    param2_01 = (double)lVar2;
		    uVar5 = Utils_StringUtils__GetRomanNumber(param1_00,param2_01,0);
		    uVar3 = (undefined4)((ulonglong)param2_01 >> 0x20);
		    in_register_20000004 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  }
		  iVar7 = *piVar8;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x118) * 4))
		            (CONCAT44(in_register_20000004,piVar8),CONCAT44(uVar3,uVar5),
		             *(undefined4 *)(iVar7 + 0x11c));
		  iVar7 = **(int **)(param1 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x108) * 4))
		            (*(int **)(param1 + 0x34),fVar4,*(undefined4 *)(iVar7 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x67C3", Offset = "0x67C3", VA = "0x67C3")]
		private void SetCommonMana(long current, long total)
		{
		/* --- GHIDRA: SetCommonMana ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__SetCommonMana
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  undefined8 uVar2;
		  
		  if (param2 == 3) {
		    uVar1 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x44),0);
		    uVar2 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x44),0);
		    Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__Init(param1,uVar1,uVar2,param1);
		    return;
		  }
		  if (param2 != 4) {
		    if (((((param2 != 5) && (param2 != 6)) && (param2 != 7)) &&
		        ((((param2 != 8 && (param2 != 9)) &&
		          ((param2 != 10 && ((param2 != 0xb && (param2 != 0xc)))))) && (param2 != 0xd)))) &&
		       (((param2 != 0xe && (param2 != 0xf)) && (param2 == 0x10)))) {
		      Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__UpdateUserSkill(param1,param1);
		    }
		    return;
		  }
		  uVar1 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x44),0);
		  uVar2 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x44),0);
		  Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__SetHealth(param1,uVar1,uVar2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x67C4", Offset = "0x67C4", VA = "0x67C4", Slot = "5")]
		public void UpdateUserSkill(UserSkillsIndexes skillsIndex)
		{
		/* --- GHIDRA: UpdateUserSkill ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__UpdateUserSkill
		               (int param1,undefined4 param2)
		
		{
		  undefined8 param2_00;
		  undefined8 param3;
		  int *param1_00;
		  
		  if (DAT_ram_00a58224 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		    DAT_ram_00a58224 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x44);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8) * 4
		                + -4) != Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00 = Gameplay_Combat_Model_CombatPlayer__get_TotalExtraHealth(param1_00,0);
		  param3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentManaBoost(param1_00,0);
		  Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__SetMana
		            (param1,param2_00,param3,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x67C5", Offset = "0x67C5", VA = "0x67C5")]
		public void UpdateBoostMana()
		{
		/* --- GHIDRA: UpdateBoostMana ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__UpdateBoostMana
		               (int param1,undefined4 param2)
		
		{
		  undefined8 param2_00;
		  undefined8 param3;
		  
		  param2_00 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x44),0);
		  param3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x44),0);
		  Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__SetHealth
		            (param1,param2_00,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x67C6", Offset = "0x67C6", VA = "0x67C6")]
		public void UpdateMana()
		{
		/* --- GHIDRA: UpdateMana ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__UpdateMana
		               (int param1,undefined4 param2)
		
		{
		  undefined8 param2_00;
		  undefined8 param3;
		  
		  param2_00 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x44),0);
		  param3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x44),0);
		  Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__Init(param1,param2_00,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x67C7", Offset = "0x67C7", VA = "0x67C7")]
		public void UpdateHealth()
		{
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x67C8", Offset = "0x67C8", VA = "0x67C8", Slot = "6")]
		public void UpdateBalance()
		{
		/* --- GHIDRA: UpdateBalance ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__UpdateBalance
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  uint param2_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58225 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData__get_Count__);
		    DAT_ram_00a58225 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  iVar4 = *(int *)(*(int *)(param1 + 0x44) + 0x24);
		  if (iVar4 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(0 < *(int *)(iVar4 + 0xc));
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  iVar2 = *(int *)(param1 + 0x28);
		  iVar4 = *(int *)(*(int *)(param1 + 0x44) + 0x24);
		  if (*(int *)(iVar2 + 0x14) != iVar4) {
		    *(int *)(iVar2 + 0x14) = iVar4;
		    if (DAT_ram_00a5821d == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData__get_Count__);
		      Mono_Security_ASN1__get_Item(&StringLiteral_28377);
		      DAT_ram_00a5821d = '\x01';
		      iVar4 = *(int *)(iVar2 + 0x14);
		    }
		    if (iVar4 != 0) {
		      piVar3 = *(int **)(iVar2 + 0x10);
		      local_4 = *(undefined4 *)(iVar4 + 0xc);
		      uVar1 = func_ii_4443(&local_4,0);
		      uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,StringLiteral_28377,0);
		      iVar4 = *piVar3;
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		                (piVar3,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x67C9", Offset = "0x67C9", VA = "0x67C9", Slot = "7")]
		public void UpdateLongEffects()
		{
		/* --- GHIDRA: UpdateLongEffects ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__UpdateLongEffects
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  Gameplay_Aprs_View_AprView__DataOnDataChangedEvent(*(undefined4 *)(param1 + 0x14),param2,param3,0)
		  ;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(0.0 < param2),0);
		  return;
		}
		*/

		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x1CAF", Offset = "0x1CAF", VA = "0x1CAF")]
		public void UpdateTurn()
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x67CA", Offset = "0x67CA", VA = "0x67CA", Slot = "8")]
		public void ShowDeathState(float value, float duration = 0f)
		{
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x67CB", Offset = "0x67CB", VA = "0x67CB", Slot = "9")]
		public bool TryGetLevel(out LevelView levelView)
		{
			return default(bool);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x67CC", Offset = "0x67CC", VA = "0x67CC", Slot = "10")]
		public bool TryGetPet(out IPetView petView)
		{
			return default(bool);
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00005328 File Offset: 0x00003528
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A6")]
		public bool IsInit
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x67CD", Offset = "0x67CD", VA = "0x67CD", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x67CE", Offset = "0x67CE", VA = "0x67CE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00005340 File Offset: 0x00003540
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A7")]
		public bool Select
		{
			[Token(Token = "0x600160E")]
			[Address(RVA = "0x67CF", Offset = "0x67CF", VA = "0x67CF", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x67D0", Offset = "0x67D0", VA = "0x67D0", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x67D1", Offset = "0x67D1", VA = "0x67D1", Slot = "17")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x67D2", Offset = "0x67D2", VA = "0x67D2")]
		public VortexCombatPlayerView()
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x67D3", Offset = "0x67D3", VA = "0x67D3", Slot = "14")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AprView _apr;

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _myPlayerMarker;

		// Token: 0x04000BA4 RID: 2980
		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _turnMarker;

		// Token: 0x04000BA5 RID: 2981
		[Token(Token = "0x4000BA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _deathStateMarker;

		// Token: 0x04000BA6 RID: 2982
		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _glow;

		// Token: 0x04000BA7 RID: 2983
		[Token(Token = "0x4000BA7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LongEffect _longEffect;

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private VortexCombatProgressBar _healBar;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VortexCombatProgressBar _manaByTypeBar;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private VortexCombatProgressBar _commonManaBar;

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _animationParent;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Player ---
		int * Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__set_Player
		                (int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a5821f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		    DAT_ram_00a5821f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x44);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo + 0xb8) * 4
		                + -4) != Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Gameplay_VortexCombat_Model_VortexCombatPlayer_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: set_CombatAnimation ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__set_CombatAnimation
		               (int param1,undefined4 param2)
		
		{
		  Gameplay_Combat_View_Animations_CombatAnimation__CancelLoad(*(undefined4 *)(param1 + 0x48),0);
		  Gameplay_Combat_View_Animations_CombatAnimation__Reset(*(undefined4 *)(param1 + 0x48),0);
		  *(undefined4 *)(param1 + 0x48) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_IsInit ---
		undefined4
		Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__set_IsInit(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = func_ii_12174(*(undefined4 *)(param1 + 0x24),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Select ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__get_Select
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58226 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a58226 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2,0);
		  if (param2 != 0) {
		    func_ii_9125(*(undefined4 *)(param1 + 0x24),1.0,0.0,0);
		    uVar1 = func_ii_9125(*(undefined4 *)(param1 + 0x24),0.0,0.6,0);
		    uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                      (uVar1,0x14,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		                      );
		    DG_Tweening_TweenSettingsExtensions__SetLoops_object_
		              (uVar1,0x7fffffff,1,
		               Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Color__Color__ColorOptions____
		              );
		    return;
		  }
		  func_ii_8007(*(undefined4 *)(param1 + 0x24),0,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Select ---
		int Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__set_Select
		              (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined8 uVar6;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a58227 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_SkillData_____ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_SkillData____set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_SkillData____TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12543);
		    DAT_ram_00a58227 = '\x01';
		  }
		  iVar5 = **(int **)(param1 + 0x44);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf8) * 4))
		                    (*(int **)(param1 + 0x44),*(undefined4 *)(iVar5 + 0xfc));
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Core_Data_Skills_SkillData___TypeInfo,*(undefined4 *)(iVar5 + 0xc));
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      uVar2 = System_Linq_Enumerable__ToList_object_
		                        (iVar5,iVar4,Method_System_Collections_Generic_List_int__get_Item__);
		      param1_00 = unnamed_function_1417(Core_Data_Skills_SkillData_TypeInfo);
		      Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,uVar2,0);
		      iVar3 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                        (*(undefined4 *)(*(int *)(param1 + 0x44) + 0x58),uVar2,
		                         Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		      *(undefined8 *)(param1_00 + 0x10) = *(undefined8 *)(iVar3 + 0x10);
		      iVar3 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                        (*(undefined4 *)(*(int *)(param1 + 0x44) + 0x5c),uVar2,
		                         Method_System_Collections_Generic_Dictionary_int__Skill__ContainsKey__);
		      if (iVar3 == 0) {
		        uVar6 = 0;
		      }
		      else {
		        iVar3 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                          (*(undefined4 *)(*(int *)(param1 + 0x44) + 0x5c),uVar2,
		                           Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		        uVar6 = *(undefined8 *)(iVar3 + 0x10);
		      }
		      *(undefined8 *)(param1_00 + 0x18) = uVar6;
		      iVar3 = func_ii_1082(param1_00,*(undefined4 *)(*piVar1 + 0x20));
		      if (iVar3 == 0) {
		        uVar2 = func_ii_1083();
		        func_ii_1050(uVar2,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar1[iVar4 + 4] = param1_00;
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar5 + 0xc));
		  }
		  iVar4 = unnamed_function_1417(UI_ToolTip_ToolTipData_SkillData____TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (iVar4,StringLiteral_12543,Method_UI_ToolTip_ToolTipData_SkillData_____ctor__);
		  *(int **)(iVar4 + 0x1c) = piVar1;
		  return iVar4;
		}
		*/


		/* --- GHIDRA: Gameplay.Combat.View.Players.ICombatPLayerView.get_gameObject ---
		void Gameplay_VortexCombat_View_Player_VortexCombatPlayerView__Gameplay_Combat_View_Players_ICombatPLayerView_get_gameObject
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int iVar5;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a58228 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Single_VortexCombatProgressBar_Config___);
		    Mono_Security_ASN1__get_Item(&System_Func_VortexCombatProgressBar_Config__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexCombat_View_Player_VortexCombatProgressBar__HandleStoneTypeChanged_b__5_0__
		              );
		    DAT_ram_00a58228 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x3c);
		  uVar2 = unnamed_function_1417(System_Func_VortexCombatProgressBar_Config__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param1,
		             Method_Gameplay_VortexCombat_View_Player_VortexCombatProgressBar__HandleStoneTypeChanged_b__5_0__
		             ,0);
		  iVar3 = func_ii_6917(param1_00,uVar2,
		                       Method_System_Linq_Enumerable_Single_VortexCombatProgressBar_Config___);
		  iVar4 = *(int *)(param1 + 0x34);
		  iVar5 = *(int *)(iVar4 + 0xc);
		  if (0 < iVar5) {
		    uVar2 = *(undefined4 *)(iVar3 + 0x10);
		    do {
		      func_ii_7050(*(undefined4 *)(iVar4 + iVar1 * 4 + 0x10),uVar2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar5);
		  }
		  iVar1 = *(int *)(param1 + 0x38);
		  iVar4 = *(int *)(iVar1 + 0xc);
		  if (0 < iVar4) {
		    uVar2 = *(undefined4 *)(iVar3 + 0x14);
		    iVar5 = 0;
		    do {
		      func_ii_7050(*(undefined4 *)(iVar1 + iVar5 * 4 + 0x10),uVar2,0);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar4);
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x30),*(undefined4 *)(iVar3 + 0xc),0);
		  return;
		}
		*/

}
